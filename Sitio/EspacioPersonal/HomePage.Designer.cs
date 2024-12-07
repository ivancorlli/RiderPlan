namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class HomePage
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
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlHeader = new Wisej.Web.Panel();
            this.lblNombre = new Wisej.Web.Label();
            this.btnCrearViaje = new Wisej.Web.Button();
            this.btnCerrarSesion = new Wisej.Web.Button();
            this.lblUsuarioNombre = new Wisej.Web.Label();
            this.pbUsuario = new Wisej.Web.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlContent);
            this.panel1.Controls.Add(this.pnlHeader);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 599);
            this.panel1.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(500, 548);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromName("@menu");
            this.pnlHeader.Controls.Add(this.lblNombre);
            this.pnlHeader.Controls.Add(this.btnCrearViaje);
            this.pnlHeader.Controls.Add(this.btnCerrarSesion);
            this.pnlHeader.Controls.Add(this.lblUsuarioNombre);
            this.pnlHeader.Controls.Add(this.pbUsuario);
            this.pnlHeader.Dock = Wisej.Web.DockStyle.Top;
            this.pnlHeader.HeaderBackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowCloseButton = false;
            this.pnlHeader.Size = new System.Drawing.Size(500, 51);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Text = "menu";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblNombre.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.ForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.lblNombre.Location = new System.Drawing.Point(67, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 18);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre usuario";
            this.lblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnCrearViaje.BackColor = System.Drawing.Color.FromName("@tabText");
            this.btnCrearViaje.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCrearViaje.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCrearViaje.Location = new System.Drawing.Point(293, 9);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(85, 33);
            this.btnCrearViaje.TabIndex = 6;
            this.btnCrearViaje.Text = "Crear Viaje";
            this.btnCrearViaje.Click += new System.EventHandler(this.BtnCrearViaje_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnCerrarSesion.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCerrarSesion.Location = new System.Drawing.Point(391, 9);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(99, 33);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblUsuarioNombre.Font = new System.Drawing.Font("default, Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.lblUsuarioNombre.Location = new System.Drawing.Point(67, 26);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(47, 14);
            this.lblUsuarioNombre.TabIndex = 2;
            this.lblUsuarioNombre.Text = "Nombre";
            this.lblUsuarioNombre.Click += new System.EventHandler(this.LblUsuarioNombre_Click_1);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.FromName("@window");
            this.pbUsuario.CssStyle = "\r\n  border-radius: 25%";
            this.pbUsuario.Cursor = Wisej.Web.Cursors.Hand;
            this.pbUsuario.Location = new System.Drawing.Point(16, 9);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(36, 36);
            this.pbUsuario.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pbUsuario.Click += new System.EventHandler(this.PbUsuario_Click_1);
            // 
            // HomePage
            // 
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(500, 599);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel pnlHeader;
        private Wisej.Web.Button btnCrearViaje;
        private Wisej.Web.Button btnCerrarSesion;
        private Wisej.Web.Label lblUsuarioNombre;
        private Wisej.Web.PictureBox pbUsuario;
        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.Label lblNombre;
    }
}
