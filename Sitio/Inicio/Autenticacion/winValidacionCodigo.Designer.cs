namespace RaiderPlan.Sitio.Inicio
{
    partial class winValidacionCodigo
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
            this.pnlBotones = new Wisej.Web.Panel();
            this.btnCancelar = new Wisej.Web.Button();
            this.btnAceptar = new Wisej.Web.Button();
            this.lblEmailUsuario = new Wisej.Web.Label();
            this.pnlContent = new Wisej.Web.Panel();
            this.lblValidacion = new Wisej.Web.Label();
            this.txtCodigoValidacion = new Wisej.Web.TextBox();
            this.lblTitulo = new Wisej.Web.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 121);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(409, 50);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 27);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailUsuario.Location = new System.Drawing.Point(13, 32);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(529, 21);
            this.lblEmailUsuario.TabIndex = 1;
            this.lblEmailUsuario.Text = "Emial/Usuario";
            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlContent.Controls.Add(this.lblValidacion);
            this.pnlContent.Controls.Add(this.txtCodigoValidacion);
            this.pnlContent.Controls.Add(this.lblTitulo);
            this.pnlContent.Controls.Add(this.lblEmailUsuario);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(409, 121);
            this.pnlContent.TabIndex = 2;
            // 
            // lblValidacion
            // 
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValidacion.Location = new System.Drawing.Point(122, 49);
            this.lblValidacion.Name = "lblValidacion";
            this.lblValidacion.Size = new System.Drawing.Size(165, 20);
            this.lblValidacion.TabIndex = 4;
            this.lblValidacion.Text = "Codigo de validacion";
            // 
            // txtCodigoValidacion
            // 
            this.txtCodigoValidacion.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtCodigoValidacion.Font = new System.Drawing.Font("default, Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoValidacion.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtCodigoValidacion.Location = new System.Drawing.Point(122, 73);
            this.txtCodigoValidacion.MaxLength = 4;
            this.txtCodigoValidacion.Name = "txtCodigoValidacion";
            this.txtCodigoValidacion.PasswordChar = '*';
            this.txtCodigoValidacion.Size = new System.Drawing.Size(165, 25);
            this.txtCodigoValidacion.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromName("@windowText");
            this.lblTitulo.Dock = Wisej.Web.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(407, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "   Ingrese el codigo ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // winValidacionCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 171);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "winValidacionCodigo";
            this.Text = "Window";
            this.pnlBotones.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlBotones;
        private Wisej.Web.Button btnCancelar;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.Label lblEmailUsuario;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblValidacion;
        private Wisej.Web.TextBox txtCodigoValidacion;
        private Wisej.Web.Label lblTitulo;
    }
}