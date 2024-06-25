namespace RaiderPlan.Sitio.Inicio
{
    partial class winCodigoRecuperacion
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
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.txtCodigo = new Wisej.Web.TextBox();
            this.lblError = new Wisej.Web.Label();
            this.btnAceptar = new Wisej.Web.Button();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtPassword2 = new Wisej.Web.TextBox();
            this.lblMensaje = new Wisej.Web.Label();
            this.pnlContent = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.AllowHtml = true;
            this.errorProvider1.BlinkAnimation = Wisej.Web.ErrorAnimationType.Bounce;
            this.errorProvider1.BlinkRate = 1;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.IconPadding = 2;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(357, 13);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label2
            // 
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modificar Contraseña";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = false;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtCodigo.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtCodigo.CssStyle = "border-radius: 10px;\r\n";
            this.txtCodigo.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(32, 139);
            this.txtCodigo.Margin = new Wisej.Web.Padding(0);
            this.txtCodigo.MaxLength = 60;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtCodigo.Size = new System.Drawing.Size(345, 37);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.Watermark = "Codigo";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(32, 65);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblError.Size = new System.Drawing.Size(345, 40);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "Ingresa el codigo de recuperacion que enviamos a tu correo electronico";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnAceptar.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAceptar.Location = new System.Drawing.Point(82, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(212, 39);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = false;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtPassword.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtPassword.CssStyle = "border-radius: 10px;\r\n";
            this.txtPassword.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(32, 187);
            this.txtPassword.Margin = new Wisej.Web.Padding(0);
            this.txtPassword.MaxLength = 60;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(345, 37);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Watermark = "Password";
            // 
            // txtPassword2
            // 
            this.txtPassword2.AutoSize = false;
            this.txtPassword2.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtPassword2.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtPassword2.CssStyle = "border-radius: 10px;\r\n";
            this.txtPassword2.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword2.Location = new System.Drawing.Point(32, 235);
            this.txtPassword2.Margin = new Wisej.Web.Padding(0);
            this.txtPassword2.MaxLength = 60;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(345, 37);
            this.txtPassword2.TabIndex = 21;
            this.txtPassword2.Watermark = "Confirmar Password";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblMensaje.Location = new System.Drawing.Point(32, 111);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblMensaje.Size = new System.Drawing.Size(345, 25);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Mesaje de error";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensaje.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlContent.Controls.Add(this.lblMensaje);
            this.pnlContent.Controls.Add(this.txtPassword2);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.btnAceptar);
            this.pnlContent.Controls.Add(this.lblError);
            this.pnlContent.Controls.Add(this.txtCodigo);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(409, 340);
            this.pnlContent.TabIndex = 2;
            // 
            // winCodigoRecuperacion
            // 
            this.ClientSize = new System.Drawing.Size(409, 340);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "winCodigoRecuperacion";
            this.Text = "winCodigoRecuperacion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblMensaje;
        private Wisej.Web.TextBox txtPassword2;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.Label lblError;
        private Wisej.Web.TextBox txtCodigo;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
    }
}