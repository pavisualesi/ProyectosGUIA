Public Class PrioridadDao
    Public Function getAll() As List(Of Prioridad)
        Dim lst As New List(Of Prioridad)
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("Select * from Prioridades").Rows
            lst.Add(map(row))
        Next
        Return lst
    End Function

    Private Function map(ByRef row As DataRow) As Prioridad
        Dim oPrioridad As New Prioridad
        oPrioridad.id_prioridad = Convert.ToInt32(row.Item("id_prioridad").ToString)
        oPrioridad.nombre = row.Item("n_prioridad").ToString
        Return oPrioridad
    End Function
End Class
