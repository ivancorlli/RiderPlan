namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajeMapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajeMapa));
            this.pnlHeader = new Wisej.Web.Panel();
            this.lblTitulo = new Wisej.Web.Label();
            this.btnSalir = new Wisej.Web.Button();
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.btnSalir);
            this.pnlHeader.Dock = Wisej.Web.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new Wisej.Web.Padding(5);
            this.pnlHeader.Size = new System.Drawing.Size(502, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = Wisej.Web.Cursors.Hand;
            this.lblTitulo.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(50, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblTitulo.ResponsiveProfiles"))));
            this.lblTitulo.Size = new System.Drawing.Size(62, 30);
            this.lblTitulo.TabIndex = 3002;
            this.lblTitulo.Text = "Viaje";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = Wisej.Web.AnchorStyles.Left;
            this.btnSalir.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.Font = new System.Drawing.Font("defaultBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnSalir.ResponsiveProfiles"))));
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "X";
            this.btnSalir.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(502, 345);
            this.pnlContent.TabIndex = 1;
            // 
            // ViajeMapa
            // 
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ViajeMapa";
            this.Size = new System.Drawing.Size(502, 400);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlHeader;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Button btnSalir;
        private Wisej.Web.Label lblTitulo;
    }
}
