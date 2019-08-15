Public Class UsuarioDao
    'Permite recuperar un usuario a partir de un nombre y password
    Public Function getUserByNamePass(ByVal nombre As String, ByVal password As String) As Usuario
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil AND x.n_usuario = '" + nombre + "' AND password = '" + password + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count Then
            oUsuario = map_user(oTabla.Rows(0))
        End If

        Return oUsuario
    End Function

    Public Function getUserByName(nombre As String) As Usuario
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil AND x.n_usuario = '" + nombre + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count Then
            oUsuario = map_user(oTabla.Rows(0))
        End If

        Return oUsuario
    End Function



    'Permite recuperar todos los usuarios cargados
    Public Function getAll() As IList(Of Usuario)
        Dim lst As New List(Of Usuario)
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil"
        Dim oUsuario As Usuario = Nothing

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(sql).Rows
            lst.Add(map_user(row))
        Next

        Return lst
    End Function

    'Permite recuperar todos los usuarios cargados para un determinado rango de fechas y/o perfil recibidos como 
    'parámetrosr
    Public Function getByFilters(ByVal params As Object()) As IList(Of Usuario)

        Dim lst As New List(Of Usuario)
        Dim sql As String = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil "
        Dim oUsuario As Usuario = Nothing

        If Not IsNothing(params(0)) Then sql += " AND x.id_perfil=@param1 "
        If Not IsNothing(params(1)) Then sql += " AND x.n_usuario LIKE '%' + @param2 + '%' "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql, params).Rows
            lst.Add(map_user(row))
        Next

        Return lst
    End Function

    'Funciones CRUD
    Public Function create(ByVal oUsuario As Usuario)
        Dim str_sql As String

        str_sql = "INSERT INTO users (n_usuario, password, email, id_perfil, estado) VALUES('"
        str_sql += oUsuario.nombre + "','"
        str_sql += oUsuario.password + "','"
        str_sql += oUsuario.email + "',"
        str_sql += oUsuario.id_perfil.ToString + ", 'S')"

        'Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function
    'Funciones CRUD

    Public Function update(ByVal oUsuario As Usuario)
        Dim str_sql As String

        str_sql = "UPDATE users SET n_usuario = '"
        str_sql += oUsuario.nombre + "', password = '"
        str_sql += oUsuario.password + "', email = '"
        str_sql += oUsuario.email + "', id_perfil = "
        str_sql += oUsuario.id_perfil.ToString + ", estado = '"
        str_sql += oUsuario.estado + "'"

        str_sql += " WHERE id_usuario = " + oUsuario.id_usuario.ToString

        'Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function

    'Función auxiliar responsable de MAPPEAR una fila de Users a un objeto Usuario
    Private Function map_user(ByRef row As DataRow) As Usuario
        Dim oUsuario As New Usuario

        oUsuario.id_usuario = Convert.ToInt32(row.Item("id_usuario").ToString)
        oUsuario.nombre = row.Item("n_usuario").ToString
        oUsuario.password = row.Item("password").ToString
        oUsuario.email = row.Item("email").ToString
        oUsuario.perfil = row.Item("n_perfil").ToString
        oUsuario.estado = row.Item("estado").ToString
        oUsuario.id_perfil = row.Item("id_perfil").ToString
        Return oUsuario
    End Function
End Class
