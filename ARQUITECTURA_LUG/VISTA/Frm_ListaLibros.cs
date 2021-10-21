using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Frm_ListaLibros : Form
    {
        public static Frm_ListaLibros instancia;

        public static Frm_ListaLibros obtener_instancia()
        {
            if (instancia == null)
                instancia = new Frm_ListaLibros();
            if (instancia.IsDisposed)
                instancia = new Frm_ListaLibros();
            return instancia;
        }

        private CONTROLADORA.materiales cMateriales;
        private MODELO.MATERIAL oMaterial;


        public Frm_ListaLibros()
        {
            InitializeComponent();
            cMateriales = CONTROLADORA.materiales.obtener_instancia();
            ACTUALIZAR_MATERIALES();
        }

        private void ACTUALIZAR_MATERIALES()
        {
            DGVLIBROS.DataSource = null;
            DGVLIBROS.DataSource = cMateriales.OBTENER_MATERIAL();


        }

        //BOTONES

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmLIBRO frmLIBRO = new FrmLIBRO(new MODELO.MATERIAL(), MODELO.ACCION.AGREGAR);
            DialogResult respuesta= frmLIBRO.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_MATERIALES();
            }

        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGVLIBROS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }


            oMaterial = (MODELO.MATERIAL)DGVLIBROS.CurrentRow.DataBoundItem;
            FrmLIBRO frmLIBRO = new FrmLIBRO(oMaterial, MODELO.ACCION.MODIFICAR);

            DialogResult respuesta = frmLIBRO.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_MATERIALES();
            }


        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVLIBROS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }

            oMaterial = (MODELO.MATERIAL)DGVLIBROS.CurrentRow.DataBoundItem;
            FrmLIBRO frmLIBRO = new FrmLIBRO(oMaterial, MODELO.ACCION.CONSULTAR);
            frmLIBRO.ShowDialog();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVLIBROS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }

            oMaterial = (MODELO.MATERIAL)DGVLIBROS.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el material '" + oMaterial.TEMA + "' de la lista?",
             "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {
                cMateriales.ELIMINAR_MATERIAL(oMaterial);
                ACTUALIZAR_MATERIALES();
            }

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnCOMPARTIR_Click(object sender, EventArgs e)
        {

            if (DGVLIBROS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }

            oMaterial = (MODELO.MATERIAL)DGVLIBROS.CurrentRow.DataBoundItem;

            FrmPRESTAMO frmPRESTAMO = new FrmPRESTAMO(new MODELO.COMPARTIR(), MODELO.ACCION.AGREGAR);
            DialogResult respuesta = frmPRESTAMO.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_MATERIALES();
            }
        }
    }
}