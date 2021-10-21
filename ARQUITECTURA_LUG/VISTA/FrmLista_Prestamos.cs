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
    public partial class FrmLista_Prestamos : Form
    {
        public static FrmLista_Prestamos instancia;

        public static FrmLista_Prestamos obtener_instancia()
        {
            if (instancia == null)
                instancia = new FrmLista_Prestamos();
            if (instancia.IsDisposed)
                instancia = new FrmLista_Prestamos();
            return instancia;
        }

        private CONTROLADORA.compartidos cOMPARTIDOS;
        private MODELO.COMPARTIR oCOMPARTIR;


        public FrmLista_Prestamos()
        {
            InitializeComponent();
            cOMPARTIDOS = CONTROLADORA.compartidos.obtener_instancia();
            ACTUALIZAR_PRESTAMOS();
        }

        public void ACTUALIZAR_PRESTAMOS()
        {
            DGVPRESTAMOS.DataSource = null;
            DGVPRESTAMOS.DataSource = cOMPARTIDOS.OBTENER_COMPARTIR();
        }

        //BOTONES
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmPRESTAMO frmPRESTAMO = new FrmPRESTAMO(new MODELO.COMPARTIR(), MODELO.ACCION.AGREGAR);
            DialogResult respuesta = frmPRESTAMO.ShowDialog();


            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_PRESTAMOS();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGVPRESTAMOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un prestamo");
                return;
            }


            oCOMPARTIR = (MODELO.COMPARTIR)DGVPRESTAMOS.CurrentRow.DataBoundItem;
            FrmPRESTAMO frmPRESTAMO = new FrmPRESTAMO(oCOMPARTIR, MODELO.ACCION.MODIFICAR);

            DialogResult respuesta = frmPRESTAMO.ShowDialog();


            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_PRESTAMOS();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVPRESTAMOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un prestamo");
                return;
            }


            oCOMPARTIR = (MODELO.COMPARTIR)DGVPRESTAMOS.CurrentRow.DataBoundItem;
            FrmPRESTAMO frmPRESTAMO = new FrmPRESTAMO(oCOMPARTIR, MODELO.ACCION.CONSULTAR);
            frmPRESTAMO.ShowDialog();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVPRESTAMOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un prestamo");
                return;
            }


            oCOMPARTIR = (MODELO.COMPARTIR)DGVPRESTAMOS.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el prestamo '" + oCOMPARTIR.NOMBRE + "' de la lista?",
            "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {
                cOMPARTIDOS.ELIMINAR_COMPARTIR(oCOMPARTIR);
                ACTUALIZAR_PRESTAMOS();
            }

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}