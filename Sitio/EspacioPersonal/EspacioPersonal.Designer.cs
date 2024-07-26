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
            this.planificacion = new Wisej.Web.TabPage();
            this.realizados = new Wisej.Web.TabPage();
            this.nuevo = new Wisej.Web.TabPage();
            this.btnCrearViaje = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.pnlSuperiro.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.FromName("@window");
            this.pbUsuario.CssStyle = "\r\n  border-radius: 25%";
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
            this.lblUsuarioNombre.Size = new System.Drawing.Size(104, 18);
            this.lblUsuarioNombre.TabIndex = 2;
            this.lblUsuarioNombre.Text = "Nombre usuario";
            this.lblUsuarioNombre.Click += new System.EventHandler(this.lblUsuarioNombre_Click);
            // 
            // pnlSuperiro
            // 
            this.pnlSuperiro.BackColor = System.Drawing.Color.FromName("@menu");
            this.pnlSuperiro.Controls.Add(this.btnCrearViaje);
            this.pnlSuperiro.Controls.Add(this.btnRegistro);
            this.pnlSuperiro.Controls.Add(this.lblUsuarioNombre);
            this.pnlSuperiro.Controls.Add(this.pbUsuario);
            this.pnlSuperiro.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSuperiro.HeaderBackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.pnlSuperiro.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiro.Name = "pnlSuperiro";
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
            this.pnlContent.Size = new System.Drawing.Size(452, 595);
            this.pnlContent.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.planificacion);
            this.tabControl1.Controls.Add(this.realizados);
            this.tabControl1.Controls.Add(this.nuevo);
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("defaultBold, Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new Wisej.Web.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(422, 565);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new Wisej.Web.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // planificacion
            // 
            this.planificacion.Location = new System.Drawing.Point(1, 40);
            this.planificacion.Name = "planificacion";
            this.planificacion.Padding = new Wisej.Web.Padding(10);
            this.planificacion.Size = new System.Drawing.Size(420, 524);
            this.planificacion.Text = "En planificacion";
            // 
            // realizados
            // 
            this.realizados.Location = new System.Drawing.Point(1, 40);
            this.realizados.Name = "realizados";
            this.realizados.Size = new System.Drawing.Size(420, 524);
            this.realizados.Text = "Realizados";
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(1, 40);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(420, 524);
            this.nuevo.TabBackColor = System.Drawing.Color.FromName("@buttonHighlight");
            this.nuevo.TabForeColor = System.Drawing.Color.FromName("@buttonText");
            this.nuevo.Text = "Nuevo Viaje";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnCrearViaje.BackColor = System.Drawing.Color.FromName("@tabText");
            this.btnCrearViaje.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCrearViaje.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCrearViaje.Location = new System.Drawing.Point(173, 9);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(78, 33);
            this.btnCrearViaje.TabIndex = 6;
            this.btnCrearViaje.Text = "Crear Viaje";
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
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
        private Wisej.Web.TabPage planificacion;
        private Wisej.Web.TabPage realizados;
        private Wisej.Web.TabPage nuevo;
        private Wisej.Web.Button btnCrearViaje;
    }
}
