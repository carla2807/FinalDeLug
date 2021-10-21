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
    public partial class FrmPRESTAMO : Form
    {
        CONTROLADORA.compartidos cOMPARTIDOS;
        MODELO.COMPARTIR oCOMPARTIDOS;
        CONTROLADORA.materiales cMateriales;
        MODELO.MATERIAL oMaterial;

        MODELO.ACCION ACCION;


        public FrmPRESTAMO(MODELO.COMPARTIR miCompartido,MODELO.ACCION miACCION)
        {
            InitializeComponent();
            cOMPARTIDOS = CONTROLADORA.compartidos.obtener_instancia();
            cMateriales = CONTROLADORA.materiales.obtener_instancia();
            oCOMPARTIDOS = miCompartido;
            MODO_PRESTAMO();
            ACCION = miACCION;


            if (ACCION != MODELO.ACCION.AGREGAR)
            {
                txtFECHA_COMPARTIDO.Text = oCOMPARTIDOS.FECHA.ToString();
                txtNOMBRE_COMPARTIDO.Text = oCOMPARTIDOS.NOMBRE;
                cbMATERIAL_PRESTAMO.SelectedItem = oCOMPARTIDOS.MATERIAL;

                if (ACCION !=MODELO.ACCION.CONSULTAR)
                {
                    btnGUARDAR.Enabled = false;
                    btnGUARDAR.Visible = false;
                }
            }


           
        }

       public void MODO_PRESTAMO()
        {
            cbMATERIAL_PRESTAMO.DataSource = null;
            cbMATERIAL_PRESTAMO.DataSource = cMateriales.OBTENER_MATERIAL();
            cbMATERIAL_PRESTAMO.DisplayMember = "MATERIAL";
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            DateTime FECHA;
            if (!DateTime.TryParse(txtFECHA_COMPARTIDO.Text, out FECHA)) 
            {
                MessageBox.Show("Ingrese correctamente la fecha");
                return;

            }


            if (string.IsNullOrWhiteSpace(txtNOMBRE_COMPARTIDO.Text))
            {
                MessageBox.Show("Ingrese correctamente el nombre de la persona");
                return;
            }

            if (cbMATERIAL_PRESTAMO.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el material a compartir");
                return;
            }


            oCOMPARTIDOS.FECHA = FECHA;
            oCOMPARTIDOS.NOMBRE = txtNOMBRE_COMPARTIDO.Text;
            oCOMPARTIDOS.MATERIAL = (MODELO.MATERIAL)cbMATERIAL_PRESTAMO.SelectedItem;

            if (ACCION == MODELO.ACCION.AGREGAR)
                cOMPARTIDOS.AGREGAR_COMPARTIR(oCOMPARTIDOS);
            else
                cOMPARTIDOS.MODIFICAR_COMPARTIR(oCOMPARTIDOS);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
