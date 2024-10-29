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
            this.panel1 = new Wisej.Web.Panel();
            this.pnlViajes = new Wisej.Web.FlowLayoutPanel();
            this.pnlViajeActual = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlViajes);
            this.panel1.Controls.Add(this.pnlViajeActual);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 500);
            this.panel1.TabIndex = 0;
            // 
            // pnlViajes
            // 
            this.pnlViajes.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlViajes.Location = new System.Drawing.Point(0, 31);
            this.pnlViajes.Name = "pnlViajes";
            this.pnlViajes.Padding = new Wisej.Web.Padding(10);
            this.pnlViajes.Size = new System.Drawing.Size(504, 469);
            this.pnlViajes.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.FlowLayoutPanel pnlViajes;
        private Wisej.Web.Panel pnlViajeActual;
    }
}
