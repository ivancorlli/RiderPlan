namespace RaiderPlan.Sitio.Inicio
{
    partial class winNuevoViaje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winNuevoViaje));
            this.dtpFechaSalida = new Wisej.Web.DateTimePicker();
            this.pnlContent = new Wisej.Web.Panel();
            this.txtMarca = new Wisej.Web.TextBox();
            this.dtpFechaLlegada = new Wisej.Web.DateTimePicker();
            this.btnRegistro = new Wisej.Web.Button();
            this.lblMansaje = new Wisej.Web.Label();
            this.txtMotocicleta = new Wisej.Web.TextBox();
            this.txtNombre = new Wisej.Web.TextBox();
            this.upload1 = new Wisej.Web.Upload();
            this.pbImagenPerfil = new Wisej.Web.PictureBox();
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.dtpFechaSalida.Location = new System.Drawing.Point(22, 370);
            this.dtpFechaSalida.Margin = new Wisej.Web.Padding(0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dtpFechaSalida.ResponsiveProfiles"))));
            this.dtpFechaSalida.Size = new System.Drawing.Size(345, 47);
            this.dtpFechaSalida.TabIndex = 3;
            this.dtpFechaSalida.Value = new System.DateTime(((long)(0)));
            this.dtpFechaSalida.Watermark = "Fecha de salida";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.Controls.Add(this.txtMarca);
            this.pnlContent.Controls.Add(this.dtpFechaLlegada);
            this.pnlContent.Controls.Add(this.btnRegistro);
            this.pnlContent.Controls.Add(this.lblMansaje);
            this.pnlContent.Controls.Add(this.txtMotocicleta);
            this.pnlContent.Controls.Add(this.txtNombre);
            this.pnlContent.Controls.Add(this.upload1);
            this.pnlContent.Controls.Add(this.pbImagenPerfil);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.dtpFechaSalida);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(389, 609);
            this.pnlContent.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = false;
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtMarca.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtMarca.CssStyle = "border-radius: 10px;";
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(22, 311);
            this.txtMarca.MaxLength = 60;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtMarca.ResponsiveProfiles"))));
            this.txtMarca.Size = new System.Drawing.Size(345, 47);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.Watermark = "Marca";
            this.txtMarca.WordWrap = false;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.AutoSize = false;
            this.dtpFechaLlegada.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.dtpFechaLlegada.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dtpFechaLlegada.CssStyle = "border-radius: 10px;";
            this.dtpFechaLlegada.ForeColor = System.Drawing.Color.White;
            this.dtpFechaLlegada.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(22, 426);
            this.dtpFechaLlegada.Margin = new Wisej.Web.Padding(0);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dtpFechaLlegada.ResponsiveProfiles"))));
            this.dtpFechaLlegada.Size = new System.Drawing.Size(345, 47);
            this.dtpFechaLlegada.TabIndex = 4;
            this.dtpFechaLlegada.Value = new System.DateTime(((long)(0)));
            this.dtpFechaLlegada.Watermark = "Fecha de llegada";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnRegistro.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistro.Location = new System.Drawing.Point(22, 541);
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
            this.lblMansaje.Location = new System.Drawing.Point(22, 508);
            this.lblMansaje.Name = "lblMansaje";
            this.lblMansaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMansaje.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblMansaje.ResponsiveProfiles"))));
            this.lblMansaje.Size = new System.Drawing.Size(345, 27);
            this.lblMansaje.TabIndex = 3000;
            this.lblMansaje.Text = "Mensaje";
            this.lblMansaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMansaje.Visible = false;
            // 
            // txtMotocicleta
            // 
            this.txtMotocicleta.AutoSize = false;
            this.txtMotocicleta.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtMotocicleta.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtMotocicleta.CssStyle = "border-radius: 10px;";
            this.txtMotocicleta.ForeColor = System.Drawing.Color.White;
            this.txtMotocicleta.Location = new System.Drawing.Point(22, 249);
            this.txtMotocicleta.MaxLength = 60;
            this.txtMotocicleta.Name = "txtMotocicleta";
            this.txtMotocicleta.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtMotocicleta.ResponsiveProfiles"))));
            this.txtMotocicleta.Size = new System.Drawing.Size(345, 47);
            this.txtMotocicleta.TabIndex = 1;
            this.txtMotocicleta.Watermark = "Motocicleta";
            this.txtMotocicleta.WordWrap = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtNombre.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtNombre.CssStyle = "border-radius: 10px;";
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(22, 192);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtNombre.ResponsiveProfiles"))));
            this.txtNombre.Size = new System.Drawing.Size(345, 47);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Watermark = "Nombre";
            // 
            // upload1
            // 
            this.upload1.AllowedFileTypes = "image/*";
            this.upload1.HideValue = true;
            this.upload1.Location = new System.Drawing.Point(139, 113);
            this.upload1.Name = "upload1";
            this.upload1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("upload1.ResponsiveProfiles"))));
            this.upload1.Size = new System.Drawing.Size(152, 22);
            this.upload1.TabIndex = 3005;
            this.upload1.Text = "Seleccionar imagen";
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
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
            this.Cancelar.Location = new System.Drawing.Point(335, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("Cancelar.ResponsiveProfiles"))));
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 3002;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles"))));
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 3001;
            this.label2.Text = "Nuevo Viaje";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // winNuevoViaje
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(389, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(25, -359);
            this.Name = "winNuevoViaje";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.DateTimePicker dtpFechaSalida;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblMansaje;
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.PictureBox pbImagenPerfil;
        private Wisej.Web.Upload upload1;
        private Wisej.Web.TextBox txtMotocicleta;
        private Wisej.Web.TextBox txtNombre;
        private Wisej.Web.Button btnRegistro;
        private Wisej.Web.DateTimePicker dtpFechaLlegada;
        private Wisej.Web.TextBox txtMarca;
    }
}