Public Class Frm_Users
    Private oUsuarioService As New UsuarioService

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Frm_abm_user.ShowDialog()
    End Sub

    Private Sub Frm_Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Bugs.llenarCombo(cbo_perfiles, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
            cbo_perfiles.Enabled = False
        Else
            txt_nombre.Enabled = True
            cbo_perfiles.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click

        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.
            If cbo_perfiles.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_perfiles.SelectedValue)
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Perfiles' esta seleccionado.
            If txt_nombre.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_nombre.Text)
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If flag_filtros Then
                llenar_grid(oUsuarioService.consultarUsuariosConFiltros(filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenar_grid(oUsuarioService.consultarUsuarios)
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As IList(Of Usuario))
        dgv_users.Rows.Clear()
        For Each oUsuario As Usuario In source
            dgv_users.Rows.Add(New String() {oUsuario.nombre, oUsuario.id_perfil, oUsuario.email, oUsuario.perfil, oUsuario.id_usuario, oUsuario.password})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Frm_abm_user.seleccionar_usuario(Frm_abm_user.Opcion.update, map_usuario_fila())
        Frm_abm_user.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub dgv_users_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_users.CellClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Frm_abm_user.seleccionar_usuario(Frm_abm_user.Opcion.delete, map_usuario_fila())
        Frm_abm_user.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Function map_usuario_fila() As Usuario
        Dim oUsuario As New Usuario
        oUsuario.nombre = dgv_users.CurrentRow.Cells("col_nombre").Value
        oUsuario.perfil = dgv_users.CurrentRow.Cells("col_perfil").Value
        oUsuario.password = dgv_users.CurrentRow.Cells("col_pass").Value
        oUsuario.email = dgv_users.CurrentRow.Cells("col_email").Value
        oUsuario.id_usuario = dgv_users.CurrentRow.Cells("col_id").Value
        oUsuario.id_perfil = dgv_users.CurrentRow.Cells("id_perfil_col").Value
        Return oUsuario
    End Function
End Class