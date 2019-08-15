<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Users
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
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_perfiles = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_users)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_nombre)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_perfiles)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(12, 3)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 313)
        Me.pnl_filtros.TabIndex = 1
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.id_perfil_col, Me.col_email, Me.col_perfil, Me.col_id, Me.col_pass})
        Me.dgv_users.Location = New System.Drawing.Point(26, 115)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.Size = New System.Drawing.Size(372, 192)
        Me.dgv_users.TabIndex = 8
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(74, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(311, 86)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_perfiles
        '
        Me.cbo_perfiles.FormattingEnabled = True
        Me.cbo_perfiles.Location = New System.Drawing.Point(74, 48)
        Me.cbo_perfiles.Name = "cbo_perfiles"
        Me.cbo_perfiles.Size = New System.Drawing.Size(181, 21)
        Me.cbo_perfiles.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(33, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Perfil:"
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(58, 322)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 5
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 322)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(385, 322)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(104, 322)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 6
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'id_perfil_col
        '
        Me.id_perfil_col.HeaderText = "id_perfil"
        Me.id_perfil_col.Name = "id_perfil_col"
        Me.id_perfil_col.ReadOnly = True
        Me.id_perfil_col.Visible = False
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        Me.col_email.Width = 130
        '
        'col_perfil
        '
        Me.col_perfil.HeaderText = "Perfil"
        Me.col_perfil.Name = "col_perfil"
        Me.col_perfil.ReadOnly = True
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_pass
        '
        Me.col_pass.HeaderText = "Password"
        Me.col_pass.Name = "col_pass"
        Me.col_pass.ReadOnly = True
        Me.col_pass.Visible = False
        '
        'Frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 367)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizar usuarios"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents cbo_perfiles As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_users As System.Windows.Forms.DataGridView
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pass As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
