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
    public partial class FrmTEMA : Form
    {

        CONTROLADORA.temas cTemas;
        MODELO.TEMA oTema;
        MODELO.ACCION ACCION;

        public FrmTEMA(MODELO.TEMA miTEMA, MODELO.ACCION miACCION)
        {
            InitializeComponent();
            cTemas = CONTROLADORA.temas.obtener_instancia();
            ACCION = miACCION;
            oTema = miTEMA;

            if (ACCION != MODELO.ACCION.AGREGAR)
            {
                txtTEMA.Text = oTema.TEMA_LIBRO;

            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTEMA.Text))
            {
                MessageBox.Show("Debe ingresar el tema");
                return;
            }


            oTema.TEMA_LIBRO = txtTEMA.Text;
            if (ACCION == MODELO.ACCION.AGREGAR)
                cTemas.AGREGAR_TEMA(oTema);

            else cTemas.MODIFICAR_TEMA(oTema);
            this.DialogResult = DialogResult.OK;

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
