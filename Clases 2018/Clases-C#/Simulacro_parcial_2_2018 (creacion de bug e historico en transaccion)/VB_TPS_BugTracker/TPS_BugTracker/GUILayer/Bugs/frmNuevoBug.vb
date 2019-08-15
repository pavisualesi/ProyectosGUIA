Partial Public Class frmNuevoBug
    Inherits Form

    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private criticidadService As CriticidadService = New CriticidadService()
    Private oBug As Bug
    Private oBugService As BugService = New BugService()

    Public Sub New()
        InitializeComponent()
        oBugService = New BugService()
        GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_aceptar.Click
        oBug = New Bug()
        oBug.titulo = txtTitulo.Text
        oBug.descripcion = txtDescripcion.Text
        oBug.id_prioridad = CInt(cboPrioridad.SelectedValue)
        oBug.id_criticidad = CInt(cboCriticidad.SelectedValue)
        oBug.id_producto = CInt(cboProducto.SelectedValue)
        oBug.id_estado = 1

        If oBugService.crearBug(oBug) Then
            MessageBox.Show("Bug insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        Me.Close()
    End Sub

    Private Sub frmNuevoBug_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub
End Class