namespace RaiderPlan.Sitio.EspacioPersonal
{
    partial class ViajePublico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajePublico));
            this.pnlContent = new Wisej.Web.Panel();
            this.pnlCoordenadas = new Wisej.Web.Panel();
            this.bntCancelar = new Wisej.Web.Button();
            this.btnTrayectos = new Wisej.Web.Button();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.panelHeader = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.pictureBox5 = new Wisej.Web.PictureBox();
            this.pictureBox4 = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.lblNombre = new Wisej.Web.Label();
            this.lblUsuarioNombre = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.pnlContent.SuspendLayout();
            this.pnlCoordenadas.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlCoordenadas);
            this.pnlContent.Controls.Add(this.htmlPanel1);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 132);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(399, 311);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.BackColor = System.Drawing.Color.Transparent;
            this.pnlCoordenadas.Controls.Add(this.bntCancelar);
            this.pnlCoordenadas.Controls.Add(this.btnTrayectos);
            this.pnlCoordenadas.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlCoordenadas.Location = new System.Drawing.Point(0, 268);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(399, 43);
            this.pnlCoordenadas.TabIndex = 1;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.bntCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bntCancelar.Location = new System.Drawing.Point(126, 5);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(59, 33);
            this.bntCancelar.TabIndex = 7;
            this.bntCancelar.Text = "Salir";
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnTrayectos
            // 
            this.btnTrayectos.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.btnTrayectos.BackColor = System.Drawing.Color.Plum;
            this.btnTrayectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnTrayectos.Location = new System.Drawing.Point(197, 5);
            this.btnTrayectos.Name = "btnTrayectos";
            this.btnTrayectos.Size = new System.Drawing.Size(77, 33);
            this.btnTrayectos.TabIndex = 6;
            this.btnTrayectos.Text = "Trayectos";
            this.btnTrayectos.Click += new System.EventHandler(this.btnTrayectos_Click);
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "Resource\\mapas\\mapaPublico.html";
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(399, 311);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.Appear += new System.EventHandler(this.htmlPanel1_Appear);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panel4);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Controls.Add(this.panel3);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.lblUsuarioNombre);
            this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new Wisej.Web.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(399, 132);
            this.panelHeader.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.Left;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(13, 58);
            this.panel2.MaximumSize = new System.Drawing.Size(175, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 20);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salida";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox2.ImageSource = "Resource\\lib\\iconos\\hora-de-llegada.png";
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox2.ToolTipText = "Lugar de partida";
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ImageSource = "Resource\\lib\\iconos\\copiar.png";
            this.button2.Location = new System.Drawing.Point(229, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 31);
            this.button2.TabIndex = 32;
            this.button2.ToolTipText = "Clonar";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ImageSource = "Resource\\lib\\iconos\\descargar.png";
            this.button1.Location = new System.Drawing.Point(181, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 8;
            this.button1.ToolTipText = "Descargar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Destino";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox3.ImageSource = "Resource\\lib\\iconos\\llegada.png";
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox3.ToolTipText = "Lugar de destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.label4.Location = new System.Drawing.Point(68, 1);
            this.label4.Margin = new Wisej.Web.Padding(8, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "126";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.label5.Location = new System.Drawing.Point(21, 1);
            this.label5.Margin = new Wisej.Web.Padding(8, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "500";
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageSource = "Resource\\lib\\iconos\\summary.png";
            this.pictureBox5.Location = new System.Drawing.Point(49, 1);
            this.pictureBox5.Margin = new Wisej.Web.Padding(15, 3, 3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 18);
            this.pictureBox5.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox5.ToolTipText = "Descargas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageSource = "Resource\\lib\\iconos\\love_13814713.png";
            this.pictureBox4.Location = new System.Drawing.Point(1, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 18);
            this.pictureBox4.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox4.ToolTipText = "Me Gusta";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.MaximumSize = new System.Drawing.Size(270, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 31);
            this.panel1.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblNombre.Dock = Wisej.Web.DockStyle.Left;
            this.lblNombre.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.ForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 31);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre usuario";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioNombre.Cursor = Wisej.Web.Cursors.Hand;
            this.lblUsuarioNombre.Font = new System.Drawing.Font("default, Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.lblUsuarioNombre.Location = new System.Drawing.Point(13, 116);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(59, 12);
            this.lblUsuarioNombre.TabIndex = 10;
            this.lblUsuarioNombre.Text = "@username";
            // 
            // panel3
            // 
            this.panel3.Anchor = Wisej.Web.AnchorStyles.Left;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(134, 58);
            this.panel3.MaximumSize = new System.Drawing.Size(175, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 20);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.Left;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(13, 88);
            this.panel4.MaximumSize = new System.Drawing.Size(175, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 20);
            this.panel4.TabIndex = 34;
            // 
            // ViajePublico
            // 
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "ViajePublico";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Size = new System.Drawing.Size(399, 443);
            this.pnlContent.ResumeLayout(false);
            this.pnlCoordenadas.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Panel pnlCoordenadas;
        private Wisej.Web.Button btnTrayectos;
        private Wisej.Web.Button bntCancelar;
        private Wisej.Web.Panel panelHeader;
        private Wisej.Web.Label lblNombre;
        private Wisej.Web.Label lblUsuarioNombre;
        private Wisej.Web.PictureBox pictureBox3;
        private Wisej.Web.Label label2;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.PictureBox pictureBox5;
        private Wisej.Web.PictureBox pictureBox4;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel4;
    }
}
