namespace RaiderPlan.Sitio.Inicio
{
    partial class winRecuperaCuenta
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
            this.pnlContent = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.btnAceptar = new Wisej.Web.Button();
            this.lblError = new Wisej.Web.Label();
            this.txtEmailUsuario = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.Cancelar = new Wisej.Web.Button();
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.btnAceptar);
            this.pnlContent.Controls.Add(this.lblError);
            this.pnlContent.Controls.Add(this.txtEmailUsuario);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(400, 316);
            this.pnlContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = Wisej.Web.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("defaultBold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label1.Location = new System.Drawing.Point(163, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "cancelar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnAceptar.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAceptar.Location = new System.Drawing.Point(88, 218);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(212, 39);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Recuperar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(32, 80);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblError.Size = new System.Drawing.Size(345, 40);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "Ingresa el correo electronico con el que te registraste. Te enviaremos un codigo " +
    "de recuperacion";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.AutoSize = false;
            this.txtEmailUsuario.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtEmailUsuario.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtEmailUsuario.CssStyle = "border-radius: 10px;\r\n";
            this.txtEmailUsuario.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailUsuario.ForeColor = System.Drawing.Color.White;
            this.txtEmailUsuario.Location = new System.Drawing.Point(32, 144);
            this.txtEmailUsuario.Margin = new Wisej.Web.Padding(0);
            this.txtEmailUsuario.MaxLength = 60;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtEmailUsuario.Size = new System.Drawing.Size(345, 37);
            this.txtEmailUsuario.TabIndex = 16;
            this.txtEmailUsuario.Watermark = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Recuperar";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(345, 13);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.AllowHtml = true;
            this.errorProvider1.BlinkAnimation = Wisej.Web.ErrorAnimationType.Bounce;
            this.errorProvider1.BlinkRate = 1;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.IconPadding = 2;
            // 
            // winRecuperaCuenta
            // 
            this.ClientSize = new System.Drawing.Size(400, 316);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.CssStyle = "border-radius:20px;";
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "winRecuperaCuenta";
            this.Text = "winRecuperaCuenta";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.TextBox txtEmailUsuario;
        private Wisej.Web.Label lblError;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.ErrorProvider errorProvider1;
    }
}