namespace RaiderPlan.Sitio.Inicio
{
    partial class winLogin
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
            this.txtEmailUsuario = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.lblError = new Wisej.Web.Label();
            this.pnlContent = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.lklcontraseña = new Wisej.Web.LinkLabel();
            this.Cancelar = new Wisej.Web.Button();
            this.btnAceptar = new Wisej.Web.Button();
            this.line1 = new Wisej.Web.Line();
            this.label1 = new Wisej.Web.Label();
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
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.AutoSize = false;
            this.txtEmailUsuario.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtEmailUsuario.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtEmailUsuario.CssStyle = "border-radius: 10px;\r\nplaceholder:\"Email o Username\";";
            this.txtEmailUsuario.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailUsuario.ForeColor = System.Drawing.Color.White;
            this.txtEmailUsuario.Location = new System.Drawing.Point(30, 124);
            this.txtEmailUsuario.Margin = new Wisej.Web.Padding(0);
            this.txtEmailUsuario.MaxLength = 60;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtEmailUsuario.Size = new System.Drawing.Size(345, 37);
            this.txtEmailUsuario.TabIndex = 0;
            this.txtEmailUsuario.Watermark = "Email o Username";
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = false;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtPassword.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(30, 188);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(345, 37);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Watermark = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblError.Location = new System.Drawing.Point(30, 87);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblError.Size = new System.Drawing.Size(345, 25);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Mesaje de error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.line1);
            this.pnlContent.Controls.Add(this.lblError);
            this.pnlContent.Controls.Add(this.btnAceptar);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.lklcontraseña);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.txtEmailUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(407, 457);
            this.pnlContent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingresar";
            // 
            // lklcontraseña
            // 
            this.lklcontraseña.AutoSize = true;
            this.lklcontraseña.Font = new System.Drawing.Font("default, Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lklcontraseña.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lklcontraseña.Location = new System.Drawing.Point(30, 228);
            this.lklcontraseña.Margin = new Wisej.Web.Padding(0);
            this.lklcontraseña.Name = "lklcontraseña";
            this.lklcontraseña.Size = new System.Drawing.Size(125, 15);
            this.lklcontraseña.TabIndex = 12;
            this.lklcontraseña.Text = "¿ Olvide mi contrase;a ?";
            this.lklcontraseña.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.lklcontraseña_LinkClicked);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(363, 13);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnAceptar.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAceptar.Location = new System.Drawing.Point(65, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(277, 49);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Iniciar Sesion";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(45, 369);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(316, 10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = Wisej.Web.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("defaultBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label1.Location = new System.Drawing.Point(151, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Crear Cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // winLogin
            // 
            this.ClientSize = new System.Drawing.Size(407, 457);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "winLogin";
            this.Text = "winLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblError;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtEmailUsuario;
        private Wisej.Web.LinkLabel lklcontraseña;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.Label label1;
        private Wisej.Web.Line line1;
    }
}