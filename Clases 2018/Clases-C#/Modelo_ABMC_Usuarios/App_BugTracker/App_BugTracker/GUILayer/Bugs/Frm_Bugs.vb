Public Class Frm_Bugs
    Friend row_selected As DataGridViewRow

    Private Sub Frm_Bugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar componentes:
        clear_components()
        'Deshabilitar botones
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        btn_comentar.Enabled = False

        'LLenar combos y limpiar grid
        llenarCombo(cbo_estados, BDHelper.getDBHelper.ConsultaSQL("Select * from Estados"), "n_estado", "id_estado")
        llenarCombo(cbo_prioridades, BDHelper.getDBHelper.ConsultaSQL("Select * from Prioridades"), "n_prioridad", "id_prioridad")
        llenarCombo(cbo_criticidades, BDHelper.getDBHelper.ConsultaSQL("Select * from Criticidades"), "n_criticidad", "id_criticidad")
        llenarCombo(cbo_asignadoA, BDHelper.getDBHelper.ConsultaSQL("Select * from users"), "n_usuario", "id_usuario")
        llenarCombo(cbo_productos, BDHelper.getDBHelper.ConsultaSQL("Select * from Productos"), "nombre", "id_producto")
        dgv_bugs.Rows.Clear()
    End Sub

    Private Sub clear_components()
        txt_fec_desde.Text = Date.Now.ToString("dd/MM/yyyy")
        txt_fec_hasta.Text = Date.Now.AddDays(1).ToString("dd/MM/yyyy")
        cbo_asignadoA.Text = ""
        cbo_estados.Text = ""
        cbo_prioridades.Text = ""
        cbo_criticidades.Text = ""
        cbo_productos.Text = ""
    End Sub


    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_bugs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_bugs.CellClick
        btn_borrar.Enabled = True
        btn_editar.Enabled = True
        row_selected = dgv_bugs.CurrentRow
    End Sub

    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario, que permita cargar un combo a partir de:
    'Componente combo
    'Source, una lista de objetos
    'Nombre de la property a mostrar en el displayMember del componente
    'Nombre de la property a almacenar en el valueMember del componente
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    'Procedimiento Friend (Amigo) que nos permite llenar la grilla de bugs desde otro formulario.
    'Recibe OPCIONALMENTE una lista de bugs. Si no se recibe nada, se recuperan todos los bug mediante el servicio listarBugs()
    Friend Sub llenarGrid()
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT TOP 20 * FROM bugs WHERE "

        'Validar campos de fechas. Si son fechas válidas las agregamos. Caso contrario Nothing
        If IsDate(txt_fec_desde.Text) And IsDate(txt_fec_hasta.Text) Then
            filters.Add(txt_fec_desde.Text)
            filters.Add(txt_fec_hasta.Text)
            str += "(fecha>=@param1 AND fecha<=@param2) "
        Else
            filters.Add(Nothing)
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Estado' esta seleccionado.
        If cbo_estados.Text <> String.Empty Then
            'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
            filters.Add(cbo_estados.SelectedValue)
            str += "AND id_estado=@param3 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Asignado a' esta seleccionado.
        If cbo_asignadoA.Text <> String.Empty Then
            filters.Add(cbo_asignadoA.SelectedValue)
            str += "AND asignado_a=@param4 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Prioridad' esta seleccionado.
        If cbo_prioridades.Text <> String.Empty Then
            filters.Add(cbo_prioridades.SelectedValue)
            str += "AND id_prioridad=@param5 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Criticidad' a esta seleccionado.
        If cbo_criticidades.Text <> String.Empty Then
            filters.Add(cbo_criticidades.SelectedValue)
            str += "AND id_criticidad=@param6 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Producto' a esta seleccionado.
        If cbo_productos.Text <> String.Empty Then
            filters.Add(cbo_productos.SelectedValue)
            str += "AND id_producto=@param7"
        Else
            filters.Add(Nothing)
        End If
        str += " ORDER BY fecha DESC"

        'Solicitar al BDHelper que ejecuta una consulta con los filtros seleccionados
        dgv_bugs.DataSource = BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray())

        If dgv_bugs.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", _
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
           
            clear_components()
        End If
    End Sub
End Class