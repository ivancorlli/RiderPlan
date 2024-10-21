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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnlContent = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.htmlPresentaicon = new Wisej.Web.HtmlPanel();
            this.pnlHeather = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.btnRegistro = new Wisej.Web.Button();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.pnlHeather);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.ForeColor = System.Drawing.Color.Transparent;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new Wisej.Web.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(900, 630);
            this.pnlContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.htmlPresentaicon);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new Wisej.Web.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(900, 581);
            this.panel1.TabIndex = 1;
            // 
            // htmlPresentaicon
            // 
            this.htmlPresentaicon.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPresentaicon.Focusable = false;
            this.htmlPresentaicon.HtmlSource = "Resource\\lib\\html\\paginaIngreso.html";
            this.htmlPresentaicon.Location = new System.Drawing.Point(0, 0);
            this.htmlPresentaicon.Name = "htmlPresentaicon";
            this.htmlPresentaicon.Size = new System.Drawing.Size(900, 581);
            this.htmlPresentaicon.TabIndex = 0;
            this.htmlPresentaicon.TabStop = false;
            // 
            // pnlHeather
            // 
            this.pnlHeather.BackColor = System.Drawing.Color.FromArgb(122, 122, 122);
            this.pnlHeather.Controls.Add(this.label1);
            this.pnlHeather.Controls.Add(this.label2);
            this.pnlHeather.Controls.Add(this.btnRegistro);
            this.pnlHeather.Dock = Wisej.Web.DockStyle.Top;
            this.pnlHeather.HeaderForeColor = System.Drawing.Color.Transparent;
            this.pnlHeather.Location = new System.Drawing.Point(0, 0);
            this.pnlHeather.Name = "pnlHeather";
            this.pnlHeather.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlHeather.ResponsiveProfiles"))));
            this.pnlHeather.Size = new System.Drawing.Size(900, 49);
            this.pnlHeather.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = Wisej.Web.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label1.Location = new System.Drawing.Point(723, 15);
            this.label1.Name = "label1";
            this.label1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label1.ResponsiveProfiles"))));
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnRegistro.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistro.Location = new System.Drawing.Point(773, 7);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnRegistro.ResponsiveProfiles"))));
            this.btnRegistro.Size = new System.Drawing.Size(100, 33);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContent);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Inicio";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Size = new System.Drawing.Size(900, 630);
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHeather.ResumeLayout(false);
            this.pnlHeather.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlHeather;
        private Wisej.Web.Button btnRegistro;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.HtmlPanel htmlPresentaicon;
    }
}
