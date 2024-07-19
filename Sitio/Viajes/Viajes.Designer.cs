namespace RaiderPlan.Sitio.Viajes
{
    partial class Viajes
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
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.pnlCoordenadas = new Wisej.Web.Panel();
            this.btnAgregar = new Wisej.Web.Button();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.pnlContent.SuspendLayout();
            this.pnlCoordenadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.htmlPanel1);
            this.pnlContent.Controls.Add(this.pnlCoordenadas);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(891, 559);
            this.pnlContent.TabIndex = 0;
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "Resource\\mapas\\paginamapa.html";
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(891, 516);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel1_ElementClick);
            this.htmlPanel1.Appear += new System.EventHandler(this.htmlPanel1_Appear);
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.BackColor = System.Drawing.Color.FromArgb(17, 255, 255, 255);
            this.pnlCoordenadas.Controls.Add(this.btnAgregar);
            this.pnlCoordenadas.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlCoordenadas.Location = new System.Drawing.Point(0, 516);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(891, 43);
            this.pnlCoordenadas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 27);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agergar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Viajes
            // 
            this.Controls.Add(this.pnlContent);
            this.Name = "Viajes";
            this.Size = new System.Drawing.Size(891, 559);
            this.pnlContent.ResumeLayout(false);
            this.pnlCoordenadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Panel pnlCoordenadas;
        private Wisej.Web.Button btnAgregar;
    }
}
