<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_actualizar_bug
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.cbo_productos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descri = New System.Windows.Forms.TextBox()
        Me.cbo_prioridades = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_criticidades = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(185, 216)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(101, 216)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(78, 23)
        Me.btn_aceptar.TabIndex = 5
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'cbo_productos
        '
        Me.cbo_productos.FormattingEnabled = True
        Me.cbo_productos.Location = New System.Drawing.Point(78, 116)
        Me.cbo_productos.Name = "cbo_productos"
        Me.cbo_productos.Size = New System.Drawing.Size(254, 21)
        Me.cbo_productos.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Producto(*):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Titulo(*):"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(78, 11)
        Me.txt_nombre.MaxLength = 100
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(254, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_descri
        '
        Me.txt_descri.Location = New System.Drawing.Point(78, 38)
        Me.txt_descri.MaxLength = 1000
        Me.txt_descri.Multiline = True
        Me.txt_descri.Name = "txt_descri"
        Me.txt_descri.Size = New System.Drawing.Size(254, 72)
        Me.txt_descri.TabIndex = 1
        '
        'cbo_prioridades
        '
        Me.cbo_prioridades.FormattingEnabled = True
        Me.cbo_prioridades.Location = New System.Drawing.Point(78, 143)
        Me.cbo_prioridades.Name = "cbo_prioridades"
        Me.cbo_prioridades.Size = New System.Drawing.Size(254, 21)
        Me.cbo_prioridades.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Criticidad:"
        '
        'cbo_criticidades
        '
        Me.cbo_criticidades.FormattingEnabled = True
        Me.cbo_criticidades.Location = New System.Drawing.Point(78, 170)
        Me.cbo_criticidades.Name = "cbo_criticidades"
        Me.cbo_criticidades.Size = New System.Drawing.Size(254, 21)
        Me.cbo_criticidades.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Prioridad:"
        '
        'Frm_actualizar_bug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 251)
        Me.Controls.Add(Me.cbo_criticidades)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_prioridades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_descri)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cbo_productos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_actualizar_bug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizar Bug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_productos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descri As System.Windows.Forms.TextBox
    Friend WithEvents cbo_prioridades As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_criticidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
