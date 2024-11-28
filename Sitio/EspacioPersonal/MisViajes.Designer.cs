namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class MisViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisViajes));
            this.panel1 = new Wisej.Web.Panel();
            this.pnlViajes = new Wisej.Web.FlowLayoutPanel();
            this.pnlSinViajes = new Wisej.Web.Panel();
            this.btnCrearViaje = new Wisej.Web.Button();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.pnlViajeActual = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.pnlSinViajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlViajes);
            this.panel1.Controls.Add(this.pnlSinViajes);
            this.panel1.Controls.Add(this.pnlViajeActual);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 500);
            this.panel1.TabIndex = 0;
            // 
            // pnlViajes
            // 
            this.pnlViajes.AutoScroll = true;
            this.pnlViajes.AutoSize = true;
            this.pnlViajes.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlViajes.Location = new System.Drawing.Point(0, 317);
            this.pnlViajes.Margin = new Wisej.Web.Padding(10);
            this.pnlViajes.Name = "pnlViajes";
            this.pnlViajes.Padding = new Wisej.Web.Padding(10);
            this.pnlViajes.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.pnlViajes.Size = new System.Drawing.Size(504, 183);
            this.pnlViajes.TabIndex = 0;
            // 
            // pnlSinViajes
            // 
            this.pnlSinViajes.Controls.Add(this.btnCrearViaje);
            this.pnlSinViajes.Controls.Add(this.htmlPanel1);
            this.pnlSinViajes.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSinViajes.Location = new System.Drawing.Point(0, 31);
            this.pnlSinViajes.Name = "pnlSinViajes";
            this.pnlSinViajes.Size = new System.Drawing.Size(504, 286);
            this.pnlSinViajes.TabIndex = 2;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.btnCrearViaje.BackColor = System.Drawing.Color.FromName("@tabText");
            this.btnCrearViaje.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCrearViaje.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCrearViaje.Location = new System.Drawing.Point(177, 234);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(151, 44);
            this.btnCrearViaje.TabIndex = 7;
            this.btnCrearViaje.Text = "Crear un nuevo viaje";
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Top;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.Html = resources.GetString("htmlPanel1.Html");
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.ScrollBars = Wisej.Web.ScrollBars.None;
            this.htmlPanel1.Size = new System.Drawing.Size(504, 228);
            this.htmlPanel1.TabIndex = 1;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel1_ElementClick);
            // 
            // pnlViajeActual
            // 
            this.pnlViajeActual.Dock = Wisej.Web.DockStyle.Top;
            this.pnlViajeActual.Location = new System.Drawing.Point(0, 0);
            this.pnlViajeActual.Name = "pnlViajeActual";
            this.pnlViajeActual.Size = new System.Drawing.Size(504, 31);
            this.pnlViajeActual.TabIndex = 1;
            // 
            // MisViajes
            // 
            this.Controls.Add(this.panel1);
            this.Name = "MisViajes";
            this.Size = new System.Drawing.Size(504, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSinViajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.FlowLayoutPanel pnlViajes;
        private Wisej.Web.Panel pnlViajeActual;
        private Wisej.Web.Panel pnlSinViajes;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Button btnCrearViaje;
    }
}
