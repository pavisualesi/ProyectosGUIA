<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_detalle_bug
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nro_bug = New System.Windows.Forms.TextBox()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descri = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_prioridad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_fec_alta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_criticidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_historiales = New System.Windows.Forms.DataGridView()
        Me.fec_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.responsable_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignado_a_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_historiales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# Bug:"
        '
        'txt_nro_bug
        '
        Me.txt_nro_bug.Enabled = False
        Me.txt_nro_bug.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nro_bug.Location = New System.Drawing.Point(99, 11)
        Me.txt_nro_bug.Name = "txt_nro_bug"
        Me.txt_nro_bug.Size = New System.Drawing.Size(68, 22)
        Me.txt_nro_bug.TabIndex = 1
        '
        'txt_titulo
        '
        Me.txt_titulo.Enabled = False
        Me.txt_titulo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo.Location = New System.Drawing.Point(100, 34)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(260, 22)
        Me.txt_titulo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Título:"
        '
        'txt_descri
        '
        Me.txt_descri.Enabled = False
        Me.txt_descri.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descri.Location = New System.Drawing.Point(98, 113)
        Me.txt_descri.Multiline = True
        Me.txt_descri.Name = "txt_descri"
        Me.txt_descri.Size = New System.Drawing.Size(262, 101)
        Me.txt_descri.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'txt_producto
        '
        Me.txt_producto.Enabled = False
        Me.txt_producto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_producto.Location = New System.Drawing.Point(99, 60)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(261, 22)
        Me.txt_producto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto:"
        '
        'txt_estado
        '
        Me.txt_estado.Enabled = False
        Me.txt_estado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.Location = New System.Drawing.Point(98, 216)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(262, 22)
        Me.txt_estado.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado:"
        '
        'txt_prioridad
        '
        Me.txt_prioridad.Enabled = False
        Me.txt_prioridad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prioridad.Location = New System.Drawing.Point(100, 241)
        Me.txt_prioridad.Name = "txt_prioridad"
        Me.txt_prioridad.Size = New System.Drawing.Size(260, 22)
        Me.txt_prioridad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Prioridad:"
        '
        'txt_fec_alta
        '
        Me.txt_fec_alta.Enabled = False
        Me.txt_fec_alta.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fec_alta.Location = New System.Drawing.Point(100, 87)
        Me.txt_fec_alta.Name = "txt_fec_alta"
        Me.txt_fec_alta.Size = New System.Drawing.Size(123, 22)
        Me.txt_fec_alta.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha creación:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(192, 519)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 18
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_criticidad
        '
        Me.txt_criticidad.Enabled = False
        Me.txt_criticidad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_criticidad.Location = New System.Drawing.Point(99, 267)
        Me.txt_criticidad.Name = "txt_criticidad"
        Me.txt_criticidad.Size = New System.Drawing.Size(261, 22)
        Me.txt_criticidad.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Criticidad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_historiales)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 215)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial Bug"
        '
        'dgv_historiales
        '
        Me.dgv_historiales.AllowUserToAddRows = False
        Me.dgv_historiales.AllowUserToDeleteRows = False
        Me.dgv_historiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historiales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fec_col, Me.responsable_col, Me.estado_col, Me.asignado_a_col})
        Me.dgv_historiales.Location = New System.Drawing.Point(6, 18)
        Me.dgv_historiales.Name = "dgv_historiales"
        Me.dgv_historiales.ReadOnly = True
        Me.dgv_historiales.Size = New System.Drawing.Size(420, 185)
        Me.dgv_historiales.TabIndex = 22
        '
        'fec_col
        '
        Me.fec_col.HeaderText = "Fecha"
        Me.fec_col.Name = "fec_col"
        Me.fec_col.ReadOnly = True
        '
        'responsable_col
        '
        Me.responsable_col.HeaderText = "Responsable"
        Me.responsable_col.Name = "responsable_col"
        Me.responsable_col.ReadOnly = True
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
        'Frm_detalle_bug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 547)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_criticidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_fec_alta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_prioridad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_descri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nro_bug)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_detalle_bug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de bug"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_historiales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nro_bug As System.Windows.Forms.TextBox
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descri As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_prioridad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_fec_alta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_criticidad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_historiales As System.Windows.Forms.DataGridView
    Friend WithEvents fec_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents responsable_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asignado_a_col As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
