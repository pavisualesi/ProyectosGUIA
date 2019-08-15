<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.pnl_info_user = New System.Windows.Forms.Panel()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Mnu_principal = New System.Windows.Forms.MenuStrip()
        Me.BugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConsultaDeBugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_info_user.SuspendLayout()
        Me.Mnu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_info_user
        '
        Me.pnl_info_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_info_user.Controls.Add(Me.Label1)
        Me.pnl_info_user.Controls.Add(Me.lbl_user)
        Me.pnl_info_user.ForeColor = System.Drawing.Color.White
        Me.pnl_info_user.Location = New System.Drawing.Point(1, 27)
        Me.pnl_info_user.Name = "pnl_info_user"
        Me.pnl_info_user.Size = New System.Drawing.Size(461, 35)
        Me.pnl_info_user.TabIndex = 0
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(37, 14)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(55, 13)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "Sin sesión"
        '
        'Mnu_principal
        '
        Me.Mnu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoporteToolStripMenuItem, Me.BugsToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Mnu_principal.Location = New System.Drawing.Point(0, 0)
        Me.Mnu_principal.Name = "Mnu_principal"
        Me.Mnu_principal.Size = New System.Drawing.Size(461, 24)
        Me.Mnu_principal.TabIndex = 1
        Me.Mnu_principal.Text = "MenuStrip1"
        '
        'BugsToolStripMenuItem
        '
        Me.BugsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeBugsToolStripMenuItem})
        Me.BugsToolStripMenuItem.Name = "BugsToolStripMenuItem"
        Me.BugsToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.BugsToolStripMenuItem.Text = "&Bugs"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Label1
        '
        Me.Label1.Image = Global.App_BugTracker.My.Resources.Resources.user_log
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 32)
        Me.Label1.TabIndex = 1
        '
        'ConsultaDeBugsToolStripMenuItem
        '
        Me.ConsultaDeBugsToolStripMenuItem.Image = Global.App_BugTracker.My.Resources.Resources.BUSCAR01
        Me.ConsultaDeBugsToolStripMenuItem.Name = "ConsultaDeBugsToolStripMenuItem"
        Me.ConsultaDeBugsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ConsultaDeBugsToolStripMenuItem.Text = "&Consulta de bugs"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SoporteToolStripMenuItem.Text = "&Soporte"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.App_BugTracker.My.Resources.Resources.user_log
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(461, 262)
        Me.Controls.Add(Me.pnl_info_user)
        Me.Controls.Add(Me.Mnu_principal)
        Me.MainMenuStrip = Me.Mnu_principal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_info_user.ResumeLayout(False)
        Me.pnl_info_user.PerformLayout()
        Me.Mnu_principal.ResumeLayout(False)
        Me.Mnu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_info_user As System.Windows.Forms.Panel
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Mnu_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents BugsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeBugsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
