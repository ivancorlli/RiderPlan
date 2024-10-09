namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajeCardRealizado
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

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImagenViaje = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.btnVer = new Wisej.Web.Button();
            this.fechaViaje = new Wisej.Web.Label();
            this.viajeNombre = new Wisej.Web.Label();
            this.btnDescargar = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagenViaje
            // 
            this.pbImagenViaje.BackColor = System.Drawing.Color.Transparent;
            this.pbImagenViaje.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbImagenViaje.CssStyle = "border-radius: 8px";
            this.pbImagenViaje.Dock = Wisej.Web.DockStyle.Top;
            this.pbImagenViaje.ImageSource = "Resource\\lib\\Imagenes\\mapa.png";
            this.pbImagenViaje.Location = new System.Drawing.Point(8, 8);
            this.pbImagenViaje.Name = "pbImagenViaje";
            this.pbImagenViaje.Size = new System.Drawing.Size(183, 99);
            this.pbImagenViaje.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbImagenViaje);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(8);
            this.panel1.Size = new System.Drawing.Size(199, 208);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDescargar);
            this.panel2.Controls.Add(this.btnVer);
            this.panel2.Controls.Add(this.fechaViaje);
            this.panel2.Controls.Add(this.viajeNombre);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 107);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(183, 93);
            this.panel2.TabIndex = 2;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnVer.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnVer.BackColor = System.Drawing.Color.Khaki;
            this.btnVer.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnVer.ImageSource = "Resource\\lib\\iconos\\ojo.png";
            this.btnVer.Location = new System.Drawing.Point(6, 54);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(35, 35);
            this.btnVer.TabIndex = 7;
            this.btnVer.TabStop = false;
            this.btnVer.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnVer.ToolTipText = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // fechaViaje
            // 
            this.fechaViaje.AutoSize = true;
            this.fechaViaje.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaViaje.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.fechaViaje.Location = new System.Drawing.Point(8, 29);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(92, 15);
            this.fechaViaje.TabIndex = 1;
            this.fechaViaje.Text = "Fecha del viaje";
            // 
            // viajeNombre
            // 
            this.viajeNombre.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.viajeNombre.AutoSize = true;
            this.viajeNombre.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.viajeNombre.ForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.viajeNombre.Location = new System.Drawing.Point(8, 8);
            this.viajeNombre.Name = "viajeNombre";
            this.viajeNombre.Size = new System.Drawing.Size(105, 15);
            this.viajeNombre.TabIndex = 0;
            this.viajeNombre.Text = "Nombre de viaje";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnDescargar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnDescargar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDescargar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDescargar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDescargar.ImageSource = "Resource\\lib\\iconos\\summary.png";
            this.btnDescargar.Location = new System.Drawing.Point(47, 54);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(35, 35);
            this.btnDescargar.TabIndex = 8;
            this.btnDescargar.TabStop = false;
            this.btnDescargar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnDescargar.ToolTipText = "Descargar";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // ViajeCardRealizado
            // 
            this.Anchor = Wisej.Web.AnchorStyles.None;
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.Controls.Add(this.panel1);
            this.CssStyle = "border-radius: 8px";
            this.Name = "ViajeCardRealizado";
            this.Size = new System.Drawing.Size(201, 210);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PictureBox pbImagenViaje;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label fechaViaje;
        private Wisej.Web.Label viajeNombre;
        private Wisej.Web.Button btnVer;
        private Wisej.Web.Button btnDescargar;
    }
}
