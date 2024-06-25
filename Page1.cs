using RaiderPlan.Sitio.EspacioPersonal;
using RaiderPlan.Sitio.Inicio;
using System;
using Wisej.Web;

namespace RaiderPlan
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            Inicio _inicio = new Inicio();
            _inicio.EvAutenticado += ManejaAutenticado;
            _inicio.Name = "inicio";
            _inicio.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(_inicio);

        }

        private void ManejaAutenticado(object sender, EventArgs e)
        {
            //elimino el user control de inicio
            Control _control = (Control)sender;
            this.pnlMain.Controls.Remove(_control);
            
            //cargo el user control de espacio personal
            EspacioPersonal _EspPer=new EspacioPersonal();
            _EspPer.EvSalir += elijeSalirEspecioPersonal;
            _EspPer.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(_EspPer); 
        }

        private void elijeSalirEspecioPersonal()
        {
            pnlMain.Controls.Clear();
            Inicio _inicio = new Inicio();
            _inicio.EvAutenticado += ManejaAutenticado;
            _inicio.Name = "inicio";
            _inicio.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(_inicio);
        }
        

        

    }

}
