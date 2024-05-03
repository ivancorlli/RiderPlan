using System;
using Wisej.Web;
using Wisej.Web.VisualBasic;
using Wisej.Core;
using System.Threading.Tasks;
using System.Drawing;
using Raiderplan1;
using System.Collections.Generic;

namespace RaiderPlan.Sitio.Viajes
{
    public partial class Viajes : Wisej.Web.UserControl
    {
        

  
        MyLeafletMap myMap = new MyLeafletMap();

        public Viajes()
        {
            InitializeComponent();
            
            //Agrego la calse MyLeafletMap que hereda de witget en la cual levanta los paquetes para mostrar los mapas
            this.Controls.Add(myMap);
            htmlPanel1.Dock = DockStyle.Fill;
            /*htmlPanel1.InitScript = @"var self = this;
                                        // Agregar un evento al botón en el HTML cargado
                                         document.getElementById('miBoton').addEventListener('click', function() {
                                         // Disparar un evento personalizado para cambiar la posición
                                         App.MiMetodoWeb('palabra');
                                         });
                                      ";*/
          
        }
        //[WebMethod]
        public static void MiMetodoWeb(List<Marcador> parametro)
        {
            // Lógica de tu método aquí.
            MessageBox.Show("el mesaje se produce en viajes : " + parametro[0].lat+" " + parametro[0].lng);
            
        }

        //protected override void OnWebRender(dynamic config)
        //{
        //    base.OnWebRender((object)config);
        //    config.webMethods = new[] { "MiMetodoWeb" };
        //    RegisterWebMethods(config);

        //}
        private void htmlPanel1_Appear(object sender, EventArgs e)
        {
            //carga el mapa dentro del html panel
            htmlPanel1.Eval(@" map = L.map('map').setView([-27.4953, -64.9743], 12);
                          L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'
                          , { attribution: '© OpenStreetMap contributors'}).addTo(map);"
                        );

            /*htmlPanel1.Eval(@"creaMapa();");*/

            //elimina el itinerario de los trayectos del mapa
            htmlPanel1.Eval(@" var style = document.createElement('style');
                               style.type = 'text/css';
                               style.innerHTML = '.leaflet-routing-container { display: none; }';
                               document.getElementsByTagName('head')[0].appendChild(style);
                           ");


            
           /* htmlPanel1.Eval(@"const miFuncion= function(e) { alert('click');} ");
            htmlPanel1.Eval(@"var marcadores=[]; 
                              var control;
                             map.on('click',miFuncion);");*/


            
            //**********************************************************************************************
            htmlPanel1.Eval(@"var marcadores=[]; 
                              var control;
                             
                              map.on('click', function(e) { if(control) map.removeControl(control);                                             
                                                            var lat = e.latlng.lat;
                                                            var lng = e.latlng.lng;
                                                            var nuevoPunto= L.latLng(lat, lng);
                                                            marcadores.push(nuevoPunto);
                                                            
                                                            control=L.Routing.control({
                                                                                        waypoints:marcadores,
                                                                                        createMarker: function(i, wp) {
                                                                                                                        let _PuntoNuevo= L.marker(wp.latLng, {
                                                                                                                                                               draggable: true,
                                                                                                                                                              }).bindPopup('Arrastra este marcador para cambiar la ruta.');
                                            
                                                                                                                       _PuntoNuevo.on('click', function(e) {
                                                                                                                                                              //elimina el marcador del mapa
                                                                                                                                                              map.removeLayer(e.target);
                                                                                                                                                       
                                                                                                                                                              //elimina el marcador de la lista de marcadores
                                                                                                                                                              marcadores = marcadores.filter(function(marcador) {
                                                                                                                                                                                                 return marcador !== e.target.getLatLng();
                                                                                                                                                                                             });
                                                                                                                                                       
                                                                                                                                                              //actualiza el control de enrutamiento con los marcadores restantes
                                                                                                                                                              control.setWaypoints(marcadores);
                                                                                                                                                          });
                                                                                       
                                                                                                                        return _PuntoNuevo;
                                                                                                                       },
                                                                                        
                                                                                        routeWhileDragging: true,
                                                                                        showAlternatives: true,
                                                                                        
                                                                                     }).addTo(map);
                                                           
                                                             control.on('waypointschanged', function(e) {marcadores = e.waypoints.map(function(waypoint) {
                                                                                                                                                           return waypoint.latLng; 
                                                                                                                                                          }
                                                                                                                                      );
                                                                                                          //Actualizo los marcadores en el servidor
                                                                                                          var json = JSON.stringify(marcadores);
                                                                                                          App.MiMetodoWeb2(json);  
                                                                                                         }
                                                                        ); 
                                                             
                                                             //Actualizo los marcadores en el servidor
                                                             var json = JSON.stringify(marcadores);
                                                             App.MiMetodoWeb2(json);
                                                           
                                                            }
                                     );

                             
                                                            
                           ");

            //*******************************************************************************************************************************************************
            

            //htmlPanel1.Eval(@" map.on('click', function(e) {
            //                                                   var lat = e.latlng.lat;
            //                                                   var lng = e.latlng.lng;
            //                                                   var marker = L.marker([lat, lng]).addTo(map);
            //                                                   marker.bindPopup('Coordenadas: ' + lat + ', ' + lng).openPopup();
            //                                                   // Eliminar el marcador del mapa
            //                                                   marker.on('click', function() {
            //                                                                                   map.removeLayer(marker);
            //                                                                                  }
            //                                                   );
            //                                                   App.MiMetodoWeb2('longitud: '+lng +' Latitud :'+lat);

            //                                                   });");

            /*htmlPanel1.Eval(@"miFuncion=function(){ alert(this);
                            // Disparar un evento personalizado para cambiar la posición
                            App._Viaje.MiMetodoWeb('palabra');
                            }");//var marker = L.marker([-25.4953, -64.9743]).addTo(map); */
            //this.Eval(@"var Marcadores=[
            //                             L.latLng(-27.4953, -64.9743),  // Primer marcador
            //                             L.latLng(-28.4953, -64.9743),  // Segundo marcador
            //                             L.latLng(-29.4953, -64.9743)
            //                           ];   
            //            L.Routing.control({
            //               waypoints:Marcadores,
            //               createMarker: function(i, wp) {
            //                   return L.marker(wp.latLng, {
            //                       draggable: true,
            //                   }).bindPopup('Arrastra este marcador para cambiar la ruta.');
            //               },
            //                routeWhileDragging: true,
            //              }).addTo(map);");


        }   
           
        private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {
          
            
        //    htmlPanel1.Eval(@"
        //                      App.MiMetodoWeb2('Esta esta del lado de programa')
                              
        //                   ");//var marker = L.marker([-25.4953, -64.9743]).addTo(map); */
        //                      // App.MainPage._EspPer._Viaje.MiMetodoWeb('palabra');
        //    /*// console.log('PANEL');
        //                      //  console.log(App.MainPage.pnlMain.EspacioPersonal.pnlContent.Viajes);
        //                     // Disparar un evento personalizado para cambiar la posición
        //                    //App.MiMetodoWeb2('Esta esta del lado de program')*/

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //float latitud, longitud;
            //latitud = float.Parse(mtbLatitud.Text);
            //longitud=float.Parse(mtbLongitud.Text);
            //htmlPanel1.Eval($@"var marker = L.marker([{latitud}, {longitud}]).addTo(map)");
            htmlPanel1.Call("eventoNuevo");
        }
    }

    
}
