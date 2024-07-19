namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajeCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajeCard));
            this.pbImagenViaje = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.pbVer = new Wisej.Web.PictureBox();
            this.panel2 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.btnEliminar = new Wisej.Web.Button();
            this.fechaViaje = new Wisej.Web.Label();
            this.viajeNombre = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagenViaje
            // 
            this.pbImagenViaje.BackColor = System.Drawing.Color.FromName("@window");
            this.pbImagenViaje.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbImagenViaje.Dock = Wisej.Web.DockStyle.Top;
            this.pbImagenViaje.ImageSource = "Resource\\lib\\Imagenes\\mapa.png";
            this.pbImagenViaje.Location = new System.Drawing.Point(5, 5);
            this.pbImagenViaje.Name = "pbImagenViaje";
            this.pbImagenViaje.Size = new System.Drawing.Size(189, 99);
            this.pbImagenViaje.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbImagenViaje);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(199, 208);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.panel3.Controls.Add(this.pbVer);
            this.panel3.CssStyle = "border-radius: 25%";
            this.panel3.Location = new System.Drawing.Point(158, 8);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(5);
            this.panel3.Size = new System.Drawing.Size(35, 29);
            this.panel3.TabIndex = 4;
            this.panel3.PanelCollapsed += new System.EventHandler(this.panel3_PanelCollapsed);
            // 
            // pbVer
            // 
            this.pbVer.BackColor = System.Drawing.Color.Transparent;
            this.pbVer.Cursor = Wisej.Web.Cursors.Hand;
            this.pbVer.Dock = Wisej.Web.DockStyle.Fill;
            this.pbVer.ForeColor = System.Drawing.Color.Transparent;
            this.pbVer.ImageSource = "Resource\\lib\\iconos\\ojo.png";
            this.pbVer.Location = new System.Drawing.Point(5, 5);
            this.pbVer.Name = "pbVer";
            this.pbVer.Size = new System.Drawing.Size(25, 19);
            this.pbVer.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            this.pbVer.Click += new System.EventHandler(this.pbVer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.fechaViaje);
            this.panel2.Controls.Add(this.viajeNombre);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 104);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(189, 99);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.button1.Location = new System.Drawing.Point(8, 60);
            this.button1.Name = "button1";
            this.button1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("button1.ResponsiveProfiles"))));
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnEliminar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnEliminar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.Location = new System.Drawing.Point(117, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnEliminar.ResponsiveProfiles"))));
            this.btnEliminar.Size = new System.Drawing.Size(66, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // fechaViaje
            // 
            this.fechaViaje.AutoSize = true;
            this.fechaViaje.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaViaje.ForeColor = System.Drawing.Color.FromName("@control");
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
            // ViajeCard
            // 
            this.Anchor = Wisej.Web.AnchorStyles.None;
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.Controls.Add(this.panel1);
            this.CssStyle = "border-radius: 8px";
            this.Name = "ViajeCard";
            this.Size = new System.Drawing.Size(201, 210);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).EndInit();
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
        private Wisej.Web.Button button1;
        private Wisej.Web.Button btnEliminar;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.PictureBox pbVer;
    }
}
