
namespace VISTA
{
    partial class FrmPRESTAMO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPRESTAMO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFECHA_COMPARTIDO = new System.Windows.Forms.TextBox();
            this.txtNOMBRE_COMPARTIDO = new System.Windows.Forms.TextBox();
            this.cbMATERIAL_PRESTAMO = new System.Windows.Forms.ComboBox();
            this.btnGUARDAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCANCELAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MATERIAL:";
            // 
            // txtFECHA_COMPARTIDO
            // 
            this.txtFECHA_COMPARTIDO.Location = new System.Drawing.Point(156, 60);
            this.txtFECHA_COMPARTIDO.Name = "txtFECHA_COMPARTIDO";
            this.txtFECHA_COMPARTIDO.Size = new System.Drawing.Size(100, 20);
            this.txtFECHA_COMPARTIDO.TabIndex = 3;
            // 
            // txtNOMBRE_COMPARTIDO
            // 
            this.txtNOMBRE_COMPARTIDO.Location = new System.Drawing.Point(156, 125);
            this.txtNOMBRE_COMPARTIDO.Name = "txtNOMBRE_COMPARTIDO";
            this.txtNOMBRE_COMPARTIDO.Size = new System.Drawing.Size(100, 20);
            this.txtNOMBRE_COMPARTIDO.TabIndex = 4;
            // 
            // cbMATERIAL_PRESTAMO
            // 
            this.cbMATERIAL_PRESTAMO.FormattingEnabled = true;
            this.cbMATERIAL_PRESTAMO.Location = new System.Drawing.Point(156, 192);
            this.cbMATERIAL_PRESTAMO.Name = "cbMATERIAL_PRESTAMO";
            this.cbMATERIAL_PRESTAMO.Size = new System.Drawing.Size(121, 21);
            this.cbMATERIAL_PRESTAMO.TabIndex = 5;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGUARDAR.BorderRadius = 0;
            this.btnGUARDAR.ButtonText = "GUARDAR";
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.DisabledColor = System.Drawing.Color.Gray;
            this.btnGUARDAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGUARDAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Iconimage")));
            this.btnGUARDAR.Iconimage_right = null;
            this.btnGUARDAR.Iconimage_right_Selected = null;
            this.btnGUARDAR.Iconimage_Selected = null;
            this.btnGUARDAR.IconMarginLeft = 0;
            this.btnGUARDAR.IconMarginRight = 0;
            this.btnGUARDAR.IconRightVisible = true;
            this.btnGUARDAR.IconRightZoom = 0D;
            this.btnGUARDAR.IconVisible = true;
            this.btnGUARDAR.IconZoom = 90D;
            this.btnGUARDAR.IsTab = false;
            this.btnGUARDAR.Location = new System.Drawing.Point(12, 351);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGUARDAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGUARDAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGUARDAR.selected = false;
            this.btnGUARDAR.Size = new System.Drawing.Size(158, 48);
            this.btnGUARDAR.TabIndex = 6;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGUARDAR.Textcolor = System.Drawing.Color.White;
            this.btnGUARDAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.BorderRadius = 0;
            this.btnCANCELAR.ButtonText = "CANCELAR";
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.DisabledColor = System.Drawing.Color.Gray;
            this.btnCANCELAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCANCELAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Iconimage")));
            this.btnCANCELAR.Iconimage_right = null;
            this.btnCANCELAR.Iconimage_right_Selected = null;
            this.btnCANCELAR.Iconimage_Selected = null;
            this.btnCANCELAR.IconMarginLeft = 0;
            this.btnCANCELAR.IconMarginRight = 0;
            this.btnCANCELAR.IconRightVisible = true;
            this.btnCANCELAR.IconRightZoom = 0D;
            this.btnCANCELAR.IconVisible = true;
            this.btnCANCELAR.IconZoom = 90D;
            this.btnCANCELAR.IsTab = false;
            this.btnCANCELAR.Location = new System.Drawing.Point(222, 351);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCANCELAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCANCELAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCANCELAR.selected = false;
            this.btnCANCELAR.Size = new System.Drawing.Size(157, 48);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Textcolor = System.Drawing.Color.White;
            this.btnCANCELAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // FrmPRESTAMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.cbMATERIAL_PRESTAMO);
            this.Controls.Add(this.txtNOMBRE_COMPARTIDO);
            this.Controls.Add(this.txtFECHA_COMPARTIDO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPRESTAMO";
            this.Text = "FrmPRESTAMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFECHA_COMPARTIDO;
        private System.Windows.Forms.TextBox txtNOMBRE_COMPARTIDO;
        private System.Windows.Forms.ComboBox cbMATERIAL_PRESTAMO;
        private Bunifu.Framework.UI.BunifuFlatButton btnGUARDAR;
        private Bunifu.Framework.UI.BunifuFlatButton btnCANCELAR;
    }
}