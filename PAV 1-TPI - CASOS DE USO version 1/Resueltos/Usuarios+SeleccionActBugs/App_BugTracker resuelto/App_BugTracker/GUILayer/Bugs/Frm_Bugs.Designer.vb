<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bugs
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
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.cbo_productos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fec_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fec_desde = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_criticidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_prioridades = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_asignadoA = New System.Windows.Forms.ComboBox()
        Me.lbl_asignado = New System.Windows.Forms.Label()
        Me.cbo_estados = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.dgv_bugs = New System.Windows.Forms.DataGridView()
        Me.id_bug_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignado_a_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.criticidad_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prioridad_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_pasar_a_te = New System.Windows.Forms.Button()
        Me.btn_detalle_bug = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_bugs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.cbo_productos)
        Me.pnl_filtros.Controls.Add(Me.Label5)
        Me.pnl_filtros.Controls.Add(Me.txt_fec_hasta)
        Me.pnl_filtros.Controls.Add(Me.Label4)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_fec_desde)
        Me.pnl_filtros.Controls.Add(Me.cbo_criticidades)
        Me.pnl_filtros.Controls.Add(Me.Label1)
        Me.pnl_filtros.Controls.Add(Me.cbo_prioridades)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_asignadoA)
        Me.pnl_filtros.Controls.Add(Me.lbl_asignado)
        Me.pnl_filtros.Controls.Add(Me.cbo_estados)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(2, 3)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(843, 464)
        Me.pnl_filtros.TabIndex = 0
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'cbo_productos
        '
        Me.cbo_productos.FormattingEnabled = True
        Me.cbo_productos.Location = New System.Drawing.Point(74, 102)
        Me.cbo_productos.Name = "cbo_productos"
        Me.cbo_productos.Size = New System.Drawing.Size(181, 21)
        Me.cbo_productos.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Producto:"
        '
        'txt_fec_hasta
        '
        Me.txt_fec_hasta.Location = New System.Drawing.Point(374, 22)
        Me.txt_fec_hasta.Mask = "00/00/0000"
        Me.txt_fec_hasta.Name = "txt_fec_hasta"
        Me.txt_fec_hasta.Size = New System.Drawing.Size(180, 20)
        Me.txt_fec_hasta.TabIndex = 13
        Me.txt_fec_hasta.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha desde:"
        '
        'txt_fec_desde
        '
        Me.txt_fec_desde.Location = New System.Drawing.Point(74, 22)
        Me.txt_fec_desde.Mask = "00/00/0000"
        Me.txt_fec_desde.Name = "txt_fec_desde"
        Me.txt_fec_desde.Size = New System.Drawing.Size(181, 20)
        Me.txt_fec_desde.TabIndex = 9
        Me.txt_fec_desde.ValidatingType = GetType(Date)
        '
        'cbo_criticidades
        '
        Me.cbo_criticidades.FormattingEnabled = True
        Me.cbo_criticidades.Location = New System.Drawing.Point(374, 78)
        Me.cbo_criticidades.Name = "cbo_criticidades"
        Me.cbo_criticidades.Size = New System.Drawing.Size(181, 21)
        Me.cbo_criticidades.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Criticidad:"
        '
        'cbo_prioridades
        '
        Me.cbo_prioridades.FormattingEnabled = True
        Me.cbo_prioridades.Location = New System.Drawing.Point(74, 75)
        Me.cbo_prioridades.Name = "cbo_prioridades"
        Me.cbo_prioridades.Size = New System.Drawing.Size(181, 21)
        Me.cbo_prioridades.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prioridad:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(374, 105)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_asignadoA
        '
        Me.cbo_asignadoA.FormattingEnabled = True
        Me.cbo_asignadoA.Location = New System.Drawing.Point(373, 51)
        Me.cbo_asignadoA.Name = "cbo_asignadoA"
        Me.cbo_asignadoA.Size = New System.Drawing.Size(181, 21)
        Me.cbo_asignadoA.TabIndex = 3
        '
        'lbl_asignado
        '
        Me.lbl_asignado.AutoSize = True
        Me.lbl_asignado.Location = New System.Drawing.Point(306, 54)
        Me.lbl_asignado.Name = "lbl_asignado"
        Me.lbl_asignado.Size = New System.Drawing.Size(63, 13)
        Me.lbl_asignado.TabIndex = 2
        Me.lbl_asignado.Text = "Asignado a:"
        '
        'cbo_estados
        '
        Me.cbo_estados.FormattingEnabled = True
        Me.cbo_estados.Location = New System.Drawing.Point(74, 48)
        Me.cbo_estados.Name = "cbo_estados"
        Me.cbo_estados.Size = New System.Drawing.Size(181, 21)
        Me.cbo_estados.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Estado:"
        '
        'dgv_bugs
        '
        Me.dgv_bugs.AllowUserToAddRows = False
        Me.dgv_bugs.AllowUserToDeleteRows = False
        Me.dgv_bugs.AllowUserToOrderColumns = True
        Me.dgv_bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bugs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_bug_col, Me.titulo_col, Me.producto_col, Me.fecha_col, Me.estado_col, Me.asignado_a_col, Me.criticidad_col, Me.prioridad_col})
        Me.dgv_bugs.Location = New System.Drawing.Point(12, 144)
        Me.dgv_bugs.Name = "dgv_bugs"
        Me.dgv_bugs.ReadOnly = True
        Me.dgv_bugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bugs.Size = New System.Drawing.Size(827, 309)
        Me.dgv_bugs.TabIndex = 5
        '
        'id_bug_col
        '
        Me.id_bug_col.HeaderText = "# Bug"
        Me.id_bug_col.Name = "id_bug_col"
        Me.id_bug_col.ReadOnly = True
        '
        'titulo_col
        '
        Me.titulo_col.HeaderText = "Título"
        Me.titulo_col.Name = "titulo_col"
        Me.titulo_col.ReadOnly = True
        '
        'producto_col
        '
        Me.producto_col.HeaderText = "Producto"
        Me.producto_col.Name = "producto_col"
        Me.producto_col.ReadOnly = True
        '
        'fecha_col
        '
        Me.fecha_col.HeaderText = "Fecha creación"
        Me.fecha_col.Name = "fecha_col"
        Me.fecha_col.ReadOnly = True
        '
        'estado_col
        '
        Me.estado_col.HeaderText = "Estado"
        Me.estado_col.Name = "estado_col"
        Me.estado_col.ReadOnly = True
        '
        'asignado_a_col
        '
        Me.asignado_a_col.HeaderText = "Asignado a"
        Me.asignado_a_col.Name = "asignado_a_col"
        Me.asignado_a_col.ReadOnly = True
        '
        'criticidad_col
        '
        Me.criticidad_col.HeaderText = "Criticidad"
        Me.criticidad_col.Name = "criticidad_col"
        Me.criticidad_col.ReadOnly = True
        '
        'prioridad_col
        '
        Me.prioridad_col.HeaderText = "Prioridad"
        Me.prioridad_col.Name = "prioridad_col"
        Me.prioridad_col.ReadOnly = True
        '
        'btn_pasar_a_te
        '
        Me.btn_pasar_a_te.Enabled = False
        Me.btn_pasar_a_te.Image = Global.App_BugTracker.My.Resources.Resources.cerrarBug1
        Me.btn_pasar_a_te.Location = New System.Drawing.Point(143, 473)
        Me.btn_pasar_a_te.Name = "btn_pasar_a_te"
        Me.btn_pasar_a_te.Size = New System.Drawing.Size(40, 40)
        Me.btn_pasar_a_te.TabIndex = 11
        Me.btn_pasar_a_te.UseVisualStyleBackColor = True
        '
        'btn_detalle_bug
        '
        Me.btn_detalle_bug.Image = Global.App_BugTracker.My.Resources.Resources.comentar
        Me.btn_detalle_bug.Location = New System.Drawing.Point(289, 473)
        Me.btn_detalle_bug.Name = "btn_detalle_bug"
        Me.btn_detalle_bug.Size = New System.Drawing.Size(38, 40)
        Me.btn_detalle_bug.TabIndex = 10
        Me.btn_detalle_bug.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(805, 473)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(97, 473)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 8
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.Image = Global.App_BugTracker.My.Resources.Resources.user_log
        Me.btn_asignar.Location = New System.Drawing.Point(54, 473)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(40, 40)
        Me.btn_asignar.TabIndex = 7
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 473)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Enabled = False
        Me.btn_cerrar.Image = Global.App_BugTracker.My.Resources.Resources.Empty_Recycle_Bin_2000
        Me.btn_cerrar.Location = New System.Drawing.Point(189, 473)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 12
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Frm_Bugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(857, 525)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_pasar_a_te)
        Me.Controls.Add(Me.dgv_bugs)
        Me.Controls.Add(Me.btn_detalle_bug)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_asignar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Bugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta General de Bugs"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_bugs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_asignadoA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_asignado As System.Windows.Forms.Label
    Friend WithEvents cbo_estados As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_bugs As System.Windows.Forms.DataGridView
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_detalle_bug As System.Windows.Forms.Button
    Friend WithEvents txt_fec_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fec_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_criticidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_prioridades As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_productos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_bug_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asignado_a_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents criticidad_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prioridad_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_pasar_a_te As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
End Class
