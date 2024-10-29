namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class Eliminados
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
            this.panel1 = new Wisej.Web.Panel();
            this.pnlViajes = new Wisej.Web.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 24);
            this.panel1.TabIndex = 0;
            // 
            // pnlViajes
            // 
            this.pnlViajes.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlViajes.Location = new System.Drawing.Point(0, 24);
            this.pnlViajes.Name = "pnlViajes";
            this.pnlViajes.Size = new System.Drawing.Size(501, 477);
            this.pnlViajes.TabIndex = 1;
            // 
            // Eliminados
            // 
            this.Controls.Add(this.pnlViajes);
            this.Controls.Add(this.panel1);
            this.Name = "Eliminados";
            this.Size = new System.Drawing.Size(501, 501);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.FlowLayoutPanel pnlViajes;
    }
}
