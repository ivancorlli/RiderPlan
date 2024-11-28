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
            this.bntCancelar = new Wisej.Web.Button();
            this.btnAgregar = new Wisej.Web.Button();
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
            this.htmlPanel1.ScrollBars = Wisej.Web.ScrollBars.None;
            this.htmlPanel1.Size = new System.Drawing.Size(891, 559);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.Appear += new System.EventHandler(this.htmlPanel1_Appear);
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.AutoSize = true;
            this.pnlCoordenadas.BackColor = System.Drawing.Color.Transparent;
            this.pnlCoordenadas.Controls.Add(this.bntCancelar);
            this.pnlCoordenadas.Controls.Add(this.btnAgregar);
            this.pnlCoordenadas.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlCoordenadas.Location = new System.Drawing.Point(0, 516);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(891, 43);
            this.pnlCoordenadas.TabIndex = 1;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.bntCancelar.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.bntCancelar.Location = new System.Drawing.Point(157, 10);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(100, 27);
            this.bntCancelar.TabIndex = 5;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnAgregar.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.btnAgregar.Location = new System.Drawing.Point(16, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 27);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Viajes
            // 
            this.AutoSize = true;
            this.Controls.Add(this.pnlContent);
            this.Name = "Viajes";
            this.Size = new System.Drawing.Size(891, 559);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlCoordenadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Panel pnlCoordenadas;
        private Wisej.Web.Button btnAgregar;
        private Wisej.Web.Button bntCancelar;
    }
}
