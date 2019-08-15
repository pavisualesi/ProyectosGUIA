Public Class HistorialBug
    Public Property id_detalle As Integer
    Public Property responsable As Integer
    'Nombre del usuario responsable de generar el historial del bug
    Public Property n_responsable As String
    Public Property fecha As Date
    Public Property asignado_a As Integer
    'Nombre del usuario asignado a resolver el bug en el historial
    Public Property n_asignado_a As String
    Public Property estado As Integer
    'Nombre del estado
    Public Property n_estado As String
End Class
