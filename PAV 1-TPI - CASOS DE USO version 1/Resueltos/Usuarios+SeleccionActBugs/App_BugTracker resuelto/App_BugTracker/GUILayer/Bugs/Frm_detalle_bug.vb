Public Class Frm_detalle_bug
    Public Sub mostrar_bug(ByVal oBugSelected As Bug)
        txt_nro_bug.Text = oBugSelected.id_bug.ToString
        txt_titulo.Text = oBugSelected.titulo
        txt_producto.Text = oBugSelected.n_producto
        txt_fec_alta.Text = oBugSelected.fecha_alta
        txt_descri.Text = oBugSelected.descripcion
        txt_estado.Text = oBugSelected.estado
        txt_prioridad.Text = oBugSelected.n_prioridad
        txt_criticidad.Text = oBugSelected.n_criticidad

        dgv_historiales.Rows.Clear()
        For Each oHistorialBug As HistorialBug In oBugSelected.historial
            dgv_historiales.Rows.Add(New String() {oHistorialBug.fecha.ToString("dd/MM/yyyy"), oHistorialBug.n_responsable, oHistorialBug.n_estado, oHistorialBug.n_asignado_a})
        Next
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Me.Close()
    End Sub

    Private Sub Frm_detalle_bug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class