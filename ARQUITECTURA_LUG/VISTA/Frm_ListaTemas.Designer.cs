
namespace VISTA
{
    partial class Frm_ListaTemas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaTemas));
            this.DGVLista_Temas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAGREGAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMODIFICAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCONSULTAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnELIMINAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSALIR = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLista_Temas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLista_Temas
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVLista_Temas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVLista_Temas.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGVLista_Temas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLista_Temas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLista_Temas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLista_Temas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLista_Temas.DoubleBuffered = true;
            this.DGVLista_Temas.EnableHeadersVisualStyles = false;
            this.DGVLista_Temas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DGVLista_Temas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DGVLista_Temas.Location = new System.Drawing.Point(12, 68);
            this.DGVLista_Temas.Name = "DGVLista_Temas";
            this.DGVLista_Temas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVLista_Temas.Size = new System.Drawing.Size(290, 230);
            this.DGVLista_Temas.TabIndex = 0;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAGREGAR.BorderRadius = 0;
            this.btnAGREGAR.ButtonText = "AGREGAR";
            this.btnAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAGREGAR.DisabledColor = System.Drawing.Color.Gray;
            this.btnAGREGAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAGREGAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Iconimage")));
            this.btnAGREGAR.Iconimage_right = null;
            this.btnAGREGAR.Iconimage_right_Selected = null;
            this.btnAGREGAR.Iconimage_Selected = null;
            this.btnAGREGAR.IconMarginLeft = 0;
            this.btnAGREGAR.IconMarginRight = 0;
            this.btnAGREGAR.IconRightVisible = true;
            this.btnAGREGAR.IconRightZoom = 0D;
            this.btnAGREGAR.IconVisible = true;
            this.btnAGREGAR.IconZoom = 90D;
            this.btnAGREGAR.IsTab = false;
            this.btnAGREGAR.Location = new System.Drawing.Point(315, 48);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAGREGAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAGREGAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAGREGAR.selected = false;
            this.btnAGREGAR.Size = new System.Drawing.Size(241, 48);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAGREGAR.Textcolor = System.Drawing.Color.White;
            this.btnAGREGAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMODIFICAR.BorderRadius = 0;
            this.btnMODIFICAR.ButtonText = "MODIFICAR";
            this.btnMODIFICAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMODIFICAR.DisabledColor = System.Drawing.Color.Transparent;
            this.btnMODIFICAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMODIFICAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMODIFICAR.Iconimage")));
            this.btnMODIFICAR.Iconimage_right = null;
            this.btnMODIFICAR.Iconimage_right_Selected = null;
            this.btnMODIFICAR.Iconimage_Selected = null;
            this.btnMODIFICAR.IconMarginLeft = 0;
            this.btnMODIFICAR.IconMarginRight = 0;
            this.btnMODIFICAR.IconRightVisible = true;
            this.btnMODIFICAR.IconRightZoom = 0D;
            this.btnMODIFICAR.IconVisible = true;
            this.btnMODIFICAR.IconZoom = 90D;
            this.btnMODIFICAR.IsTab = false;
            this.btnMODIFICAR.Location = new System.Drawing.Point(315, 141);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMODIFICAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMODIFICAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMODIFICAR.selected = false;
            this.btnMODIFICAR.Size = new System.Drawing.Size(241, 56);
            this.btnMODIFICAR.TabIndex = 2;
            this.btnMODIFICAR.Text = "MODIFICAR";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMODIFICAR.Textcolor = System.Drawing.Color.White;
            this.btnMODIFICAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCONSULTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCONSULTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCONSULTAR.BorderRadius = 0;
            this.btnCONSULTAR.ButtonText = "CONSULTAR";
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.DisabledColor = System.Drawing.Color.Gray;
            this.btnCONSULTAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCONSULTAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Iconimage")));
            this.btnCONSULTAR.Iconimage_right = null;
            this.btnCONSULTAR.Iconimage_right_Selected = null;
            this.btnCONSULTAR.Iconimage_Selected = null;
            this.btnCONSULTAR.IconMarginLeft = 0;
            this.btnCONSULTAR.IconMarginRight = 0;
            this.btnCONSULTAR.IconRightVisible = true;
            this.btnCONSULTAR.IconRightZoom = 0D;
            this.btnCONSULTAR.IconVisible = true;
            this.btnCONSULTAR.IconZoom = 90D;
            this.btnCONSULTAR.IsTab = false;
            this.btnCONSULTAR.Location = new System.Drawing.Point(315, 250);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCONSULTAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCONSULTAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCONSULTAR.selected = false;
            this.btnCONSULTAR.Size = new System.Drawing.Size(241, 48);
            this.btnCONSULTAR.TabIndex = 3;
            this.btnCONSULTAR.Text = "CONSULTAR";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCONSULTAR.Textcolor = System.Drawing.Color.White;
            this.btnCONSULTAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnELIMINAR.BorderRadius = 0;
            this.btnELIMINAR.ButtonText = "ELIMINAR";
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.DisabledColor = System.Drawing.Color.Gray;
            this.btnELIMINAR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnELIMINAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Iconimage")));
            this.btnELIMINAR.Iconimage_right = null;
            this.btnELIMINAR.Iconimage_right_Selected = null;
            this.btnELIMINAR.Iconimage_Selected = null;
            this.btnELIMINAR.IconMarginLeft = 0;
            this.btnELIMINAR.IconMarginRight = 0;
            this.btnELIMINAR.IconRightVisible = true;
            this.btnELIMINAR.IconRightZoom = 0D;
            this.btnELIMINAR.IconVisible = true;
            this.btnELIMINAR.IconZoom = 90D;
            this.btnELIMINAR.IsTab = false;
            this.btnELIMINAR.Location = new System.Drawing.Point(315, 355);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnELIMINAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnELIMINAR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnELIMINAR.selected = false;
            this.btnELIMINAR.Size = new System.Drawing.Size(241, 48);
            this.btnELIMINAR.TabIndex = 4;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnELIMINAR.Textcolor = System.Drawing.Color.White;
            this.btnELIMINAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSALIR.BorderRadius = 0;
            this.btnSALIR.ButtonText = "Salir";
            this.btnSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSALIR.DisabledColor = System.Drawing.Color.Gray;
            this.btnSALIR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSALIR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSALIR.Iconimage")));
            this.btnSALIR.Iconimage_right = null;
            this.btnSALIR.Iconimage_right_Selected = null;
            this.btnSALIR.Iconimage_Selected = null;
            this.btnSALIR.IconMarginLeft = 0;
            this.btnSALIR.IconMarginRight = 0;
            this.btnSALIR.IconRightVisible = true;
            this.btnSALIR.IconRightZoom = 0D;
            this.btnSALIR.IconVisible = true;
            this.btnSALIR.IconZoom = 90D;
            this.btnSALIR.IsTab = false;
            this.btnSALIR.Location = new System.Drawing.Point(39, 355);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSALIR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSALIR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSALIR.selected = false;
            this.btnSALIR.Size = new System.Drawing.Size(122, 48);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSALIR.Textcolor = System.Drawing.Color.White;
            this.btnSALIR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // Frm_ListaTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.DGVLista_Temas);
            this.Name = "Frm_ListaTemas";
            this.Text = "Frm_ListaTemas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVLista_Temas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DGVLista_Temas;
        private Bunifu.Framework.UI.BunifuFlatButton btnAGREGAR;
        private Bunifu.Framework.UI.BunifuFlatButton btnMODIFICAR;
        private Bunifu.Framework.UI.BunifuFlatButton btnCONSULTAR;
        private Bunifu.Framework.UI.BunifuFlatButton btnELIMINAR;
        private Bunifu.Framework.UI.BunifuFlatButton btnSALIR;
    }
}