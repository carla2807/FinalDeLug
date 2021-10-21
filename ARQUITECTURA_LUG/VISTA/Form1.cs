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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Declaro variables
        int posY = 0;
        int posX = 0;
        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnTEMA_Click(object sender, EventArgs e)
        {
            Frm_ListaTemas frm_ListaTemas = new Frm_ListaTemas();
            frm_ListaTemas.Show();
        }

        private void btnLIBRO_Click(object sender, EventArgs e)
        {

            Frm_ListaLibros frm_ListaLibros = new Frm_ListaLibros();
            frm_ListaLibros.Show();
        }

        private void btnPRESTAMO_Click(object sender, EventArgs e)
        {
            FrmLista_Prestamos frmLista_Prestamos = new FrmLista_Prestamos();
            frmLista_Prestamos.Show();
        }
    }
}
