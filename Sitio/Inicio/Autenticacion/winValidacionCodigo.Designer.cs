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
            this.pnlContent = new Wisej.Web.Panel();
            this.lblError = new Wisej.Web.Label();
            this.btnAceptar = new Wisej.Web.Button();
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.txtCodigoValidacion = new Wisej.Web.TextBox();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.pnlContent.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlContent.Controls.Add(this.lblError);
            this.pnlContent.Controls.Add(this.btnAceptar);
            this.pnlContent.Controls.Add(this.Cancelar);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtCodigoValidacion);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(397, 261);
            this.pnlContent.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(29, 70);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.lblError.Size = new System.Drawing.Size(345, 40);
            this.lblError.TabIndex = 3005;
            this.lblError.Text = "Ingresa el codigo que enviamos a tu correo electronico.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnAceptar.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAceptar.Location = new System.Drawing.Point(73, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(228, 44);
            this.btnAceptar.TabIndex = 3004;
            this.btnAceptar.Text = "Verificar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@toolbarText");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(352, 13);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 17;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Verificar";
            // 
            // txtCodigoValidacion
            // 
            this.txtCodigoValidacion.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtCodigoValidacion.AutoSize = false;
            this.txtCodigoValidacion.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtCodigoValidacion.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtCodigoValidacion.CssStyle = "border-radius: 10px;";
            this.txtCodigoValidacion.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoValidacion.ForeColor = System.Drawing.Color.White;
            this.txtCodigoValidacion.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtCodigoValidacion.Location = new System.Drawing.Point(23, 125);
            this.txtCodigoValidacion.MaxLength = 4;
            this.txtCodigoValidacion.Name = "txtCodigoValidacion";
            this.txtCodigoValidacion.Padding = new Wisej.Web.Padding(10, 5, 10, 5);
            this.txtCodigoValidacion.PasswordChar = '*';
            this.txtCodigoValidacion.Size = new System.Drawing.Size(340, 42);
            this.txtCodigoValidacion.TabIndex = 3;
            this.txtCodigoValidacion.Watermark = "Codigo";
            // 
            // winValidacionCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "winValidacionCodigo";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Window";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.TextBox txtCodigoValidacion;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.Button btnAceptar;
        private Wisej.Web.Label lblError;
    }
}