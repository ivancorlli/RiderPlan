namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class Planificacion
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
            this.flpViajes = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flpViajes);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 264);
            this.panel1.TabIndex = 0;
            // 
            // flpViajes
            // 
            this.flpViajes.Dock = Wisej.Web.DockStyle.Fill;
            this.flpViajes.Location = new System.Drawing.Point(0, 0);
            this.flpViajes.Name = "flpViajes";
            this.flpViajes.Padding = new Wisej.Web.Padding(10);
            this.flpViajes.Size = new System.Drawing.Size(306, 264);
            this.flpViajes.TabIndex = 0;
            // 
            // Planificacion
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Planificacion";
            this.Size = new System.Drawing.Size(306, 264);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.FlowLayoutPanel flpViajes;
    }
}
