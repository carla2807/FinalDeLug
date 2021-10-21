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
    public partial class FrmLIBRO : Form
    {
        CONTROLADORA.materiales cMateriales;
        MODELO.MATERIAL oMaterial;
        MODELO.ACCION ACCION;
        

        CONTROLADORA.temas cTemas;
        MODELO.TEMA oTema;


        //Constructores
        public FrmLIBRO(MODELO.ACCION miACCION)
        {
            cMateriales = CONTROLADORA.materiales.obtener_instancia();
            cTemas = CONTROLADORA.temas.obtener_instancia();
            ACCION = miACCION;
            MODO_ACTUALIZAR();

        }
        public FrmLIBRO(MODELO.MATERIAL miMATERIAL, MODELO.ACCION miACCION)
        {
            InitializeComponent();
            cMateriales = CONTROLADORA.materiales.obtener_instancia();
            cTemas = CONTROLADORA.temas.obtener_instancia();

            MODO_ACTUALIZAR();
            oMaterial = miMATERIAL;
            ACCION = miACCION;

            if(ACCION != MODELO.ACCION.AGREGAR)
            {
                cbTEMA.SelectedItem = oMaterial.TEMA;
                txtTITULO.Text = oMaterial.TITULO;
                txtAUTOR.Text = oMaterial.NOMBRE_AUTOR;
                txtAÑOEDICION.Text = oMaterial.AÑO_EDICION.ToString();


                if (oMaterial.GetType().Name == "DIGITAL")
                {
                    lblArchivo.Visible = true;
                    txtARCHIVO.Enabled = true;

                    lblTamaño.Visible = true;
                    txtTAMAÑO.Enabled = true;

                    txtARCHIVO.Text = ((MODELO.DIGITAL)oMaterial).NOMBRE_ARCHIVO.ToString();
                    txtTAMAÑO.Text = ((MODELO.DIGITAL)oMaterial).TAMAÑO_MEGABYTE.ToString();

                    rbDIGITAL.Checked = true;
                    rbIMPRESO.Visible = false;

                    lblencuadernando.Visible = false;
                    txtCANTIDAD.Enabled = false;
                    txtENCUADERNADO.Enabled = false;

                }

                else if (oMaterial.GetType().Name =="IMPRESO")
                {
                    lblcantidad.Visible = true;
                    lblencuadernando.Visible = true;

                    txtCANTIDAD.Enabled = true;
                    txtENCUADERNADO.Enabled = true;


                    lblArchivo.Visible = false;
                    txtARCHIVO.Enabled = false;

                    lblTamaño.Visible = false;
                    txtTAMAÑO.Enabled = false;

                    txtCANTIDAD.Text = ((MODELO.IMPRESO)oMaterial).CANTIDAD_HOJAS.ToString();
                    txtENCUADERNADO.Text = ((MODELO.IMPRESO)oMaterial).ENCUADERNADO.ToString();


                    rbIMPRESO.Checked = true;
                    rbDIGITAL.Visible = false;
  
                }

                gbTIPO.Enabled = false;


                if (ACCION == MODELO.ACCION.CONSULTAR)
                {
                    btnGUARDAR.Enabled = false;
                    btnGUARDAR.Visible = false;
                }

            }

        }





        public void MODO_ACTUALIZAR()
        {
            cbTEMA.DataSource = null;
            cbTEMA.DataSource = cTemas.OBTENER_TEMAS();
            cbTEMA.DisplayMember = "TEMA";
        }

        private void FrmLIBRO_Load(object sender, EventArgs e)
        {
            if (ACCION == MODELO.ACCION.AGREGAR)
            {
                lblcantidad.Visible = true;
                lblencuadernando.Visible = true;

                txtCANTIDAD.Enabled = true;
                txtENCUADERNADO.Enabled = true;


                lblArchivo.Visible = false;
                txtARCHIVO.Enabled = false;

                lblTamaño.Visible = false;
                txtTAMAÑO.Enabled = false;

            }
        }

        private void rbIMPRESO_CheckedChanged(object sender, EventArgs e)
        {
            lblArchivo.Visible = false;
            txtARCHIVO.Enabled = false;

            txtARCHIVO.Text = "";


            lblTamaño.Visible = false;
            txtTAMAÑO.Enabled = false;
            txtTAMAÑO.Text = "";


            lblcantidad.Visible = true;
            txtCANTIDAD.Enabled = true;

            lblencuadernando.Visible = true;
            txtENCUADERNADO.Enabled = true;


        }

        private void rbDIGITAL_CheckedChanged(object sender, EventArgs e)
        {
            lblArchivo.Visible = true;
            lblTamaño.Visible = true;
            txtARCHIVO.Enabled = true;
            txtTAMAÑO.Enabled = true;

            lblcantidad.Visible = false;
            lblencuadernando.Visible = false;
            txtENCUADERNADO.Enabled = false;
            txtCANTIDAD.Enabled = false;

        }

        //Botones
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTITULO.Text))
            {
                MessageBox.Show("Debe ingresar el titulo");
                return;
            }

            if (cbTEMA.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el tema");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAUTOR.Text))
            {
                MessageBox.Show("Debe ingresar el autor");
                return;
            }


            int AÑOEDICION;
            if (!int.TryParse(txtAÑOEDICION.Text, out AÑOEDICION))
            {
                MessageBox.Show("Debe ingresar el año");
                return;
            }

            if (ACCION == MODELO.ACCION.AGREGAR)
            {
                if (rbIMPRESO.Checked)
                {
                    oMaterial = new MODELO.IMPRESO();
                }

                try
                {
                    txtCANTIDAD.Visible = true;
                    txtTAMAÑO.Visible = false;
                    txtARCHIVO.Visible = false;
                    ((MODELO.IMPRESO)oMaterial).CANTIDAD_HOJAS = int.Parse(txtCANTIDAD.Text);
                    ((MODELO.IMPRESO)oMaterial).ENCUADERNADO = txtENCUADERNADO.Text;
                    oMaterial.TIPO_MATERIAL = "IMPRESO";
                }
                catch (Exception)
                {
                    MessageBox.Show("Agregado");

                }
            }


             if(ACCION == MODELO.ACCION.AGREGAR)
            {
               
                if (rbDIGITAL.Checked)
                {
                    oMaterial = new MODELO.DIGITAL();
                }


                try
                {
                    txtCANTIDAD.Visible = false;
                    txtTAMAÑO.Visible = true;
                    txtARCHIVO.Visible = true;
                    ((MODELO.DIGITAL)oMaterial).TAMAÑO_MEGABYTE = int.Parse(txtTAMAÑO.Text);
                    ((MODELO.DIGITAL)oMaterial).NOMBRE_ARCHIVO = txtARCHIVO.Text;
                    oMaterial.TIPO_MATERIAL = "DIGITAL";


                }
                catch (Exception)
                {

                    MessageBox.Show("Agregado");
                }

            }


            oMaterial.TITULO = txtTITULO.Text;
            oMaterial.NOMBRE_AUTOR = txtAUTOR.Text;
            oMaterial.TEMA = (MODELO.TEMA)cbTEMA.SelectedItem;
            oMaterial.AÑO_EDICION = AÑOEDICION;

            if (ACCION == MODELO.ACCION.AGREGAR)
                cMateriales.AGREGAR_MATERIAL(oMaterial);
            else

                cMateriales.MODIFICAR_MATERIAL(oMaterial);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

