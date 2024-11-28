namespace RaiderPlan.Sitio.Inicio
{
    partial class winComentario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winComentario));
            this.pnlContent = new Wisej.Web.Panel();
            this.textBox3 = new Wisej.Web.TextBox();
            this.label3 = new Wisej.Web.Label();
            this.textBox2 = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.textBox1 = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.btnCancelar = new Wisej.Web.Button();
            this.btnAgregar = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.txtTitulo = new Wisej.Web.Label();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.pnlContent.Controls.Add(this.textBox3);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.textBox2);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.textBox1);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 47);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(391, 296);
            this.pnlContent.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 210);
            this.textBox3.MaxLength = 250;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(343, 67);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comentario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 108);
            this.textBox2.MaxLength = 250;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 67);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado de carretera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumo de combustible";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 30);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(391, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancelar.Location = new System.Drawing.Point(100, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 25);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.BackgroundImage = global::RaiderPlan.Properties.Resources.iconoOK;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAgregar.Location = new System.Drawing.Point(25, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 47);
            this.panel2.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("defaultBold, Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitulo.Location = new System.Drawing.Point(25, 10);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(61, 25);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Titulo";
            // 
            // winComentario
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(391, 388);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromName("@control");
            this.Movable = false;
            this.Name = "winComentario";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnCancelar;
        private Wisej.Web.Button btnAgregar;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label txtTitulo;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox textBox1;
    }
}