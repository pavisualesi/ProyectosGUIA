Public Class Frm_asignar_bug
    Private oUsersService As New UsuarioService
    Private oBugService As New BugService

    Private oBugSelected As Bug

    Private Sub Frm_asignar_bug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Frm_Bugs.llenarCombo(cbo_desa, oUsersService.consultarDesarrolladores, "nombre", "id_usuario")
        cbo_desa.SelectedIndex = -1
        cbo_desa.Focus()
    End Sub

    Public Sub asignar_bug(ByVal oBug As Bug)
        oBugSelected = oBug
        txt_id.Text = oBug.id_bug.ToString
        txt_titulo.Text = oBug.titulo
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_aceptar.Click
        Dim oHistorialBug As HistorialBug
        Dim oListBug As New List(Of Bug)

        If cbo_desa.Text = String.Empty Then
            MessageBox.Show("Debe completar todos los campos indicados con (*).", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Validamos el estado del bug
            If oBugSelected.estado = "Nuevo" Or oBugSelected.estado = "Cerrado" Or oBugSelected.estado = "En testing" Then
                oHistorialBug = New HistorialBug
                oHistorialBug.id_detalle = oBugSelected.historial.Count + 1
                oHistorialBug.asignado_a = cbo_desa.SelectedValue
                oHistorialBug.responsable = Frm_Principal.obtenerUsuarioLogin.id_usuario
                oHistorialBug.estado = 2
                oBugSelected.addHistorial(oHistorialBug)
                oListBug.Add(oBugSelected)

                If oBugService.actualizarBugConHistorial(oListBug) Then
                    MessageBox.Show("Bug actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ha ocurrido un error al actualizar el bug. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El bug no posee un estado válido para ser asignado", "Validación de negocio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
End Class