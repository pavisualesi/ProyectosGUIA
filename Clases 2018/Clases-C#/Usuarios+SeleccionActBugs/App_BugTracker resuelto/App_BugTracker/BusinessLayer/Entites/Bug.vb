Public Class Bug
    Public Property id_bug As Integer
    Public Property titulo As String
    Public Property descripcion As String
    Public Property id_producto As Integer
    'Nombre producto
    Public Property n_producto As String
    Public Property id_prioridad As Integer
    'Nombre prioridad
    Public Property n_prioridad As String
    Public Property id_criticidad As Integer
    'Nombre criticidad
    Public Property n_criticidad As String
    'Nombre del último estado o estado actual del bug
    Public Property estado As String
    'Fecha de alta o fecha de creación. 
    Public Property fecha_alta As Date
    Public Property asignado_a As String

    Public Property historial As List(Of HistorialBug)

    Public Sub New()
        historial = New List(Of HistorialBug)
    End Sub

    Public Sub addHistorial(ByVal oHistorialBug As HistorialBug)
        historial.Add(oHistorialBug)
    End Sub

End Class
