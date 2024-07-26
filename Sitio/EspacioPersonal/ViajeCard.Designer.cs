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
            this.panel2 = new Wisej.Web.Panel();
            this.btnIniciar = new Wisej.Web.Button();
            this.btnVer = new Wisej.Web.Button();
            this.btnEditar = new Wisej.Web.Button();
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
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.btnVer);
            this.panel2.Controls.Add(this.btnEditar);
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
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnIniciar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.BackColor = System.Drawing.Color.Orange;
            this.btnIniciar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnIniciar.ImageSource = "Resource\\lib\\iconos\\play.png";
            this.btnIniciar.Location = new System.Drawing.Point(96, 54);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnIniciar.ResponsiveProfiles"))));
            this.btnIniciar.Size = new System.Drawing.Size(35, 35);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
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
            this.btnVer.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnVer.ResponsiveProfiles"))));
            this.btnVer.Size = new System.Drawing.Size(35, 35);
            this.btnVer.TabIndex = 7;
            this.btnVer.TabStop = false;
            this.btnVer.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnEditar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEditar.ImageSource = "Resource\\lib\\iconos\\edit2.png";
            this.btnEditar.Location = new System.Drawing.Point(50, 54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnEditar.ResponsiveProfiles"))));
            this.btnEditar.Size = new System.Drawing.Size(35, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.TabStop = false;
            this.btnEditar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.btnEliminar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnEliminar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.ImageSource = "Resource\\lib\\iconos\\delete.png";
            this.btnEliminar.Location = new System.Drawing.Point(141, 54);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnEliminar.ResponsiveProfiles"))));
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // fechaViaje
            // 
            this.fechaViaje.AutoSize = true;
            this.fechaViaje.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaViaje.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.fechaViaje.Location = new System.Drawing.Point(8, 29);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(88, 18);
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
            this.viajeNombre.Size = new System.Drawing.Size(106, 18);
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
        private Wisej.Web.Button btnEditar;
        private Wisej.Web.Button btnEliminar;
        private Wisej.Web.Button btnVer;
        private Wisej.Web.Button btnIniciar;
    }
}
