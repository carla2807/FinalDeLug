namespace VISTA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPRESTAMO = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLIBRO = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTEMA = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.Teal;
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(800, 46);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.MintCream;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(696, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(37, 29);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.MintCream;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(748, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(40, 29);
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnPRESTAMO);
            this.panel2.Controls.Add(this.btnLIBRO);
            this.panel2.Controls.Add(this.btnTEMA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 404);
            this.panel2.TabIndex = 1;
            // 
            // btnPRESTAMO
            // 
            this.btnPRESTAMO.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPRESTAMO.color = System.Drawing.Color.SeaGreen;
            this.btnPRESTAMO.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnPRESTAMO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPRESTAMO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRESTAMO.ForeColor = System.Drawing.Color.White;
            this.btnPRESTAMO.Image = ((System.Drawing.Image)(resources.GetObject("btnPRESTAMO.Image")));
            this.btnPRESTAMO.ImagePosition = 17;
            this.btnPRESTAMO.ImageZoom = 50;
            this.btnPRESTAMO.LabelPosition = 34;
            this.btnPRESTAMO.LabelText = "Prestamos";
            this.btnPRESTAMO.Location = new System.Drawing.Point(29, 241);
            this.btnPRESTAMO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPRESTAMO.Name = "btnPRESTAMO";
            this.btnPRESTAMO.Size = new System.Drawing.Size(91, 96);
            this.btnPRESTAMO.TabIndex = 4;
            this.btnPRESTAMO.Click += new System.EventHandler(this.btnPRESTAMO_Click);
            // 
            // btnLIBRO
            // 
            this.btnLIBRO.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLIBRO.color = System.Drawing.Color.SeaGreen;
            this.btnLIBRO.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLIBRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIBRO.ForeColor = System.Drawing.Color.White;
            this.btnLIBRO.Image = ((System.Drawing.Image)(resources.GetObject("btnLIBRO.Image")));
            this.btnLIBRO.ImagePosition = 17;
            this.btnLIBRO.ImageZoom = 50;
            this.btnLIBRO.LabelPosition = 34;
            this.btnLIBRO.LabelText = "Libros";
            this.btnLIBRO.Location = new System.Drawing.Point(29, 134);
            this.btnLIBRO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLIBRO.Name = "btnLIBRO";
            this.btnLIBRO.Size = new System.Drawing.Size(91, 96);
            this.btnLIBRO.TabIndex = 3;
            this.btnLIBRO.Click += new System.EventHandler(this.btnLIBRO_Click);
            // 
            // btnTEMA
            // 
            this.btnTEMA.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTEMA.color = System.Drawing.Color.SeaGreen;
            this.btnTEMA.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTEMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTEMA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTEMA.ForeColor = System.Drawing.Color.White;
            this.btnTEMA.Image = ((System.Drawing.Image)(resources.GetObject("btnTEMA.Image")));
            this.btnTEMA.ImagePosition = 17;
            this.btnTEMA.ImageZoom = 50;
            this.btnTEMA.LabelPosition = 34;
            this.btnTEMA.LabelText = "Temas";
            this.btnTEMA.Location = new System.Drawing.Point(29, 18);
            this.btnTEMA.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTEMA.Name = "btnTEMA";
            this.btnTEMA.Size = new System.Drawing.Size(91, 104);
            this.btnTEMA.TabIndex = 2;
            this.btnTEMA.Click += new System.EventHandler(this.btnTEMA_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(349, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 257);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnTEMA;
        private Bunifu.Framework.UI.BunifuTileButton btnLIBRO;
        private Bunifu.Framework.UI.BunifuTileButton btnPRESTAMO;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel panel1;
    }
}

