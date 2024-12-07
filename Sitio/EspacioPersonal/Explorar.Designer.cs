namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class Explorar
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

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorar));
            this.panel1 = new Wisej.Web.Panel();
            this.pnlViajes = new Wisej.Web.FlowLayoutPanel();
            this.pnlSearch = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.pnlInput = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.button3 = new Wisej.Web.Button();
            this.txtDestino = new Wisej.Web.TextBox();
            this.txtOrigen = new Wisej.Web.TextBox();
            this.htmlLoader = new Wisej.Web.HtmlPanel();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.htmlLoader);
            this.panel1.Controls.Add(this.pnlViajes);
            this.panel1.Controls.Add(this.pnlSearch);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.panel1.Size = new System.Drawing.Size(502, 498);
            this.panel1.TabIndex = 0;
            // 
            // pnlViajes
            // 
            this.pnlViajes.AutoScroll = true;
            this.pnlViajes.AutoSize = true;
            this.pnlViajes.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlViajes.Location = new System.Drawing.Point(0, 116);
            this.pnlViajes.Margin = new Wisej.Web.Padding(3, 15, 3, 15);
            this.pnlViajes.Name = "pnlViajes";
            this.pnlViajes.Padding = new Wisej.Web.Padding(30);
            this.pnlViajes.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.pnlViajes.Size = new System.Drawing.Size(502, 382);
            this.pnlViajes.TabIndex = 1;
            this.pnlViajes.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.pnlInput);
            this.pnlSearch.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(502, 116);
            this.pnlSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Margin = new Wisej.Web.Padding(15, 3, 15, 3);
            this.label2.Name = "label2";
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles"))));
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles1"))));
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles2"))));
            this.label2.Size = new System.Drawing.Size(384, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encuentra Tu Próxima Aventura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.pnlInput.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.button3);
            this.pnlInput.Controls.Add(this.txtDestino);
            this.pnlInput.Controls.Add(this.txtOrigen);
            this.pnlInput.CssStyle = "\r\n  \r\n  border-radius:12px;";
            this.pnlInput.Location = new System.Drawing.Point(118, 63);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new Wisej.Web.Padding(2);
            this.pnlInput.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.pnlInput.Size = new System.Drawing.Size(267, 35);
            this.pnlInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("default, Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@control");
            this.label1.Location = new System.Drawing.Point(107, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.CssStyle = "\r\n  border-radius:35%;";
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button3.ImageSource = "Resource\\lib\\iconos\\search-interface-symbol.png";
            this.button3.Location = new System.Drawing.Point(226, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 28);
            this.button3.TabIndex = 39;
            this.button3.ToolTipText = "Buscar";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.AutoSize = false;
            this.txtDestino.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtDestino.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtDestino.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.txtDestino.Location = new System.Drawing.Point(125, 3);
            this.txtDestino.MaxLength = 60;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtDestino.ResponsiveProfiles"))));
            this.txtDestino.Size = new System.Drawing.Size(92, 28);
            this.txtDestino.TabIndex = 3;
            this.txtDestino.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.txtDestino.Watermark = "Destino";
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoSize = false;
            this.txtOrigen.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.txtOrigen.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtOrigen.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.txtOrigen.Location = new System.Drawing.Point(11, 3);
            this.txtOrigen.MaxLength = 60;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtOrigen.ResponsiveProfiles"))));
            this.txtOrigen.Size = new System.Drawing.Size(92, 28);
            this.txtOrigen.TabIndex = 2;
            this.txtOrigen.Watermark = "Origen";
            this.txtOrigen.TextChanged += new System.EventHandler(this.txtOrigen_TextChanged);
            // 
            // htmlLoader
            // 
            this.htmlLoader.Dock = Wisej.Web.DockStyle.Top;
            this.htmlLoader.Focusable = false;
            this.htmlLoader.HtmlSource = "Resource\\lib\\html\\LoaderSkeleton.html";
            this.htmlLoader.Location = new System.Drawing.Point(0, 116);
            this.htmlLoader.Name = "htmlLoader";
            this.htmlLoader.Padding = new Wisej.Web.Padding(10);
            this.htmlLoader.Size = new System.Drawing.Size(502, 100);
            this.htmlLoader.TabIndex = 2;
            this.htmlLoader.TabStop = false;
            // 
            // Explorar
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Explorar";
            this.Size = new System.Drawing.Size(502, 498);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel pnlSearch;
        private Wisej.Web.FlowLayoutPanel pnlViajes;
        private Wisej.Web.Panel pnlInput;
        private Wisej.Web.TextBox txtDestino;
        private Wisej.Web.TextBox txtOrigen;
        private Wisej.Web.Button button3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label1;
        private Wisej.Web.HtmlPanel htmlLoader;
    }
}
