namespace RaiderPlan.Sitio.Inicio
{
    partial class winPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winPerfil));
            this.txtNombreUsuario = new Wisej.Web.TextBox();
            this.dtpFechaNacimiento = new Wisej.Web.DateTimePicker();
            this.pnlContent = new Wisej.Web.Panel();
            this.btnRegistro = new Wisej.Web.Button();
            this.cbCiudad = new Wisej.Web.ComboBox();
            this.lblMansaje = new Wisej.Web.Label();
            this.cbProvincia = new Wisej.Web.ComboBox();
            this.cbSexo = new Wisej.Web.ComboBox();
            this.txtApellido = new Wisej.Web.TextBox();
            this.txtNombre = new Wisej.Web.TextBox();
            this.line1 = new Wisej.Web.Line();
            this.upload1 = new Wisej.Web.Upload();
            this.pbImagenPerfil = new Wisej.Web.PictureBox();
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.txtEmail = new Wisej.Web.TextBox();
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AutoSize = false;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtNombreUsuario.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtNombreUsuario.CssStyle = "border-radius: 10px;";
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNombreUsuario.Location = new System.Drawing.Point(436, 192);
            this.txtNombreUsuario.Margin = new Wisej.Web.Padding(0);
            this.txtNombreUsuario.MaxLength = 60;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtNombreUsuario.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtNombreUsuario.ResponsiveProfiles"))));
            this.txtNombreUsuario.Size = new System.Drawing.Size(345, 47);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.Watermark = "Username";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.AutoSize = false;
            this.dtpFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.dtpFechaNacimiento.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dtpFechaNacimiento.CssStyle = "border-radius: 10px;";
            this.dtpFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(22, 307);
            this.dtpFechaNacimiento.Margin = new Wisej.Web.Padding(0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dtpFechaNacimiento.ResponsiveProfiles"))));
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(345, 47);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Value = new System.DateTime(((long)(0)));
            this.dtpFechaNacimiento.Watermark = "Fecha de nacimiento";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.Controls.Add(this.btnRegistro);
            this.pnlContent.Controls.Add(this.cbCiudad);
            this.pnlContent.Controls.Add(this.lblMansaje);
            this.pnlContent.Controls.Add(this.cbProvincia);
            this.pnlContent.Controls.Add(this.cbSexo);
            this.pnlContent.Controls.Add(this.txtApellido);
            this.pnlContent.Controls.Add(this.txtNombre);
            this.pnlContent.Controls.Add(this.line1);
            this.pnlContent.Controls.Add(this.upload1);
            this.pnlContent.Controls.Add(this.pbImagenPerfil);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtEmail);
            this.pnlContent.Controls.Add(this.dtpFechaNacimiento);
            this.pnlContent.Controls.Add(this.txtNombreUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(801, 557);
            this.pnlContent.TabIndex = 1;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnRegistro.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistro.Location = new System.Drawing.Point(225, 500);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnRegistro.ResponsiveProfiles"))));
            this.btnRegistro.Size = new System.Drawing.Size(345, 35);
            this.btnRegistro.TabIndex = 3001;
            this.btnRegistro.Text = "Guardar";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.AutoSize = false;
            this.cbCiudad.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.cbCiudad.BorderStyle = Wisej.Web.BorderStyle.None;
            this.cbCiudad.CssStyle = "border-radius: 10px;";
            this.cbCiudad.ForeColor = System.Drawing.Color.White;
            this.cbCiudad.Location = new System.Drawing.Point(436, 371);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cbCiudad.ResponsiveProfiles"))));
            this.cbCiudad.Size = new System.Drawing.Size(345, 47);
            this.cbCiudad.TabIndex = 10018;
            this.cbCiudad.TabStop = false;
            this.cbCiudad.Text = "Ciudad";
            this.cbCiudad.Watermark = "Ciudad";
            // 
            // lblMansaje
            // 
            this.lblMansaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMansaje.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblMansaje.Location = new System.Drawing.Point(225, 456);
            this.lblMansaje.Name = "lblMansaje";
            this.lblMansaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMansaje.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblMansaje.ResponsiveProfiles"))));
            this.lblMansaje.Size = new System.Drawing.Size(345, 27);
            this.lblMansaje.TabIndex = 3000;
            this.lblMansaje.Text = "Mensaje";
            this.lblMansaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMansaje.Visible = false;
            // 
            // cbProvincia
            // 
            this.cbProvincia.AutoSize = false;
            this.cbProvincia.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.cbProvincia.BorderStyle = Wisej.Web.BorderStyle.None;
            this.cbProvincia.CssStyle = "border-radius: 10px;";
            this.cbProvincia.ForeColor = System.Drawing.Color.White;
            this.cbProvincia.Location = new System.Drawing.Point(436, 310);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cbProvincia.ResponsiveProfiles"))));
            this.cbProvincia.Size = new System.Drawing.Size(345, 47);
            this.cbProvincia.TabIndex = 10017;
            this.cbProvincia.TabStop = false;
            this.cbProvincia.Text = "Provincia";
            this.cbProvincia.Watermark = "Provincia";
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.AutoSize = false;
            this.cbSexo.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.cbSexo.BorderStyle = Wisej.Web.BorderStyle.None;
            this.cbSexo.CssStyle = "border-radius: 10px;";
            this.cbSexo.ForeColor = System.Drawing.Color.White;
            this.cbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cbSexo.Location = new System.Drawing.Point(22, 367);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cbSexo.ResponsiveProfiles"))));
            this.cbSexo.Size = new System.Drawing.Size(345, 47);
            this.cbSexo.TabIndex = 10016;
            this.cbSexo.TabStop = false;
            this.cbSexo.Text = "Sexo";
            this.cbSexo.Watermark = "Sexo";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = false;
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtApellido.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtApellido.CssStyle = "border-radius: 10px;";
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(22, 249);
            this.txtApellido.MaxLength = 60;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtApellido.ResponsiveProfiles"))));
            this.txtApellido.Size = new System.Drawing.Size(345, 47);
            this.txtApellido.TabIndex = 3010;
            this.txtApellido.Watermark = "Apellido";
            this.txtApellido.WordWrap = false;
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
            this.txtNombre.TabIndex = 3009;
            this.txtNombre.Watermark = "Nombre";
            // 
            // line1
            // 
            this.line1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(392, 209);
            this.line1.Name = "line1";
            this.line1.Orientation = Wisej.Web.Orientation.Vertical;
            this.line1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("line1.ResponsiveProfiles"))));
            this.line1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("line1.ResponsiveProfiles1"))));
            this.line1.Size = new System.Drawing.Size(18, 192);
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
            this.pbImagenPerfil.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbImagenPerfil.ImageSource = "\\Resource\\lib\\Imagenes\\iconousuario.png";
            this.pbImagenPerfil.Location = new System.Drawing.Point(22, 73);
            this.pbImagenPerfil.Name = "pbImagenPerfil";
            this.pbImagenPerfil.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pbImagenPerfil.ResponsiveProfiles"))));
            this.pbImagenPerfil.Size = new System.Drawing.Size(92, 88);
            this.pbImagenPerfil.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(749, 12);
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
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 3001;
            this.label2.Text = "Registrarme";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = false;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtEmail.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtEmail.CssStyle = "border-radius: 10px;";
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(436, 251);
            this.txtEmail.Margin = new Wisej.Web.Padding(0);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtEmail.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtEmail.ResponsiveProfiles"))));
            this.txtEmail.Size = new System.Drawing.Size(345, 47);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Watermark = "Email";
            this.txtEmail.WordWrap = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // winPerfil
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(801, 557);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(25, -359);
            this.Name = "winPerfil";
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
        private Wisej.Web.TextBox txtNombreUsuario;
        private Wisej.Web.DateTimePicker dtpFechaNacimiento;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.Label lblMansaje;
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.PictureBox pbImagenPerfil;
        private Wisej.Web.Upload upload1;
        private Wisej.Web.Line line1;
        private Wisej.Web.TextBox txtApellido;
        private Wisej.Web.TextBox txtNombre;
        private Wisej.Web.ComboBox cbSexo;
        private Wisej.Web.ComboBox cbProvincia;
        private Wisej.Web.ComboBox cbCiudad;
        private Wisej.Web.Button btnRegistro;
    }
}