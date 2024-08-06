namespace RaiderPlan.Sitio.Inicio
{
    partial class winIniciaViaje
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winIniciaViaje));
            this.dtpFechaSalida = new Wisej.Web.DateTimePicker();
            this.pnlContent = new Wisej.Web.Panel();
            this.lblFechaProgramada = new Wisej.Web.Label();
            this.btnRegistro = new Wisej.Web.Button();
            this.lblMansaje = new Wisej.Web.Label();
            this.pbImagenPerfil = new Wisej.Web.PictureBox();
            this.Cancelar = new Wisej.Web.Button();
            this.lblViajeNombre = new Wisej.Web.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.AutoSize = false;
            this.dtpFechaSalida.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.dtpFechaSalida.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dtpFechaSalida.CssStyle = "border-radius: 10px;";
            this.dtpFechaSalida.ForeColor = System.Drawing.Color.White;
            this.dtpFechaSalida.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(30, 212);
            this.dtpFechaSalida.Margin = new Wisej.Web.Padding(0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dtpFechaSalida.ResponsiveProfiles"))));
            this.dtpFechaSalida.Size = new System.Drawing.Size(345, 47);
            this.dtpFechaSalida.TabIndex = 1;
            this.dtpFechaSalida.TodayDate = new System.DateTime(2024, 8, 6, 0, 0, 0, 0);
            this.dtpFechaSalida.Value = new System.DateTime(((long)(0)));
            this.dtpFechaSalida.Watermark = "Fecha de salida";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.Controls.Add(this.lblFechaProgramada);
            this.pnlContent.Controls.Add(this.btnRegistro);
            this.pnlContent.Controls.Add(this.lblMansaje);
            this.pnlContent.Controls.Add(this.pbImagenPerfil);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.lblViajeNombre);
            this.pnlContent.Controls.Add(this.dtpFechaSalida);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(407, 410);
            this.pnlContent.TabIndex = 1;
            // 
            // lblFechaProgramada
            // 
            this.lblFechaProgramada.AutoSize = true;
            this.lblFechaProgramada.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaProgramada.ForeColor = System.Drawing.Color.FromName("@control");
            this.lblFechaProgramada.Location = new System.Drawing.Point(129, 127);
            this.lblFechaProgramada.Name = "lblFechaProgramada";
            this.lblFechaProgramada.Size = new System.Drawing.Size(38, 18);
            this.lblFechaProgramada.TabIndex = 3007;
            this.lblFechaProgramada.Text = "Fecha";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnRegistro.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistro.Location = new System.Drawing.Point(30, 322);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnRegistro.ResponsiveProfiles"))));
            this.btnRegistro.Size = new System.Drawing.Size(345, 35);
            this.btnRegistro.TabIndex = 5;
            this.btnRegistro.Text = "Guardar";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblMansaje
            // 
            this.lblMansaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMansaje.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblMansaje.Location = new System.Drawing.Point(30, 289);
            this.lblMansaje.Name = "lblMansaje";
            this.lblMansaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMansaje.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblMansaje.ResponsiveProfiles"))));
            this.lblMansaje.Size = new System.Drawing.Size(345, 27);
            this.lblMansaje.TabIndex = 3000;
            this.lblMansaje.Text = "Mensaje";
            this.lblMansaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMansaje.Visible = false;
            // 
            // pbImagenPerfil
            // 
            this.pbImagenPerfil.BackColor = System.Drawing.Color.FromName("@window");
            this.pbImagenPerfil.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbImagenPerfil.ImageSource = "Resource\\lib\\Imagenes\\mapa.png";
            this.pbImagenPerfil.Location = new System.Drawing.Point(22, 73);
            this.pbImagenPerfil.Name = "pbImagenPerfil";
            this.pbImagenPerfil.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pbImagenPerfil.ResponsiveProfiles"))));
            this.pbImagenPerfil.Size = new System.Drawing.Size(86, 88);
            this.pbImagenPerfil.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(356, 16);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("Cancelar.ResponsiveProfiles"))));
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 3002;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // lblViajeNombre
            // 
            this.lblViajeNombre.AutoSize = true;
            this.lblViajeNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblViajeNombre.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblViajeNombre.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblViajeNombre.Location = new System.Drawing.Point(129, 85);
            this.lblViajeNombre.Name = "lblViajeNombre";
            this.lblViajeNombre.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblViajeNombre.ResponsiveProfiles"))));
            this.lblViajeNombre.Size = new System.Drawing.Size(129, 30);
            this.lblViajeNombre.TabIndex = 3001;
            this.lblViajeNombre.Text = "Nuevo Viaje";
            // 
            // winIniciaViaje
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(407, 410);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(25, -359);
            this.Name = "winIniciaViaje";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.DateTimePicker dtpFechaSalida;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblMansaje;
        private Wisej.Web.Label lblViajeNombre;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.PictureBox pbImagenPerfil;
        private Wisej.Web.Button btnRegistro;
        private Wisej.Web.Label lblFechaProgramada;
    }
}