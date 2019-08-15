Public Class CriticidadDao
    Public Function getAll() As List(Of Criticidad)
        Dim lst As New List(Of Criticidad)
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("Select * from Criticidades").Rows
            lst.Add(map(row))
        Next
        Return lst
    End Function

    Private Function map(ByRef row As DataRow) As Criticidad
        Dim oCriticidad As New Criticidad
        oCriticidad.id_criticidad = Convert.ToInt32(row.Item("id_criticidad").ToString)
        oCriticidad.nombre = row.Item("n_criticidad").ToString
        Return oCriticidad
    End Function
End Class
