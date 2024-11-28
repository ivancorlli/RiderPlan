namespace RaiderPlan.Sitio.Inicio
{
    partial class winRegistro
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
            this.txtNombreUsuario = new Wisej.Web.TextBox();
            this.dtpFechaNacimiento = new Wisej.Web.DateTimePicker();
            this.pnlContent = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.btnAceptar = new Wisej.Web.Button();
            this.line1 = new Wisej.Web.Line();
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.txtPassword2 = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.lblMansaje = new Wisej.Web.Label();
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.chkTerminos = new Wisej.Web.CheckBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.pnlContent.SuspendLayout();
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
            this.txtNombreUsuario.Location = new System.Drawing.Point(22, 125);
            this.txtNombreUsuario.Margin = new Wisej.Web.Padding(0);
            this.txtNombreUsuario.MaxLength = 60;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtNombreUsuario.Size = new System.Drawing.Size(345, 47);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.Watermark = "Username";
            this.txtNombreUsuario.Leave += new System.EventHandler(this.txtNombreUsuario_Leave);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.AutoSize = false;
            this.dtpFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.dtpFechaNacimiento.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dtpFechaNacimiento.CssStyle = "border-radius: 10px;";
            this.dtpFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(22, 238);
            this.dtpFechaNacimiento.Margin = new Wisej.Web.Padding(0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(345, 47);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Value = new System.DateTime(((long)(0)));
            this.dtpFechaNacimiento.Watermark = "Fecha de nacimiento";
            this.dtpFechaNacimiento.Leave += new System.EventHandler(this.dtpFechaNacimiento_Leave);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.btnAceptar);
            this.pnlContent.Controls.Add(this.line1);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtPassword2);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.lblMansaje);
            this.pnlContent.Controls.Add(this.linkLabel1);
            this.pnlContent.Controls.Add(this.chkTerminos);
            this.pnlContent.Controls.Add(this.txtEmail);
            this.pnlContent.Controls.Add(this.dtpFechaNacimiento);
            this.pnlContent.Controls.Add(this.txtNombreUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(398, 574);
            this.pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = Wisej.Web.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("defaultBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label1.Location = new System.Drawing.Point(123, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 3004;
            this.label1.Text = "Ya tengo cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnAceptar.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAceptar.Location = new System.Drawing.Point(81, 462);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(228, 44);
            this.btnAceptar.TabIndex = 3003;
            this.btnAceptar.Text = "Registrarme";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(36, 512);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(316, 10);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(356, 12);
            this.Cancelar.Name = "Cancelar";
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
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 3001;
            this.label2.Text = "Registrarme";
            // 
            // txtPassword2
            // 
            this.txtPassword2.AutoSize = false;
            this.txtPassword2.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtPassword2.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtPassword2.CssStyle = "border-radius: 10px;";
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword2.Location = new System.Drawing.Point(22, 356);
            this.txtPassword2.Margin = new Wisej.Web.Padding(0);
            this.txtPassword2.MaxLength = 100;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(345, 47);
            this.txtPassword2.TabIndex = 5;
            this.txtPassword2.Watermark = "Confirmar password";
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = false;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtPassword.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtPassword.CssStyle = "border-radius: 10px;";
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(22, 296);
            this.txtPassword.Margin = new Wisej.Web.Padding(0);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(345, 47);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Watermark = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblMansaje
            // 
            this.lblMansaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMansaje.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblMansaje.Location = new System.Drawing.Point(22, 81);
            this.lblMansaje.Name = "lblMansaje";
            this.lblMansaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMansaje.Size = new System.Drawing.Size(345, 27);
            this.lblMansaje.TabIndex = 3000;
            this.lblMansaje.Text = "Mensaje";
            this.lblMansaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMansaje.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(99, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 20);
            this.linkLabel1.TabIndex = 100;
            this.linkLabel1.Text = "terminos y condiciones de uso";
            // 
            // chkTerminos
            // 
            this.chkTerminos.ForeColor = System.Drawing.Color.White;
            this.chkTerminos.Location = new System.Drawing.Point(29, 422);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(71, 23);
            this.chkTerminos.TabIndex = 6;
            this.chkTerminos.Text = "Acepto";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = false;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtEmail.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtEmail.CssStyle = "border-radius: 10px;";
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(22, 181);
            this.txtEmail.Margin = new Wisej.Web.Padding(0);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtEmail.Size = new System.Drawing.Size(345, 47);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Watermark = "Email";
            this.txtEmail.WordWrap = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // winRegistro
            // 
            this.ClientSize = new System.Drawing.Size(398, 574);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "winRegistro";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.TextBox txtNombreUsuario;
        private Wisej.Web.DateTimePicker dtpFechaNacimiento;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.Label lblMansaje;
        private Wisej.Web.LinkLabel linkLabel1;
        private Wisej.Web.CheckBox chkTerminos;
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtPassword2;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.Line line1;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.Label label1;
    }
}