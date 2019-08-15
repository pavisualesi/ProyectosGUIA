<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(43, 19)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(33, 53)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(56, 13)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(88, 17)
        Me.txt_usuario.MaxLength = 10
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(163, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(87, 89)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(78, 23)
        Me.btn_ingresar.TabIndex = 2
        Me.btn_ingresar.Text = "&Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(171, 89)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 23)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.Location = New System.Drawing.Point(19, 125)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 22)
        Me.lbl_mensaje.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(88, 50)
        Me.txt_password.MaxLength = 10
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(162, 20)
        Me.txt_password.TabIndex = 1
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 132)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_usuario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox

End Class
