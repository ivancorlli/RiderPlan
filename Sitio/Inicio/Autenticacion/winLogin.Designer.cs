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
            this.lblEmailUsuario = new Wisej.Web.Label();
            this.lblPassword = new Wisej.Web.Label();
            this.lblTitulo = new Wisej.Web.Label();
            this.pnlMensaje = new Wisej.Web.Panel();
            this.lblError = new Wisej.Web.Label();
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlbotones = new Wisej.Web.Panel();
            this.lklcontraseña = new Wisej.Web.LinkLabel();
            this.line1 = new Wisej.Web.Line();
            this.Cancelar = new Wisej.Web.Button();
            this.btnAceptar = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlMensaje.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailUsuario.Location = new System.Drawing.Point(20, 63);
            this.txtEmailUsuario.MaxLength = 60;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(345, 22);
            this.txtEmailUsuario.TabIndex = 0;
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(20, 124);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(345, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Location = new System.Drawing.Point(20, 42);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(240, 15);
            this.lblEmailUsuario.TabIndex = 2;
            this.lblEmailUsuario.Text = "Ingrese su email o su nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Ingrese su password";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.lblTitulo.Dock = Wisej.Web.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("default, Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(399, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "INGRESAR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Controls.Add(this.lblError);
            this.pnlMensaje.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlMensaje.Location = new System.Drawing.Point(0, 157);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(399, 25);
            this.pnlMensaje.TabIndex = 10;
            this.pnlMensaje.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(255, 198, 198);
            this.lblError.Dock = Wisej.Web.DockStyle.Fill;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblError.Size = new System.Drawing.Size(399, 25);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Mesaje de error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlMensaje);
            this.pnlContent.Controls.Add(this.lblTitulo);
            this.pnlContent.Controls.Add(this.lblPassword);
            this.pnlContent.Controls.Add(this.lblEmailUsuario);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.txtEmailUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(399, 182);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlbotones
            // 
            this.pnlbotones.Controls.Add(this.lklcontraseña);
            this.pnlbotones.Controls.Add(this.line1);
            this.pnlbotones.Controls.Add(this.Cancelar);
            this.pnlbotones.Controls.Add(this.btnAceptar);
            this.pnlbotones.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlbotones.Location = new System.Drawing.Point(0, 188);
            this.pnlbotones.Name = "pnlbotones";
            this.pnlbotones.Size = new System.Drawing.Size(399, 85);
            this.pnlbotones.TabIndex = 1;
            // 
            // lklcontraseña
            // 
            this.lklcontraseña.AutoSize = true;
            this.lklcontraseña.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lklcontraseña.Location = new System.Drawing.Point(108, 56);
            this.lklcontraseña.Name = "lklcontraseña";
            this.lklcontraseña.Size = new System.Drawing.Size(169, 21);
            this.lklcontraseña.TabIndex = 12;
            this.lklcontraseña.Text = "¿Olvide me password?";
            // 
            // line1
            // 
            this.line1.LineColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.line1.LineSize = 2;
            this.line1.Location = new System.Drawing.Point(20, -5);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(345, 22);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.Location = new System.Drawing.Point(163, 17);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 27);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.Location = new System.Drawing.Point(20, 17);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 27);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // winLogin
            // 
            this.ClientSize = new System.Drawing.Size(399, 273);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.pnlbotones);
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border: 2px solid red;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "winLogin";
            this.Text = "winLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlMensaje.ResumeLayout(false);
            this.pnlMensaje.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlbotones.ResumeLayout(false);
            this.pnlbotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.ErrorProvider errorProvider1;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Panel pnlMensaje;
        private Wisej.Web.Label lblError;
        private Wisej.Web.Label lblTitulo;
        private Wisej.Web.Label lblPassword;
        private Wisej.Web.Label lblEmailUsuario;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtEmailUsuario;
        private Wisej.Web.Panel pnlbotones;
        private Wisej.Web.LinkLabel lklcontraseña;
        private Wisej.Web.Line line1;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.Button btnAceptar;
    }
}