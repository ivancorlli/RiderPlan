namespace RaiderPlan.Sitio.Inicio
{
    partial class winTrayectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winTrayectos));
            this.pnlContent = new Wisej.Web.Panel();
            this.listView1 = new Wisej.Web.ListView();
            this.nombre = new Wisej.Web.ColumnHeader();
            this.km = new Wisej.Web.ColumnHeader();
            this.timepo = new Wisej.Web.ColumnHeader();
            this.combustible = new Wisej.Web.ColumnHeader();
            this.estado = new Wisej.Web.ColumnHeader();
            this.comentario = new Wisej.Web.ColumnHeader();
            this.panel1 = new Wisej.Web.Panel();
            this.Cancelar = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.pnlContent.Controls.Add(this.listView1);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 45);
            this.pnlContent.Margin = new Wisej.Web.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new Wisej.Web.Padding(2);
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.Size = new System.Drawing.Size(608, 408);
            this.pnlContent.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.nombre,
            this.km,
            this.timepo,
            this.combustible,
            this.estado,
            this.comentario});
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.GridLines = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 404);
            this.listView1.TabIndex = 0;
            this.listView1.View = Wisej.Web.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.nombre.Name = "nombre";
            this.nombre.Text = "Nombre";
            this.nombre.Width = 120;
            // 
            // km
            // 
            this.km.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.km.Name = "km";
            this.km.Text = "KM";
            this.km.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.km.Width = 65;
            // 
            // timepo
            // 
            this.timepo.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.timepo.Name = "timepo";
            this.timepo.Text = "Tiempo Estimado";
            this.timepo.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.timepo.Width = 65;
            // 
            // combustible
            // 
            this.combustible.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.combustible.Name = "combustible";
            this.combustible.Text = "Consumo";
            this.combustible.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.combustible.Width = 125;
            // 
            // estado
            // 
            this.estado.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.estado.Name = "estado";
            this.estado.Text = "Estado Carretera";
            this.estado.Width = 120;
            // 
            // comentario
            // 
            this.comentario.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.comentario.Name = "comentario";
            this.comentario.Text = "Comentario";
            this.comentario.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 45);
            this.panel1.TabIndex = 0;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.Cancelar.Font = new System.Drawing.Font("default, Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cancelar.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.Cancelar.Location = new System.Drawing.Point(563, 9);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("Cancelar.ResponsiveProfiles"))));
            this.Cancelar.Size = new System.Drawing.Size(32, 27);
            this.Cancelar.TabIndex = 3004;
            this.Cancelar.Text = "X";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.label2.Cursor = Wisej.Web.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("defaultBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles"))));
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 3003;
            this.label2.Text = "Viaje Nombre";
            // 
            // winTrayectos
            // 
            this.ClientSize = new System.Drawing.Size(608, 453);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromName("@control");
            this.Location = new System.Drawing.Point(25, -359);
            this.Name = "winTrayectos";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ListView listView1;
        private Wisej.Web.ColumnHeader nombre;
        private Wisej.Web.ColumnHeader km;
        private Wisej.Web.ColumnHeader timepo;
        private Wisej.Web.ColumnHeader combustible;
        private Wisej.Web.ColumnHeader estado;
        private Wisej.Web.ColumnHeader comentario;
        private Wisej.Web.Button Cancelar;
        private Wisej.Web.Label label2;
    }
}