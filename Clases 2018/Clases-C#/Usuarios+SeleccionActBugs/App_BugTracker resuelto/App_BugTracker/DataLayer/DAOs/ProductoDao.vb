Public Class ProductoDao
    Public Function getAll() As List(Of Producto)
        Dim lst As New List(Of Producto)
        Dim oProducto As Producto = Nothing

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("Select * from Productos").Rows
            lst.Add(map(row))
        Next

        Return lst
    End Function

    Private Function map(ByRef row As DataRow) As Producto
        Dim oProducto As New Producto
        oProducto.id_Producto = Convert.ToInt32(row.Item("id_producto").ToString)
        oProducto.nombre = row.Item("nombre").ToString
        Return oProducto
    End Function
End Class
