using System;
using Wisej.Web;
using Wisej.Web.VisualBasic;
using Wisej.Core;
using System.Threading.Tasks;
using System.Drawing;
using Raiderplan1;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace RaiderPlan.Sitio.Viajes
{
    public partial class Viajes : Wisej.Web.UserControl
    {
        public delegate void Salir();
        public event Salir EvSalir;
        private List<LatLng> listaWaitPoints;
        MyLeafletMap myMap = new MyLeafletMap();

        public Viajes()
        {
            InitializeComponent();

            //Agrego la calse MyLeafletMap que hereda de witget en la cual levanta los paquetes para mostrar los mapas
            this.Controls.Add(myMap);
            htmlPanel1.Dock = DockStyle.Fill;


            //si hay viaje cargado en la variable de session
            if (Application.Session.ViajeID > 0)
            {
                TrayectoViajeCollection _AuxiliarTrayecto = new TrayectoViajeCollection(); // Para recuperar lso trayectos de un viaje
                _AuxiliarTrayecto.FillByViajeID(Application.Session.ViajeID);

                //Determino si es que se que se recuperaron trayectos 
                if (_AuxiliarTrayecto.Count > 0)
                {
                    //instancio la lista de latitudes y longitudes para recuperar los waitpoints
                    listaWaitPoints = new List<LatLng>();

                    bool primerTrayecto = true;
                    //hay trayectos significa que estamos editando debo recuperar los waitPoints
                    foreach (TrayectoViaje _Item in _AuxiliarTrayecto.Cast<TrayectoViaje>().Where((x) => x.EsOrigen[0]=='S').ToList<TrayectoViaje>())
                    {
                        LatLng WaitPoint = new LatLng();
                        if (primerTrayecto)
                        {
                            // si es el primer trayecto el origen del trayecto es el primer wait point
                            //y el destino es el segundo wait point 
                            LatLng WaitPoint2 = new LatLng();
                            WaitPoint.Lat = (double)_Item.TayectoLatitudOrigen;
                            WaitPoint.Lng = (double)_Item.TrayectoLongitudOrigen;
                            WaitPoint2.Lat = (double)_Item.TrayectoLatidudDestino;
                            WaitPoint2.Lng = (double)_Item.TrayectoLongitudDestino;
                            //agrego los  waitpoint a la lista en orden
                            listaWaitPoints.Add(WaitPoint);
                            listaWaitPoints.Add(WaitPoint2);
                            primerTrayecto = false;
                        }
                        else
                        {
                            // si hay mas de un trayecto solo tomamos la lat y long del destino para el proximo wait point

                            WaitPoint.Lat = (double)_Item.TrayectoLatidudDestino;
                            WaitPoint.Lng = (double)_Item.TrayectoLongitudDestino;
                            listaWaitPoints.Add(WaitPoint);
                        }
                    }

                }
            }

        }


        private void htmlPanel1_Appear(object sender, EventArgs e)
        {

            //carga el mapa dentro del html panel
            htmlPanel1.Eval(@" map = L.map('map').setView([-34.6037, -58.3816], 4);
                          L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'
                          , { attribution: '© OpenStreetMap contributors'}).addTo(map);"
                        );


            //muestra el itinerario de los trayectos del mapa
            htmlPanel1.Eval(@"  let style = document.createElement('style');
                                style.type = 'text/css';
                                style.innerHTML = '.leaflet-routing-container { display: inline; }';
                                document.getElementsByTagName('head')[0].appendChild(style);
                            ");


            //****************************************************************************************************************************
            //controlo el estado de la lista de wait point para determinar si debo cargar los wait point para editar

            if (listaWaitPoints != null)
            {
                //Tengo valores los cargo
                string jsonlist = JsonConvert.SerializeObject(listaWaitPoints);
                //tengo valores creo  la lista y los trasfiero los valores
                htmlPanel1.Eval($@" listaWaitPoint=JSON.parse('{jsonlist}');");

            }
            else
            {
                //no tengo valores creo la lista vacia
                htmlPanel1.Eval(@" listaWaitPoint=[];");

            }


            //**********************************************************************************************
            htmlPanel1.Eval(@"
                              var control;
                              var marcadores=[];   
                              // para a la ruta
                              var datosRuta = {
                                  resumen: {},
                                  coordenadas: [],
                                  waypoints: [],
                                  instrucciones: [],
                                  inputWaypoints: [],
                                   EsOrigen:'S'
                              };

                              window.datosRuta=datosRuta //Expongo en una variable global --nivel del contexto windows

                               //defino el icono primer marcador
                              let iconoPrimerMarcador =  L.divIcon({
                                                                   html: '<i class=""fa fa-motorcycle"" style=""color: red; font-size: 30px;""></i>',
                                                                   iconSize: [00,00],
                                                                   iconAnchor: [00,30]
                                                               });
                             //defino el defino el icono ultimo
                             let iconoUltimoMarcador = L.divIcon({
                                                                  html: '<i class=""fas fa-flag-checkered"" style=""color: green; font-size: 30px;""></i>',
                                                                  iconSize: [00,00],
                                                                  iconAnchor: [00,30]
                                                               });
                              //defino el  marcadores intermedios
                             let iconoIntermedioMarcador = L.divIcon({//genero el objeto para luego agregar el orden de marcado
                                                                      iconSize: [00,00],                                                                      
                                                                      iconAnchor: [00,30]
                                                                     });
                               ///////////////////////////////defino lenguaje para la ruta//////////////////////////////////////////////////////////////////
                               let DetalleEspañol = {
                                                    language: 'es',
                                                    distanceUnit: 'metric',
                                                    units: {
                                                        meters: 'metros',
                                                        kilometers: 'kilómetros'
                                                    },
                                                    directions: {
                                                        N: 'norte',
                                                        NE: 'noreste',
                                                        E: 'este',
                                                        SE: 'sureste',
                                                        S: 'sur',
                                                        SW: 'suroeste',
                                                        W: 'oeste',
                                                        NW: 'noroeste'
                                                    },
                                                    instructions: {
                                                        'Head': 'Dirígete hacia {dir}',
                                                        'Continue': 'Continúa hacia {dir}',
                                                        'SlightRight': 'Gira levemente a la derecha',
                                                        'Right': 'Gira a la derecha',
                                                        'SharpRight': 'Gira pronunciadamente a la derecha',
                                                        'TurnAround': 'Da la vuelta',
                                                        'SharpLeft': 'Gira pronunciadamente a la izquierda',
                                                        'Left': 'Gira a la izquierda',
                                                        'SlightLeft': 'Gira levemente a la izquierda',
                                                        'WaypointReached': 'Has alcanzado un punto de referencia',
                                                        'Roundabout': 'Toma la {exitStr} salida en la rotonda',
                                                        'DestinationReached': 'Has llegado a tu destino'
                                                    }
                                                };
        
                              /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                    //funcion para manejar el evento click  en el mapa y poder añadir marcadores (puntos de enlace)

                                     ManejaClickMapa= function(e) { if(control) { map.removeControl(control) }
                                                             let lat = e.latlng.lat;
                                                             let lng = e.latlng.lng;
                                                             let nuevoPunto= L.latLng(lat, lng);
                                                             marcadores.push(nuevoPunto);

                                                             control=L.Routing.control({
                                                                                         waypoints:marcadores,
                                                                                         createMarker: function(i, wp) {
                                                                                                                         let opcionesMarcador = {
                                                                                                                                                 draggable: true
                                                                                                                                                };
                                                                                                                        
                                                                                                                                    if (i === 0) {
                                                                                                                                        opcionesMarcador.icon = iconoPrimerMarcador;
                                                                                                                                    } else if (i === marcadores.length - 1) {
                                                                                                                                               opcionesMarcador.icon = iconoUltimoMarcador;
                                                                                                                                    } else {

                                                                                                                                             iconoIntermedioMarcador.options.html=`<div style=""display: flex; align-items: center;""><i class=""fas fa-map-marker-alt"" style=""color: blue; font-size: 30px;""></i><span style=""color: black; margin-left: 5px;"">${i + 1}</span></div>`
                                                                                                                                             opcionesMarcador.icon = iconoIntermedioMarcador;
                                                                                                                                    }
                                                                                                                         let _PuntoNuevo= L.marker(wp.latLng, opcionesMarcador).bindPopup('Arrastra este marcador para cambiar la ruta.');

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
                                                                                         showAlternatives: false,
                                                                                         collapsible: true,  // Activa la opción para contraer el panel de rutas
                                                                                         collapsed: true,
                                                                                         router: L.Routing.osrmv1({
                                                                                                                    language: DetalleEspañol.language,
                                                                                                                     profile: 'car'
                                                                                                                    }),
                                                                                                                   formatter: new L.Routing.Formatter(DetalleEspañol) 

                                                                                          }).addTo(map);


                                                              control.on('waypointschanged', function(e) { if (marcadores.length>1){
                                                                                                                                      marcadores = e.waypoints.map(function(waypoint) {
                                                                                                                                                                                        return waypoint.latLng; 
                                                                                                                                                                                       }
                                                                                                                                                                   );
                                                                                                                                                                                                                                                                           
                                                                                                                                     }
                                                                                                          }
                                                                         ); 
                                                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                            //Recupero las rutas y los diferente objetos de la la ruta para luego poder pasarlas al servidor


                                                            control.on('routesfound', function(e) {
                                                                        var routes = e.routes;
                                                                        console.log('ROUTES 1'+ routes.length)
                                                                        console.log(routes)
                                                                        console.log('ROUTES 2'+ routes[1])
                                                                        // Explorando la primera ruta
                                                                        var firstRoute = routes[0];
                                                                        console.log( firstRoute)
                                                                        // Distancia y tiempo total
                                                                        datosRuta.resumen= firstRoute.summary;
                                                                       console.log('ruta');
                                                                        console.log(datosRuta.resumen);
                                                                       // console.log('Distancia total: ' + summary.totalDistance + ' metros');
                                                                        //console.log('Tiempo total: ' + summary.totalTime + ' segundos');

                                                                        // Coordenadas de la ruta
                                                                        var coordinates = firstRoute.coordinates;
                                                                        datosRuta.coordenadas=firstRoute.coordinates;
                                                                        console.log('Coordenadas de la ruta:', coordinates);

                                                                        // Waypoints de la ruta
                                                                        var waypoints = firstRoute.waypoints;
                                                                        datosRuta.waypoints= firstRoute.waypoints;// punto de enlace
                                                                        waypoints.forEach(function(waypoint, index) {
                                                                                             console.log('Waypoint ' + index + ':', waypoint);
                                                                                          });

                                                                       // Instrucciones de la ruta
                                                                        var instructions = firstRoute.instructions;
                                                                        datosRuta.instrucciones= firstRoute.instructions;
                                                                        console.log('instruciones objeto');
                                                                        console.log(datosRuta.instrucciones);
                                                                        instructions.forEach(function(instruction, index) {
                                                                            console.log('Instrucción ' + index + ':', instruction);
                                                                                             });
                                                                        console.log('instruciones objeto');
                                                                        // Waypoints de entrada
                                                                        var inputWaypoints = firstRoute.inputWaypoints;
                                                                            datosRuta.inputWaypoints=firstRoute.inputWaypoints;
                                                                            console.log(inputWaypoints) 
                                                                             console.log(datosRuta.inputWaypoints);                                                                            
                                                                            inputWaypoints.forEach(function(inputWaypoint) {
                                                                            console.log('Input Waypoint :', inputWaypoint); 
                                                                                                  });
                                                                            console.log('datos completos de la ruta')
                                                                            console.log(datosRuta); 
                                                                        })
                                                            
                                                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                                              //Actualizo los marcadores en el servidor
                                                             // var json = JSON.stringify(datosRuta);
                                                              //App.MiMetodoWeb2(json);

                                                             }
                                   /////////////////////////////////////////////////////////////////////////////////////////////////                         
                                     
                                     //evento click en el mapa
                                      map.on('click', ManejaClickMapa);
                                //////////////////////////////////////////////////////////////////// agrego funcion debusqueda//////////////////////////////////////////////////////////////////////
                                
                                                          searchLocation=function () {
                                                            var searchString = document.getElementById('searchQuery').value;
                                                             
                                                            // Intentar primero con Photon
                                                            var photonUrl = 'https://photon.komoot.io/api/?q=' + encodeURIComponent(searchString);
                                                            fetch(photonUrl)
                                                                .then(response => response.json())
                                                                .then(data => {
                                                                    if (data.features.length > 0) {
                                                                        displayResults(data.features);
                                                                    } else {
                                                                        // Si no hay resultados en Photon, intentar con Nominatim
                                                                        var nominatimUrl = 'https://nominatim.openstreetmap.org/search?format=json&q=' + encodeURIComponent(searchString);
                                                                        fetch(nominatimUrl)
                                                                            .then(response => response.json())
                                                                            .then(data => {
                                                                                if (data.length > 0) {
                                                                                    var nominatimResults = data.map(result => {
                                                                                        return {
                                                                                            properties: {
                                                                                                name: result.display_name,
                                                                                                country: result.address.country,
                                                                                                state: result.address.state,
                                                                                                city: result.address.city || result.address.town || result.address.village,
                                                                                                street: result.address.road,
                                                                                                housenumber: result.address.house_number
                                                                                            },
                                                                                            geometry: {
                                                                                                coordinates: [result.lon, result.lat]
                                                                                            }
                                                                                        };
                                                                                    });
                                                                                    displayResults(nominatimResults);
                                                                                } else {
                                                                                    alert('No se encontraron resultados.');
                                                                                }
                                                                            });
                                                                    }
                                                                })
                                                                .catch(error => {
                                                                    console.error('Error en la geocodificación:', error);
                                                                });
                                                        }
                                                        
                                                        displayResults=function displayResults(features) {
                                                            var results = document.getElementById('results');
                                                            results.innerHTML = ''; // Clear previous results
                                                        
                                                            features.forEach(function(feature, index) {
                                                                let properties = feature.properties;
                                                                let listItem = document.createElement('li');
                                                                let name = properties.name ? properties.name : 'Desconocido';
                                                                let country = properties.country ? properties.country : 'Desconocido';
                                                                let state = properties.state ? properties.state : 'Desconocido';
                                                                let city = properties.city ? properties.city : 'Desconocido';
                                                                let street = properties.street ? properties.street : 'Desconocido';
                                                                let housenumber = properties.housenumber ? properties.housenumber : '';
                                                        
                                                                listItem.innerHTML = `<strong>${name}</strong><br>
                                                                                      País: ${country}<br>
                                                                                      Provincia/Estado: ${state}<br>
                                                                                      Localidad: ${city}<br>
                                                                                      Calle: ${street} ${housenumber}`;
                                                        
                                                                listItem.setAttribute('data-lat', feature.geometry.coordinates[1]);
                                                                listItem.setAttribute('data-lng', feature.geometry.coordinates[0]);
                                                                listItem.onclick = function() { 
                                                                                                let lat = parseFloat(this.getAttribute('data-lat'));
                                                                                                let lng = parseFloat(this.getAttribute('data-lng'));
                                                                                                let coordenadas = { latlng: L.latLng(lat, lng) };
                                                                                                ManejaClickMapa(coordenadas);
                                                                                                closeNav(); // 
                                                                                               };
                                                                results.appendChild(listItem);
                                                            });
                               
                                                                        
                                                         }


                               ////////////////////////////////////////////////////////////////////////////////////////////////
                               

             ");

            htmlPanel1.Eval(@"if(listaWaitPoint.length>0)
                               {
                                 for(i=0;i<listaWaitPoint.length;i++)
                                    {
                                       let coordenadas = { latlng: L.latLng(listaWaitPoint[i].lat, listaWaitPoint[i].lng) };
                                       ManejaClickMapa(coordenadas);
                                       
                                    }


                               }
                           ");
            //*******************************************************************************************************************************************************
            //para la apertura y cierre de el menu lateral
            htmlPanel1.Eval(@" openNav=function () {
                                                    document.getElementById(""sidebar"").classList.add('active');
                                                    document.getElementById(""openSidebarBtn"").classList.add('hidden');
                                                    document.getElementById(""map"").style.marginLeft = ""250px"";
                                                  }

                                closeNav=function () {
                                    document.getElementById(""sidebar"").classList.remove('active');
                                    document.getElementById(""openSidebarBtn"").classList.remove('hidden');
                                    document.getElementById(""map"").style.marginLeft = ""0"";
                                }");



            //*******************************************************************************************************************************************************

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agrego la variable de identificador del viaje viajeID

            htmlPanel1.Eval($@" console.log(""este son los datos de la ruta""); console.log(datosRuta);
                              //Actualizo los marcadores en el servidor
                             datosRuta.viajeID={Application.Session.ViajeID};
                             var json = JSON.stringify(datosRuta);
                             App.GeneraViaje(json);");
            Application.Session.ViajeID = 0;
            EvSalir?.Invoke();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Application.Session.ViajeID = 0;
            EvSalir?.Invoke();
        }
    }


}
