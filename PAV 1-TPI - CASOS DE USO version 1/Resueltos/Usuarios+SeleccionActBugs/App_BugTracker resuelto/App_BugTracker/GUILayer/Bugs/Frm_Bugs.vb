Public Class Frm_Bugs
    Friend row_selected As DataGridViewRow
    Private oBugService As New BugService

    Private Sub Frm_Bugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar componentes:
        clear_components()
        'Deshabilitar botones
        btn_editar.Enabled = False
        btn_asignar.Enabled = False
        btn_detalle_bug.Enabled = False

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
        btn_asignar.Enabled = True
        btn_editar.Enabled = True
        btn_detalle_bug.Enabled = True
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

    Private Sub llenarGrid(ByRef source As List(Of Bug))
        dgv_bugs.Rows.Clear()
        For Each oBug As Bug In source
            dgv_bugs.Rows.Add(New String() {oBug.id_bug.ToString, oBug.titulo, oBug.n_producto, oBug.fecha_alta.ToString("dd/MM/yyyy"), oBug.estado, oBug.asignado_a, oBug.n_criticidad, oBug.n_prioridad})
        Next
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)

        If IsDate(txt_fec_desde.Text) And IsDate(txt_fec_hasta.Text) Then
            filters.Add(txt_fec_desde.Text)
            filters.Add(txt_fec_hasta.Text)
        Else
            filters.Add(Nothing)
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Prioridad' esta seleccionado.
        If cbo_prioridades.Text <> String.Empty Then
            filters.Add(cbo_prioridades.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Criticidad' a esta seleccionado.
        If cbo_criticidades.Text <> String.Empty Then
            filters.Add(cbo_criticidades.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Producto' a esta seleccionado.
        If cbo_productos.Text <> String.Empty Then
            filters.Add(cbo_productos.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Estado' esta seleccionado.
        If cbo_estados.Text <> String.Empty Then
            'Si el cbo tiene un texto no vacìo entonces enviamos como filtro el nombre del estado a consultar
            filters.Add(cbo_estados.Text)
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Asignado a' esta seleccionado.
        If cbo_asignadoA.Text <> String.Empty Then
            filters.Add(cbo_asignadoA.Text)
        Else
            filters.Add(Nothing)
        End If

        'Solicitar al BDHelper que ejecuta una consulta con los filtros seleccionados
        llenarGrid(oBugService.consultarBugsConFiltros(filters.ToArray))
        If dgv_bugs.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", _
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            clear_components()
        End If
    End Sub

    Private Sub btn_detalle_bug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_detalle_bug.Click
        Dim id As Integer
        If row_selected.Index <> -1 Then
            id = Convert.ToInt32(row_selected.Cells("id_bug_col").Value)
            Frm_detalle_bug.mostrar_bug(oBugService.consultarBugsPorId(id))
            Frm_detalle_bug.ShowDialog()
        End If
    End Sub

    Private Sub dgv_bugs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_bugs.CellContentClick
        row_selected = dgv_bugs.CurrentRow
        btn_detalle_bug.Enabled = True
        btn_pasar_a_te.Enabled = True
        btn_cerrar.Enabled = True
    End Sub

    Private Sub btn_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click
        Frm_actualizar_bug.ShowDialog()
    End Sub

    Private Sub btn_asignar_Click(sender As System.Object, e As System.EventArgs) Handles btn_asignar.Click
        Dim oBug As Bug
        If row_selected.Index <> -1 Then
            oBug = oBugService.consultarBugsPorId(row_selected.Cells("id_bug_col").Value)
            Frm_asignar_bug.asignar_bug(oBug)
            Frm_asignar_bug.ShowDialog()
        End If
    End Sub

    Private Sub btn_pasar_a_te_Click(sender As System.Object, e As System.EventArgs) Handles btn_pasar_a_te.Click
        Dim oHistorialBug As HistorialBug
        Dim oListBug As New List(Of Bug)
        Dim oBugSelected As Bug

        'Directamente corroboramos que si hay uno o más bug seleccionados
        'Podemos actualizar SIEMPRE un conjunto de bug, si solo uno es el seleccionado, pues bien
        'pasaremos una lista de un solo objeto.
        If dgv_bugs.SelectedRows.Count > 0 Then
            If validar_estado("Asignado") Then
                If MsgBox("Seguro que desea actualizar el estado de el/los bug seleccionados a: 'En testing'?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
                    oBugSelected = oBugService.consultarBugsPorId(Convert.ToInt32(row_selected.Cells("id_bug_col").Value))
                    oHistorialBug = New HistorialBug
                    oHistorialBug.id_detalle = oBugSelected.historial.Count + 1
                    oHistorialBug.responsable = Frm_Principal.obtenerUsuarioLogin.id_usuario
                    oHistorialBug.estado = 4
                    oBugSelected.addHistorial(oHistorialBug)
                    oListBug.Add(oBugSelected)

                    'Modificamos la implementaciónd de 'actualizarBugConHistorial' para reciba una lista de bugs
                    If oBugService.actualizarBugConHistorial(oListBug) Then
                        MessageBox.Show("Bugs actualizados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Ha ocurrido un error al actualizar bugs. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Uno o más bug no se encuentran en el estado: Asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cerrar.Click
        Dim oHistorialBug As HistorialBug
        Dim oListBug As New List(Of Bug)
        Dim oBugSelected As Bug

        If dgv_bugs.SelectedRows.Count > 0 Then
            If validar_estado("En testing") Then
                If MsgBox("Seguro que desea actualizar el estado del/los bugs seleccionados a: 'Cerrado'?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
                    oBugSelected = oBugService.consultarBugsPorId(Convert.ToInt32(row_selected.Cells("id_bug_col").Value))
                    oHistorialBug = New HistorialBug
                    oHistorialBug.id_detalle = oBugSelected.historial.Count + 1
                    oHistorialBug.responsable = Frm_Principal.obtenerUsuarioLogin.id_usuario
                    oHistorialBug.estado = 3
                    oBugSelected.addHistorial(oHistorialBug)
                    oListBug.Add(oBugSelected)

                    If oBugService.actualizarBugConHistorial(oListBug) Then
                        MessageBox.Show("Bugs actualizados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Ha ocurrido un error al actualizar bugs. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Una o más filas no se encuentran en el estado: En Testing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_editar_Click(sender As System.Object, e As System.EventArgs) Handles btn_editar.Click
        'Completar código para editar un bug según lo indicado en CU05_Actualizar_bug_reportado.docx
    End Sub

    Private Function validar_estado(estado As String) As Boolean
        Dim aviso = True
        For Each row As DataGridViewRow In dgv_bugs.SelectedRows
            If row.Cells("estado_col").Value <> estado Then
                aviso = False
                Exit For
            End If
        Next
        Return aviso
    End Function
End Class


