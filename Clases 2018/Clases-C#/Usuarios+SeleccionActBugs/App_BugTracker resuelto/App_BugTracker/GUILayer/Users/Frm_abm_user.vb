Public Class Frm_abm_user
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private oUsuarioService As New UsuarioService
    Private oUsuarioSelected As Usuario

    Private Sub Frm_new_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Bugs.llenarCombo(cbo_perfil, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Usuario"
 
            Case Opcion.update
                Me.Text = "Actualizar Usuario"
                'Recuperar usuario seleccionado en la grilla 
                mostrar_datos()
                txt_nombre.Enabled = True
                txt_email.Enabled = True
                txt_email.Enabled = True
                txt_password.Enabled = True
                txt_confirmar_pass.Enabled = True
                cbo_perfil.Enabled = True

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Usuario"
                txt_nombre.Enabled = False
                txt_email.Enabled = False
                txt_email.Enabled = False
                txt_password.Enabled = False
                cbo_perfil.Enabled = False
                txt_confirmar_pass.Enabled = False
        End Select
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub


    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal usuarioSelected As Usuario)
        _action = op
        oUsuarioSelected = usuarioSelected
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(oUsuarioSelected) Then
            txt_nombre.Text = oUsuarioSelected.nombre
            txt_email.Text = oUsuarioSelected.email
            txt_password.Text = oUsuarioSelected.password
            txt_confirmar_pass.Text = txt_password.Text
            cbo_perfil.Text = oUsuarioSelected.perfil
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim oUsuario As Usuario

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        oUsuario = New Usuario
                        oUsuario.nombre = txt_nombre.Text
                        oUsuario.password = txt_password.Text
                        oUsuario.email = txt_email.Text
                        oUsuario.id_perfil = cbo_perfil.SelectedValue
                        oUsuario.estado = "S"

                        If oUsuarioService.crearUsuario(oUsuario) Then
                            MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Opcion.update
                If validar_campos() Then
                    oUsuarioSelected.nombre = txt_nombre.Text
                    oUsuarioSelected.password = txt_password.Text
                    oUsuarioSelected.email = txt_email.Text
                    oUsuarioSelected.id_perfil = cbo_perfil.SelectedValue
                    
                    If oUsuarioService.actualizarUsuario(oUsuarioSelected) Then
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If oUsuarioSelected.estado = "N" Then
                        oUsuarioSelected.estado = "S"
                    Else
                        oUsuarioSelected.estado = "N"
                    End If

                    If oUsuarioService.modificarEstadoUsuario(oUsuarioSelected) Then
                        MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()

                    Else
                        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_password.Text = String.Empty Then
            txt_password.BackColor = Color.Red
            txt_password.Focus()
            Return False
        Else
            txt_password.BackColor = Color.White
        End If

        If txt_confirmar_pass.Text = String.Empty Then
            txt_confirmar_pass.BackColor = Color.Red
            txt_confirmar_pass.Focus()
            Return False
        Else
            txt_confirmar_pass.BackColor = Color.White
        End If

        If cbo_perfil.Text = String.Empty Then
            cbo_perfil.BackColor = Color.Red
            cbo_perfil.Focus()
            Return False
        Else
            cbo_perfil.BackColor = Color.White
        End If

        If txt_confirmar_pass.Text <> txt_password.Text Then
            txt_confirmar_pass.BackColor = Color.Red
            txt_password.BackColor = Color.Red
            txt_confirmar_pass.Focus()
            Return False
        Else
            txt_confirmar_pass.BackColor = Color.White
            txt_password.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Return Not IsNothing(oUsuarioService.validarNombreUsuario(txt_nombre.Text))
    End Function
End Class