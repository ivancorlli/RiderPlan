namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class EspacioPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspacioPersonal));
            this.pbUsuario = new Wisej.Web.PictureBox();
            this.lblUsuarioNombre = new Wisej.Web.Label();
            this.pnlSuperiro = new Wisej.Web.Panel();
            this.btnRegistro = new Wisej.Web.Button();
            this.pnlContent = new Wisej.Web.Panel();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.tabPage3 = new Wisej.Web.TabPage();
            this.tabPage4 = new Wisej.Web.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.pnlSuperiro.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pbUsuario.CssStyle = "\r\n  border-radius: 50%";
            this.pbUsuario.Cursor = Wisej.Web.Cursors.Hand;
            this.pbUsuario.ImageSource = "Resource\\lib\\Imagenes\\iconousuario.png";
            this.pbUsuario.Location = new System.Drawing.Point(16, 9);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(36, 36);
            this.pbUsuario.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblUsuarioNombre.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.lblUsuarioNombre.Location = new System.Drawing.Point(63, 18);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblUsuarioNombre.ResponsiveProfiles"))));
            this.lblUsuarioNombre.Size = new System.Drawing.Size(104, 15);
            this.lblUsuarioNombre.TabIndex = 2;
            this.lblUsuarioNombre.Text = "Nombre usuario";
            this.lblUsuarioNombre.Click += new System.EventHandler(this.lblUsuarioNombre_Click);
            // 
            // pnlSuperiro
            // 
            this.pnlSuperiro.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.pnlSuperiro.BackColor = System.Drawing.Color.FromArgb(41, 0, 0, 0);
            this.pnlSuperiro.Controls.Add(this.btnRegistro);
            this.pnlSuperiro.Controls.Add(this.lblUsuarioNombre);
            this.pnlSuperiro.Controls.Add(this.pbUsuario);
            this.pnlSuperiro.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSuperiro.HeaderBackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.pnlSuperiro.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiro.Name = "pnlSuperiro";
            this.pnlSuperiro.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlSuperiro.ResponsiveProfiles"))));
            this.pnlSuperiro.ShowCloseButton = false;
            this.pnlSuperiro.Size = new System.Drawing.Size(452, 51);
            this.pnlSuperiro.TabIndex = 0;
            this.pnlSuperiro.Text = "menu";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnRegistro.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistro.Location = new System.Drawing.Point(384, 9);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnRegistro.ResponsiveProfiles"))));
            this.btnRegistro.Size = new System.Drawing.Size(55, 33);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Salir";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.pnlContent.HeaderBackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.pnlContent.HeaderSize = 40;
            this.pnlContent.Location = new System.Drawing.Point(0, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new Wisej.Web.Padding(15);
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles"))));
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles1"))));
            this.pnlContent.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlContent.ResponsiveProfiles2"))));
            this.pnlContent.Size = new System.Drawing.Size(452, 595);
            this.pnlContent.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new Wisej.Web.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabControl1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabControl1.ResponsiveProfiles"))));
            this.tabControl1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabControl1.ResponsiveProfiles1"))));
            this.tabControl1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabControl1.ResponsiveProfiles2"))));
            this.tabControl1.Size = new System.Drawing.Size(422, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(1, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage1.ResponsiveProfiles"))));
            this.tabPage1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage1.ResponsiveProfiles1"))));
            this.tabPage1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage1.ResponsiveProfiles2"))));
            this.tabPage1.Size = new System.Drawing.Size(420, 529);
            this.tabPage1.Text = "Todos los viajes";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(1, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage2.ResponsiveProfiles"))));
            this.tabPage2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage2.ResponsiveProfiles1"))));
            this.tabPage2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage2.ResponsiveProfiles2"))));
            this.tabPage2.Size = new System.Drawing.Size(420, 529);
            this.tabPage2.Text = "En planificacion";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(1, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage3.ResponsiveProfiles"))));
            this.tabPage3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage3.ResponsiveProfiles1"))));
            this.tabPage3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage3.ResponsiveProfiles2"))));
            this.tabPage3.Size = new System.Drawing.Size(420, 529);
            this.tabPage3.Text = "Realizados";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(1, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage4.ResponsiveProfiles"))));
            this.tabPage4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage4.ResponsiveProfiles1"))));
            this.tabPage4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabPage4.ResponsiveProfiles2"))));
            this.tabPage4.Size = new System.Drawing.Size(420, 529);
            this.tabPage4.Text = "Nuevo Viaje";
            // 
            // EspacioPersonal
            // 
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSuperiro);
            this.Name = "EspacioPersonal";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Size = new System.Drawing.Size(452, 646);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.pnlSuperiro.ResumeLayout(false);
            this.pnlSuperiro.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PictureBox pbUsuario;
        private Wisej.Web.Label lblUsuarioNombre;
        private Wisej.Web.Panel pnlSuperiro;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Button btnRegistro;
        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.TabPage tabPage2;
        private Wisej.Web.TabPage tabPage3;
        private Wisej.Web.TabPage tabPage4;
    }
}
