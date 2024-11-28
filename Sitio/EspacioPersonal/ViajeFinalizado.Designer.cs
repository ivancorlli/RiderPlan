namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajeFinalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajeFinalizado));
            this.pnlContent = new Wisej.Web.Panel();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.pnlCoordenadas = new Wisej.Web.Panel();
            this.bntCancelar = new Wisej.Web.Button();
            this.btnTrayectos = new Wisej.Web.Button();
            this.btnDescargar = new Wisej.Web.Button();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.pnlContent.SuspendLayout();
            this.pnlCoordenadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlCoordenadas);
            this.pnlContent.Controls.Add(this.htmlPanel1);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(399, 559);
            this.pnlContent.TabIndex = 0;
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "Resource\\mapas\\paginamapa2.html";
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(399, 559);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.Appear += new System.EventHandler(this.htmlPanel1_Appear);
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.BackColor = System.Drawing.Color.Transparent;
            this.pnlCoordenadas.Controls.Add(this.bntCancelar);
            this.pnlCoordenadas.Controls.Add(this.btnTrayectos);
            this.pnlCoordenadas.Controls.Add(this.btnDescargar);
            this.pnlCoordenadas.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlCoordenadas.Location = new System.Drawing.Point(0, 516);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(399, 43);
            this.pnlCoordenadas.TabIndex = 1;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.bntCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bntCancelar.Location = new System.Drawing.Point(8, 11);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(50, 25);
            this.bntCancelar.TabIndex = 7;
            this.bntCancelar.Text = "Salir";
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnTrayectos
            // 
            this.btnTrayectos.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnTrayectos.BackColor = System.Drawing.Color.Plum;
            this.btnTrayectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnTrayectos.Location = new System.Drawing.Point(141, 11);
            this.btnTrayectos.Name = "btnTrayectos";
            this.btnTrayectos.Size = new System.Drawing.Size(71, 25);
            this.btnTrayectos.TabIndex = 6;
            this.btnTrayectos.Text = "Trayectos";
            this.btnTrayectos.Click += new System.EventHandler(this.btnTrayectos_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnDescargar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDescargar.Location = new System.Drawing.Point(64, 11);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(71, 25);
            this.btnDescargar.TabIndex = 5;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // ViajeFinalizado
            // 
            this.Controls.Add(this.pnlContent);
            this.Name = "ViajeFinalizado";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Size = new System.Drawing.Size(399, 559);
            this.pnlContent.ResumeLayout(false);
            this.pnlCoordenadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Panel pnlCoordenadas;
        private Wisej.Web.Button btnDescargar;
        private Wisej.Web.Button btnTrayectos;
        private Wisej.Web.Button bntCancelar;
    }
}
