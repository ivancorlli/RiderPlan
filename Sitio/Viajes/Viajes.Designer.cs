namespace RaiderPlan.Sitio.Viajes
{
    partial class Viajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viajes));
            Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
            this.pnlContent = new Wisej.Web.Panel();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.pnlCoordenadas = new Wisej.Web.Panel();
            this.mtbLongitud = new Wisej.Web.MaskedTextBox();
            this.mtbLatitud = new Wisej.Web.MaskedTextBox();
            this.btnAgregar = new Wisej.Web.Button();
            this.lblLongitud = new Wisej.Web.Label();
            this.lblLatitud = new Wisej.Web.Label();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.pnlContent.SuspendLayout();
            this.pnlCoordenadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.htmlPanel1);
            this.pnlContent.Controls.Add(this.pnlCoordenadas);
            this.pnlContent.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(891, 559);
            this.pnlContent.TabIndex = 0;
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "Resource\\mapas\\paginamapa.html";
            this.htmlPanel1.InitScript = "   ";
            this.javaScript1.SetJavaScript(this.htmlPanel1, resources.GetString("htmlPanel1.JavaScript"));
            clientEvent1.Event = "eventoNuevo";
            clientEvent1.JavaScript = "function(){alert(\"disparado desde propiedades\")}";
            this.javaScript1.GetJavaScriptEvents(this.htmlPanel1).Add(clientEvent1);
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(891, 465);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel1_ElementClick);
            this.htmlPanel1.Appear += new System.EventHandler(this.htmlPanel1_Appear);
            // 
            // pnlCoordenadas
            // 
            this.pnlCoordenadas.Controls.Add(this.mtbLongitud);
            this.pnlCoordenadas.Controls.Add(this.mtbLatitud);
            this.pnlCoordenadas.Controls.Add(this.btnAgregar);
            this.pnlCoordenadas.Controls.Add(this.lblLongitud);
            this.pnlCoordenadas.Controls.Add(this.lblLatitud);
            this.pnlCoordenadas.Dock = Wisej.Web.DockStyle.Bottom;
            this.pnlCoordenadas.Location = new System.Drawing.Point(0, 465);
            this.pnlCoordenadas.Name = "pnlCoordenadas";
            this.pnlCoordenadas.Size = new System.Drawing.Size(891, 94);
            this.pnlCoordenadas.TabIndex = 1;
            // 
            // mtbLongitud
            // 
            this.mtbLongitud.Location = new System.Drawing.Point(276, 36);
            this.mtbLongitud.Mask = "999.99999999";
            this.mtbLongitud.Name = "mtbLongitud";
            this.mtbLongitud.Size = new System.Drawing.Size(100, 22);
            this.mtbLongitud.TabIndex = 6;
            // 
            // mtbLatitud
            // 
            this.mtbLatitud.Location = new System.Drawing.Point(83, 36);
            this.mtbLatitud.Mask = "999.99999999";
            this.mtbLatitud.Name = "mtbLatitud";
            this.mtbLatitud.Size = new System.Drawing.Size(100, 22);
            this.mtbLatitud.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(410, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 27);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agergar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(220, 39);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(50, 15);
            this.lblLongitud.TabIndex = 1;
            this.lblLongitud.Text = "longitud";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(33, 39);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(44, 15);
            this.lblLatitud.TabIndex = 0;
            this.lblLatitud.Text = "Latitud";
            // 
            // Viajes
            // 
            this.Controls.Add(this.pnlContent);
            this.Name = "Viajes";
            this.Size = new System.Drawing.Size(891, 559);
            this.pnlContent.ResumeLayout(false);
            this.pnlCoordenadas.ResumeLayout(false);
            this.pnlCoordenadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pnlContent;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.Panel pnlCoordenadas;
        private Wisej.Web.Label lblLatitud;
        private Wisej.Web.Label lblLongitud;
        private Wisej.Web.MaskedTextBox mtbLongitud;
        private Wisej.Web.MaskedTextBox mtbLatitud;
        private Wisej.Web.Button btnAgregar;
    }
}
