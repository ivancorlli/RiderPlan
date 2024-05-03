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
            this.pnlSuperiro = new Wisej.Web.Panel();
            this.lblUsuarioNombre = new Wisej.Web.Label();
            this.pbUsuario = new Wisej.Web.PictureBox();
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlMenu = new Wisej.Web.Panel();
            this.pbPerfil = new Wisej.Web.PictureBox();
            this.pbMapa1 = new Wisej.Web.PictureBox();
            this.btnSalir = new Wisej.Web.Button();
            this.pnlSuperiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperiro
            // 
            this.pnlSuperiro.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.pnlSuperiro.BackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.pnlSuperiro.Controls.Add(this.btnSalir);
            this.pnlSuperiro.Controls.Add(this.lblUsuarioNombre);
            this.pnlSuperiro.Controls.Add(this.pbUsuario);
            this.pnlSuperiro.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSuperiro.HeaderBackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.pnlSuperiro.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiro.Name = "pnlSuperiro";
            this.pnlSuperiro.ShowCloseButton = false;
            this.pnlSuperiro.Size = new System.Drawing.Size(1002, 51);
            this.pnlSuperiro.TabIndex = 0;
            this.pnlSuperiro.Text = "menu";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblUsuarioNombre.Location = new System.Drawing.Point(76, 18);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(97, 15);
            this.lblUsuarioNombre.TabIndex = 2;
            this.lblUsuarioNombre.Text = "Nombre usuario";
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pbUsuario.CssStyle = "\r\n  border-radius: 50%";
            this.pbUsuario.ImageSource = "Resource\\lib\\Imagenes\\iconousuario.png";
            this.pbUsuario.Location = new System.Drawing.Point(27, 7);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(36, 36);
            this.pbUsuario.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlMenu);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.HeaderSize = 40;
            this.pnlContent.Location = new System.Drawing.Point(0, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1002, 595);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlMenu.Collapsed = true;
            this.pnlMenu.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.pnlMenu.Controls.Add(this.pbMapa1);
            this.pnlMenu.Controls.Add(this.pbPerfil);
            this.pnlMenu.Dock = Wisej.Web.DockStyle.Left;
            this.pnlMenu.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.pnlMenu.HeaderBackColor = System.Drawing.Color.FromName("@controlText");
            this.pnlMenu.HeaderPosition = Wisej.Web.HeaderPosition.Left;
            this.pnlMenu.HeaderSize = 20;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.RestoreBounds = new System.Drawing.Rectangle(0, 0, 87, 595);
            this.pnlMenu.Selectable = true;
            this.pnlMenu.ShowHeader = true;
            this.pnlMenu.Size = new System.Drawing.Size(22, 595);
            this.pnlMenu.TabIndex = 2;
            this.pnlMenu.Text = "Menú";
            // 
            // pbPerfil
            // 
            this.pbPerfil.BackgroundImage = global::RaiderPlan.Properties.Resources.iconousuario;
            this.pbPerfil.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.pbPerfil.Location = new System.Drawing.Point(14, 14);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(48, 46);
            this.pbPerfil.ToolTipText = "Editar Perfil";
            this.pbPerfil.Click += new System.EventHandler(this.pbPerfil_Click);
            // 
            // pbMapa1
            // 
            this.pbMapa1.BackgroundImage = global::RaiderPlan.Properties.Resources.mapa;
            this.pbMapa1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.pbMapa1.Location = new System.Drawing.Point(14, 79);
            this.pbMapa1.Name = "pbMapa1";
            this.pbMapa1.Size = new System.Drawing.Size(48, 46);
            this.pbMapa1.ToolTipText = "Editar Perfil";
            this.pbMapa1.Click += new System.EventHandler(this.pbMapa1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(867, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EspacioPersonal
            // 
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSuperiro);
            this.Name = "EspacioPersonal";
            this.Size = new System.Drawing.Size(1002, 646);
            this.pnlSuperiro.ResumeLayout(false);
            this.pnlSuperiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlSuperiro;
        private Wisej.Web.PictureBox pbUsuario;
        private Wisej.Web.Label lblUsuarioNombre;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Panel pnlMenu;
        private Wisej.Web.PictureBox pbPerfil;
        private Wisej.Web.PictureBox pbMapa1;
        private Wisej.Web.Button btnSalir;
    }
}
