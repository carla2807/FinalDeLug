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
    public partial class Frm_ListaTemas : Form
    {
        public static Frm_ListaTemas instancia;

        //Singleton
        public static Frm_ListaTemas obtener_instancia()
        {
            if (instancia == null)
                instancia = new Frm_ListaTemas();
            if (instancia.IsDisposed)
                instancia = new Frm_ListaTemas();
            return instancia;
        }

        private CONTROLADORA.temas cTemas;
        private MODELO.TEMA oTema;

        public Frm_ListaTemas()
        {
            InitializeComponent();
            cTemas = CONTROLADORA.temas.obtener_instancia();
            ACTUALIZAR_TEMAS();
        }

        private void ACTUALIZAR_TEMAS()
        {
            DGVLista_Temas.DataSource = null;
            DGVLista_Temas.DataSource = cTemas.OBTENER_TEMAS();
        }

        //BOTONES
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmTEMA frmTEMA = new FrmTEMA(new MODELO.TEMA(), MODELO.ACCION.AGREGAR);
            DialogResult respuesta = frmTEMA.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_TEMAS();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            
                if (DGVLista_Temas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un tema");
                    return;
                }


                oTema = (MODELO.TEMA)DGVLista_Temas.CurrentRow.DataBoundItem;
                FrmTEMA frmTEMA = new FrmTEMA(oTema, MODELO.ACCION.MODIFICAR);

                 DialogResult respuesta = frmTEMA.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ACTUALIZAR_TEMAS();
            }
            
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVLista_Temas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un tema");
                return;
            }

            oTema = (MODELO.TEMA)DGVLista_Temas.CurrentRow.DataBoundItem;
            FrmTEMA frmTEMA = new FrmTEMA(oTema, MODELO.ACCION.CONSULTAR);
            frmTEMA.ShowDialog();



        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVLista_Temas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un tema");
                return;
            }


            oTema = (MODELO.TEMA)DGVLista_Temas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el tema '" + oTema.TEMA_LIBRO + "' de la lista?",
              "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {
                cTemas.ELIMINAR_TEMA(oTema);
                ACTUALIZAR_TEMAS();
            }

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
