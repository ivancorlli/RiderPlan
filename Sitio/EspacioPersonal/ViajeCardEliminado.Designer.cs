namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajeCardEliminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajeCardEliminado));
            this.pbImagenViaje = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.btnRecuperar = new Wisej.Web.Button();
            this.btnEliminar = new Wisej.Web.Button();
            this.fechaViaje = new Wisej.Web.Label();
            this.viajeNombre = new Wisej.Web.Label();
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
            this.panel2.Controls.Add(this.btnRecuperar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.fechaViaje);
            this.panel2.Controls.Add(this.viajeNombre);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 107);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(183, 93);
            this.panel2.TabIndex = 2;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnRecuperar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnRecuperar.BackColor = System.Drawing.Color.Khaki;
            this.btnRecuperar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRecuperar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRecuperar.ImageSource = "Resource\\lib\\iconos\\ojo.png";
            this.btnRecuperar.Location = new System.Drawing.Point(6, 54);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnRecuperar.ResponsiveProfiles"))));
            this.btnRecuperar.Size = new System.Drawing.Size(35, 35);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.TabStop = false;
            this.btnRecuperar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnRecuperar.ToolTipText = "Recuperar";
            this.btnRecuperar.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.btnEliminar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.ImageSource = "Resource\\lib\\iconos\\delete.png";
            this.btnEliminar.Location = new System.Drawing.Point(47, 54);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnEliminar.ResponsiveProfiles"))));
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            // ViajeCardEliminado
            // 
            this.Anchor = Wisej.Web.AnchorStyles.None;
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.Controls.Add(this.panel1);
            this.CssStyle = "border-radius: 8px";
            this.Name = "ViajeCardEliminado";
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
        private Wisej.Web.Button btnRecuperar;
        private Wisej.Web.Button btnEliminar;
    }
}
