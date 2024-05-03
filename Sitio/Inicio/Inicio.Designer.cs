namespace RaiderPlan.Sitio.Inicio
{
    partial class Inicio
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
            this.pnlHeather = new Wisej.Web.Panel();
            this.btnRegistro = new Wisej.Web.Button();
            this.btnlogin = new Wisej.Web.Button();
            this.pnlFooter = new Wisej.Web.Panel();
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlHeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeather
            // 
            this.pnlHeather.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.pnlHeather.Controls.Add(this.btnRegistro);
            this.pnlHeather.Controls.Add(this.btnlogin);
            this.pnlHeather.Dock = Wisej.Web.DockStyle.Top;
            this.pnlHeather.Location = new System.Drawing.Point(0, 0);
            this.pnlHeather.Name = "pnlHeather";
            this.pnlHeather.Size = new System.Drawing.Size(900, 46);
            this.pnlHeather.TabIndex = 0;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnRegistro.BackColor = System.Drawing.Color.FromName("@switchOn");
            this.btnRegistro.Location = new System.Drawing.Point(782, 10);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(100, 27);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnlogin.BackColor = System.Drawing.Color.FromName("@switchOn");
            this.btnlogin.Location = new System.Drawing.Point(673, 10);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 27);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Acceso";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            this.pnlFooter.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 584);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 46);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.BackgroundImage = global::RaiderPlan.Properties.Resources.saludo_motero_vss;
            this.pnlContent.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 46);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(900, 538);
            this.pnlContent.TabIndex = 2;
            // 
            // Inicio
            // 
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeather);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(900, 630);
            this.pnlHeather.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlHeather;
        private Wisej.Web.Button btnRegistro;
        private Wisej.Web.Button btnlogin;
        private Wisej.Web.Panel pnlFooter;
        private Wisej.Web.Panel pnlContent;
    }
}
