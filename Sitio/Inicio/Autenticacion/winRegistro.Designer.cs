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
            this.pnlBotones = new Wisej.Web.Panel();
            this.Cancel = new Wisej.Web.Button();
            this.Registrarme = new Wisej.Web.Button();
            this.txtNombreUsuario = new Wisej.Web.TextBox();
            this.lblNombreusuario = new Wisej.Web.Label();
            this.dtpFechaNacimiento = new Wisej.Web.DateTimePicker();
            this.lblFechaNac = new Wisej.Web.Label();
            this.lblEmail = new Wisej.Web.Label();
            this.pnlContent = new Wisej.Web.Panel();
            this.lblRegistro = new Wisej.Web.Label();
            this.label9 = new Wisej.Web.Label();
            this.lblPassword2 = new Wisej.Web.Label();
            this.txtPassword2 = new Wisej.Web.TextBox();
            this.label10 = new Wisej.Web.Label();
            this.lblPassword = new Wisej.Web.Label();
            this.txtPassword = new Wisej.Web.TextBox();
            this.lblMansaje = new Wisej.Web.Label();
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.chkTerminos = new Wisej.Web.CheckBox();
            this.label6 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.lbObligatorio = new Wisej.Web.Label();
            this.txtEmail = new Wisej.Web.TextBox();
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.pnlBotones.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromName("@invalid");
            this.pnlBotones.Controls.Add(this.Cancel);
            this.pnlBotones.Controls.Add(this.Registrarme);
            this.pnlBotones.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 367);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(502, 48);
            this.pnlBotones.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(161, 9);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 27);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancelar";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Registrarme
            // 
            this.Registrarme.Location = new System.Drawing.Point(30, 9);
            this.Registrarme.Name = "Registrarme";
            this.Registrarme.Size = new System.Drawing.Size(125, 27);
            this.Registrarme.TabIndex = 7;
            this.Registrarme.Text = "Registrarme";
            this.Registrarme.Click += new System.EventHandler(this.Registrarme_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(30, 60);
            this.txtNombreUsuario.MaxLength = 60;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(441, 22);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.Leave += new System.EventHandler(this.txtNombreUsuario_Leave);
            // 
            // lblNombreusuario
            // 
            this.lblNombreusuario.AutoSize = true;
            this.lblNombreusuario.Location = new System.Drawing.Point(30, 44);
            this.lblNombreusuario.Name = "lblNombreusuario";
            this.lblNombreusuario.Size = new System.Drawing.Size(176, 15);
            this.lblNombreusuario.TabIndex = 1;
            this.lblNombreusuario.Text = "Nombre de usuario que usará";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(30, 164);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Leave += new System.EventHandler(this.dtpFechaNacimiento_Leave);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(30, 146);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(125, 15);
            this.lblFechaNac.TabIndex = 7;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 15);
            this.lblEmail.TabIndex = 10000;
            this.lblEmail.Text = "Email";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblRegistro);
            this.pnlContent.Controls.Add(this.label9);
            this.pnlContent.Controls.Add(this.lblPassword2);
            this.pnlContent.Controls.Add(this.txtPassword2);
            this.pnlContent.Controls.Add(this.label10);
            this.pnlContent.Controls.Add(this.lblPassword);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.lblMansaje);
            this.pnlContent.Controls.Add(this.linkLabel1);
            this.pnlContent.Controls.Add(this.chkTerminos);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.lbObligatorio);
            this.pnlContent.Controls.Add(this.lblEmail);
            this.pnlContent.Controls.Add(this.txtEmail);
            this.pnlContent.Controls.Add(this.lblFechaNac);
            this.pnlContent.Controls.Add(this.dtpFechaNacimiento);
            this.pnlContent.Controls.Add(this.lblNombreusuario);
            this.pnlContent.Controls.Add(this.txtNombreUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(502, 367);
            this.pnlContent.TabIndex = 1;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.FromName("@table-row");
            this.lblRegistro.Dock = Wisej.Web.DockStyle.Top;
            this.lblRegistro.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(502, 25);
            this.lblRegistro.TabIndex = 10001;
            this.lblRegistro.Text = "Registrarse";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.label9.Location = new System.Drawing.Point(9, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 31);
            this.label9.TabIndex = 106;
            this.label9.Text = "*";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(30, 251);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(119, 15);
            this.lblPassword2.TabIndex = 105;
            this.lblPassword2.Text = "Repita su password";
            // 
            // txtPassword2
            // 
            this.txtPassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword2.Location = new System.Drawing.Point(30, 268);
            this.txtPassword2.MaxLength = 100;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(441, 22);
            this.txtPassword2.TabIndex = 5;
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.label10.Location = new System.Drawing.Point(11, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 31);
            this.label10.TabIndex = 103;
            this.label10.Text = "*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 102;
            this.lblPassword.Text = "Paswword";
            // 
            // txtPassword
            // 
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(32, 216);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(441, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblMansaje
            // 
            this.lblMansaje.BackColor = System.Drawing.Color.FromArgb(255, 198, 198);
            this.lblMansaje.Dock = Wisej.Web.DockStyle.Bottom;
            this.lblMansaje.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblMansaje.Location = new System.Drawing.Point(0, 340);
            this.lblMansaje.Name = "lblMansaje";
            this.lblMansaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMansaje.Size = new System.Drawing.Size(502, 27);
            this.lblMansaje.TabIndex = 3000;
            this.lblMansaje.Text = "Mensaje";
            this.lblMansaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMansaje.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(267, 310);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 17);
            this.linkLabel1.TabIndex = 100;
            this.linkLabel1.Text = "Terminos y condiciones de uso";
            // 
            // chkTerminos
            // 
            this.chkTerminos.Location = new System.Drawing.Point(32, 307);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(229, 22);
            this.chkTerminos.TabIndex = 6;
            this.chkTerminos.Text = "Acepto los terminos y condiciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbObligatorio.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lbObligatorio.Location = new System.Drawing.Point(9, 56);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(15, 31);
            this.lbObligatorio.TabIndex = 19;
            this.lbObligatorio.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(30, 112);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(441, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.WordWrap = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // winRegistro
            // 
            this.ClientSize = new System.Drawing.Size(502, 415);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBotones);
            this.CssStyle = "border: 2px solid red;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "winRegistro";
            this.Text = "Registro";
            this.pnlBotones.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlBotones;
        private Wisej.Web.TextBox txtNombreUsuario;
        private Wisej.Web.Label lblNombreusuario;
        private Wisej.Web.DateTimePicker dtpFechaNacimiento;
        private Wisej.Web.Label lblFechaNac;
        private Wisej.Web.Label lblEmail;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.Button Cancel;
        private Wisej.Web.Button Registrarme;
        private Wisej.Web.Label lblMansaje;
        private Wisej.Web.LinkLabel linkLabel1;
        private Wisej.Web.CheckBox chkTerminos;
        private Wisej.Web.Label label6;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label lbObligatorio;
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Label lblPassword;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.Label label10;
        private Wisej.Web.Label label9;
        private Wisej.Web.Label lblPassword2;
        private Wisej.Web.TextBox txtPassword2;
        private Wisej.Web.Label lblRegistro;
    }
}