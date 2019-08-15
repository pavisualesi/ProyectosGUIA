Public Class BugDao
    
    Public Function getBugById(ByVal id As Integer) As Bug
  
        Dim sql As String = "SELECT * FROM ( SELECT " & _
        "t.id_bug," & _
        "t.titulo," & _
        "t.descripcion," & _
        "t.id_producto," & _
        "t.id_prioridad," & _
        "t.fecha_alta," & _
        "t.id_criticidad," & _
        "t2.nombre," & _
        "t4.n_prioridad," & _
        "t5.n_criticidad," & _
        "(SELECT n_estado FROM Estados e, Historiales_Bug h WHERE e.id_estado = h.id_estado AND h.id_bug = t.id_bug AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as estado," & _
        "(SELECT n_usuario FROM Historiales_Bug h, users u WHERE h.id_bug = t.id_bug AND h.id_estado = 2 AND h.asignado_a = u.id_usuario AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as asignado_a " & _
        " FROM bugs t, Productos t2, Prioridades t4, Criticidades t5" & _
        " WHERE(t.id_producto = t2.id_producto)" & _
        " AND t.id_prioridad = t4.id_prioridad" & _
        " AND t.id_criticidad = t5.id_criticidad" & _
        " AND t.id_bug =" + id.ToString & _
        " ) as t_bugs"


        Return mapBug(BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0))
    End Function

    Public Function getBugByFilters(ByVal params As Object()) As IList(Of Bug)
        Dim lst As New List(Of Bug)

        Dim sql As String = "SELECT * FROM (SELECT  TOP 20 " & _
        "t.id_bug," & _
        "t.titulo," & _
        "t2.nombre," & _
        "t.fecha_alta," & _
        "t4.n_prioridad," & _
        "t5.n_criticidad," & _
        "(SELECT n_estado FROM Estados e, Historiales_Bug h WHERE e.id_estado = h.id_estado AND h.id_bug = t.id_bug AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as estado," & _
        "(SELECT n_usuario FROM Historiales_Bug h, users u WHERE h.id_bug = t.id_bug AND h.id_estado = 2 AND h.asignado_a = u.id_usuario AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as asignado_a " & _
        " FROM bugs t, Productos t2, Prioridades t4, Criticidades t5" & _
        " WHERE t.id_producto = t2.id_producto" & _
        " AND t.id_prioridad = t4.id_prioridad" & _
        " AND t.id_criticidad = t5.id_criticidad"

        'Validamos filtro de fechas
        If Not IsNothing(params(0)) And Not IsNothing(params(1)) Then
            sql += " AND (t.fecha_alta>=@param1 AND t.fecha_alta<=@param2) "
        End If
        'Validamos filtro prioridad
        If Not IsNothing(params(2)) Then sql += "AND t.id_prioridad=@param3 "
        'Validamos filtro criticidad
        If Not IsNothing(params(3)) Then sql += "AND t.id_criticidad=@param4 "
        'Validamos filtro producto
        If Not IsNothing(params(4)) Then sql += "AND t.id_producto=@param5 "
        sql += "ORDER BY t.fecha_alta DESC) as t_bugs WHERE 1=1"

        'Validamos filtro estado al final del query porque al ser una columna SELECT dentro de la consulta principal
        'La validamos luego de armar consulta completa para hacer un segundo WHERE ahora si por estado.
        If Not IsNothing(params(5)) Then sql += " AND estado=@param6 "
        'Con el mismo criterio validamos filtro asignado_a
        If Not IsNothing(params(6)) Then sql += " AND asignado_a=@param7 "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql, params).Rows
            lst.Add(mapSmallBug(row))
        Next

        Return lst
    End Function

    Public Function create(ByVal oBug As Bug) As Boolean
        Dim str_sql As String = ""
        str_sql = "INSERT INTO Bugs (titulo, descripcion, id_producto,id_prioridad, id_criticidad, fecha_alta) VALUES('"
        str_sql += oBug.titulo + "','"
        str_sql += oBug.descripcion + "',"
        str_sql += oBug.id_producto.ToString + ","
        str_sql += oBug.id_prioridad.ToString + ","
        str_sql += oBug.id_criticidad.ToString + ","
        str_sql += " GETDATE());"

        str_sql += "INSERT INTO Historiales_Bug (id_bug, id_detalle, fecha,responsable, id_estado) VALUES("
        str_sql += "@@IDENTITY,1,GETDATE(),"
        str_sql += oBug.historial.First.responsable.ToString + ","
        str_sql += oBug.historial.First.estado.ToString + ");"

        Return BDHelper.getDBHelper.EjecutarSQL(str_sql) = 2
    End Function

    Public Function updateNewHistorial(ByVal lst As List(Of Bug)) As Boolean
        Dim str_sql As String = ""
        Dim oHistorial As HistorialBug
        'Por cada bug recibido en la lista concatenamos un INSERT y luego ejecutamos una X cantidad de SENTENCIAS INSERT
        'todas juntas dentro de una transacción que se la pedimos al BDHelper

        For Each oBug As Bug In lst
            oHistorial = oBug.historial.Last

            str_sql += "INSERT INTO Historiales_Bug (id_bug, id_detalle, fecha,responsable, asignado_a, id_estado) VALUES("
            str_sql += oBug.id_bug.ToString + ","
            str_sql += oHistorial.id_detalle.ToString + ","
            str_sql += "GETDATE(),"
            str_sql += oHistorial.responsable.ToString + ","
            If (oHistorial.asignado_a <> 0) Then
                str_sql += oHistorial.asignado_a.ToString + ","
            Else
                str_sql += "NULL,"
            End If
            str_sql += oHistorial.estado.ToString + ");" 'NOTAR que cada sentencia armada termina con ';'
            'Lo cual hace que el motor ejecute varias sentencias a la vez separadas por ;
        Next

        
        Return BDHelper.getDBHelper.EjecutarSQL(str_sql) = lst.Count 'NOTAR que será verdadero si y solo se ejecutan exitosamente
        'tantos INSERT como objetos tenga la lista (ES UN INSERT POR CADA HISTORIAL de BUG generado)
    End Function


    Private Function mapSmallBug(ByVal row As DataRow) As Bug
        Dim oBug As New Bug

        oBug.id_bug = Convert.ToInt32(row.Item("id_bug").ToString)
        oBug.titulo = row.Item("titulo").ToString
        oBug.fecha_alta = Convert.ToDateTime(row.Item("fecha_alta").ToString)
        oBug.n_producto = row.Item("nombre").ToString
        oBug.estado = row.Item("estado").ToString
        oBug.asignado_a = row.Item("asignado_a").ToString
        oBug.n_prioridad = row.Item("n_prioridad").ToString
        oBug.n_criticidad = row.Item("n_criticidad").ToString

        Return oBug
    End Function

    Private Function mapBug(ByVal row As DataRow) As Bug
        Dim oBug As New Bug
        Dim sql As String
        Dim oHistorial_bug As HistorialBug

        oBug.id_bug = Convert.ToInt32(row.Item("id_bug").ToString)
        oBug.titulo = row.Item("titulo").ToString
        oBug.descripcion = row.Item("descripcion").ToString
        oBug.fecha_alta = Convert.ToDateTime(row.Item("fecha_alta").ToString)
        oBug.id_producto = Convert.ToInt32(row.Item("id_producto").ToString)
        oBug.id_prioridad = Convert.ToInt32(row.Item("id_prioridad").ToString)
        oBug.id_criticidad = Convert.ToInt32(row.Item("id_criticidad").ToString)
        oBug.n_producto = row.Item("nombre").ToString
        oBug.n_criticidad = row.Item("n_criticidad").ToString
        oBug.estado = row.Item("estado").ToString

        sql = "SELECT h.*, e.n_estado, u.n_usuario n_responsable, (SELECT n_usuario FROM Users t1 LEFT JOIN Historiales_Bug t2 ON t1.id_usuario = t2.asignado_a WHERE t2.id_bug = h.id_bug) as n_asignado_a " & _
        " FROM Historiales_Bug h, estados e, users u" & _
        " WHERE(h.id_estado = e.id_estado)" & _
        " AND h.responsable = u.id_usuario" & _
        " AND h.id_bug =" + oBug.id_bug.ToString


        For Each detail As DataRow In BDHelper.getDBHelper.ConsultaSQL(sql).Rows
            oHistorial_bug = New HistorialBug
            oHistorial_bug.id_detalle = Convert.ToInt32(detail.Item("id_detalle").ToString)
            oHistorial_bug.responsable = Convert.ToInt32(detail.Item("responsable").ToString)
            If Not IsDBNull(detail.Item("asignado_a")) Then
                oHistorial_bug.asignado_a = Convert.ToInt32(detail.Item("asignado_a").ToString)
                oHistorial_bug.n_asignado_a = detail.Item("n_asignado_a").ToString
            End If
            oHistorial_bug.estado = Convert.ToInt32(detail.Item("id_estado").ToString)
            oHistorial_bug.fecha = Convert.ToDateTime(detail.Item("fecha").ToString)
            oHistorial_bug.n_responsable = detail.Item("n_responsable").ToString
            oHistorial_bug.n_estado = detail.Item("n_estado").ToString
            oBug.addHistorial(oHistorial_bug)
        Next

        Return oBug
    End Function

End Class
