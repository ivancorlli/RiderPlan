namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viaje));
            this.pbImagenViaje = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.viajeNombre = new Wisej.Web.Label();
            this.fechaViaje = new Wisej.Web.Label();
            this.btnEliminar = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagenViaje
            // 
            this.pbImagenViaje.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbImagenViaje.Dock = Wisej.Web.DockStyle.Top;
            this.pbImagenViaje.ImageSource = "\\Resource\\lib\\Imagenes\\iconousuario.png";
            this.pbImagenViaje.Location = new System.Drawing.Point(5, 5);
            this.pbImagenViaje.Name = "pbImagenViaje";
            this.pbImagenViaje.Size = new System.Drawing.Size(191, 99);
            this.pbImagenViaje.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbImagenViaje);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(201, 210);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.fechaViaje);
            this.panel2.Controls.Add(this.viajeNombre);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 104);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(191, 101);
            this.panel2.TabIndex = 2;
            // 
            // viajeNombre
            // 
            this.viajeNombre.AutoSize = true;
            this.viajeNombre.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.viajeNombre.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.viajeNombre.Location = new System.Drawing.Point(8, 8);
            this.viajeNombre.Name = "viajeNombre";
            this.viajeNombre.Size = new System.Drawing.Size(105, 15);
            this.viajeNombre.TabIndex = 0;
            this.viajeNombre.Text = "Nombre de viaje";
            // 
            // fechaViaje
            // 
            this.fechaViaje.AutoSize = true;
            this.fechaViaje.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaViaje.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.fechaViaje.Location = new System.Drawing.Point(8, 29);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(92, 15);
            this.fechaViaje.TabIndex = 1;
            this.fechaViaje.Text = "Fecha del viaje";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(243, 221, 0, 0);
            this.btnEliminar.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.Location = new System.Drawing.Point(117, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnEliminar.ResponsiveProfiles"))));
            this.btnEliminar.Size = new System.Drawing.Size(66, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.button1.Location = new System.Drawing.Point(8, 60);
            this.button1.Name = "button1";
            this.button1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("button1.ResponsiveProfiles"))));
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            // 
            // Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Viaje";
            this.Size = new System.Drawing.Size(201, 210);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenViaje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PictureBox pbImagenViaje;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label fechaViaje;
        private Wisej.Web.Label viajeNombre;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button btnEliminar;
    }
}
