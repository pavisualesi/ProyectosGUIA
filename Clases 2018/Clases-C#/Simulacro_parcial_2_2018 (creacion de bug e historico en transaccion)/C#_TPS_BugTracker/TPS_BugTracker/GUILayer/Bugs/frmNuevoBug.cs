using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.BusinessLayer.Services;
using TPS_BugTracker.DataLayer.DAOs;
using TPS_BugTracker.GUILayer.Helper;

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmNuevoBug : Form
    {

        private PrioridadService prioridadService = new PrioridadService();
        private ProductoService productoService = new ProductoService();
        private CriticidadService criticidadService = new CriticidadService();
        

        private Bug oBug;
        private BugService oBugService = new BugService();
        public frmNuevoBug()
        {
            InitializeComponent();

            oBugService = new BugService();

            GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto");
        }


        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {   
              
                // Con los datos cargados en el form instanciamos un objeto usuario
                oBug = new Bug();
                oBug.titulo = txtTitulo.Text;
                oBug.descripcion = txtDescripcion.Text;

                oBug.id_prioridad = (int)cboPrioridad.SelectedValue;
                oBug.id_criticidad = (int)cboCriticidad.SelectedValue;
                oBug.id_producto = (int)cboProducto.SelectedValue;
                //Estado nuevo
                oBug.id_estado = 1;
                //Aun no se asignó el responsable
                         
               
                if (oBugService.crearBug(oBug))
                {
                    MessageBox.Show("Bug insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
           

            this.Close();
        }

        private void frmNuevoBug_Load(object sender, EventArgs e)
        {

        }

    }
}
