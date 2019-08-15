Public Class Frm_actualizar_bug

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_aceptar.Click
        Dim oBug As Bug
        Dim oHistorialBug As HistorialBug
        Dim oBugService As New BugService

        If String.IsNullOrEmpty(txt_nombre.Text) Or String.IsNullOrEmpty(cbo_productos.Text) Then
            MessageBox.Show("Debe completar todos los campos indicados con (*).", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nombre.Focus()
        Else
            oBug = New Bug
            oBug.titulo = txt_nombre.Text
            oBug.descripcion = txt_descri.Text
            oBug.id_producto = cbo_productos.SelectedValue
            oBug.id_prioridad = cbo_prioridades.SelectedValue
            oBug.id_criticidad = cbo_criticidades.SelectedValue
            oHistorialBug = New HistorialBug
            oHistorialBug.estado = 1
            oHistorialBug.responsable = Frm_Principal.obtenerUsuarioLogin.id_usuario
            oBug.addHistorial(oHistorialBug)

            If oBugService.create(oBug) Then
                MessageBox.Show("Bug registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Ha ocurrido un error al registrar el bug. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Frm_actualizar_bug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim oProductoService As New ProductoService
        Dim oPrioridadService As New PrioridadService
        Dim oCriticidadService As New CriticidadService

        Frm_Bugs.llenarCombo(cbo_prioridades, oPrioridadService.consultarPrioridades, "nombre", "id_prioridad")
        Frm_Bugs.llenarCombo(cbo_criticidades, oCriticidadService.consultarCriticidades, "nombre", "id_criticidad")
        Frm_Bugs.llenarCombo(cbo_productos, oProductoService.consultarProductos, "nombre", "id_producto")
    End Sub
End Class