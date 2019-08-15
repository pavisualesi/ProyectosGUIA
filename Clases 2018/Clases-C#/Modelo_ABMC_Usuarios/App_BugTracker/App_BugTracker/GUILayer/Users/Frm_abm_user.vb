Public Class Frm_abm_user
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_new_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Bugs.llenarCombo(cbo_perfil, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Usuario"
                _row_selected = Nothing

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


    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            txt_email.Text = _row_selected.Cells("col_email").Value
            txt_password.Text = _row_selected.Cells("col_pass").Value
            txt_confirmar_pass.Text = txt_password.Text
            cbo_perfil.Text = _row_selected.Cells("col_perfil").Value
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        str_sql = "INSERT INTO users (n_usuario, password, email, id_perfil, estado) VALUES('"
                        str_sql += txt_nombre.Text + "','"
                        str_sql += txt_password.Text + "','"
                        str_sql += txt_email.Text + "',"
                        str_sql += cbo_perfil.SelectedValue.ToString + ", 'S')"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    str_sql = "UPDATE users SET n_usuario = '"
                    str_sql += txt_nombre.Text + "', password = '"
                    str_sql += txt_password.Text + "', email = '"
                    str_sql += txt_email.Text + "', id_perfil = "
                    str_sql += cbo_perfil.SelectedValue.ToString
                    str_sql += " WHERE id_usuario = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from users where id_usuario = " + _row_selected.Cells("col_id").Value).Rows(0).Item("estado").ToString
                    If estado = "N" Then
                        estado = "S"
                    Else
                        estado = "N"
                    End If
                    str_sql = "UPDATE users SET estado = '" + estado + "' WHERE id_usuario = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
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
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from users where n_usuario = '" + txt_nombre.Text + "'").Rows.Count > 0
    End Function

End Class