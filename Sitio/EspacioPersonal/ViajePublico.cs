using System;
using Wisej.Web;

using System.Drawing;
using Raiderplan1;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RaiderPlan.Sitio.Viajes;
using System.IO;
using RaiderPlan.Sitio.Utiles;
using RaiderPlan.Sitio.Inicio;
using static Wisej.Web.Shape;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajePublico : Wisej.Web.UserControl
    {
        public delegate void Salir();
        public event Salir EvSalir;
        public delegate void Clonar(long id);
        public event Clonar EvClonar;
        private List<LatLng> listaWaitPoints;
        private List<LatLng> listaWaitPointsSecundarios;
        private List<Comentario> listaComentarios;
        MyLeafletMap myMap = new MyLeafletMap();
        Viaje _viaje = null;

        public ViajePublico()
        {
            InitializeComponent();

            //Agrego la calse MyLeafletMap que hereda de witget en la cual levanta los paquetes para mostrar los mapas
            this.Controls.Add(myMap);
            htmlPanel1.Dock = DockStyle.Fill;


            CargaDatos();
            

        }

        private void CargaDatos()
        {
            if (Application.Session.ViajeID > 0)
            {
                TrayectoViajeCollection _AuxiliarTrayecto = new TrayectoViajeCollection(); // Para recuperar lso trayectos de un viaje
                _AuxiliarTrayecto.FillByViajeID(Application.Session.ViajeID);

                //Determino si es que se que se recuperaron trayectos 
                if (_AuxiliarTrayecto.Count > 0)
                {
                    //recupero los trayectos que sean de origen(los que fueron trazados originalmente al planificar el viaje)
                    listaWaitPoints = new List<LatLng>();
                    listaWaitPoints.AddRange(RecuperaLista(_AuxiliarTrayecto, 'S'));

                    //recupero los trayecos secundarios añadidos durante el viaje
                    listaWaitPointsSecundarios = new List<LatLng>();
                    listaWaitPointsSecundarios.AddRange(RecuperaLista(_AuxiliarTrayecto, 'N'));

                }

                ComentarioViajeCollection collection = new ComentarioViajeCollection();
                collection.FillByViajeID(Application.Session.ViajeID);

                if (collection.Count > 0)
                {
                    listaComentarios = new List<Comentario>();
                    foreach (ComentarioViaje v in collection)
                    {
                        Comentario comentario = new Comentario()
                        {
                            ID = v.ComentarioViajeID,
                            ViajeID = v.ViajeID,
                            Texto = v.ComentarioTexto,
                            Lat = (double)v.ComentarioLatitud,
                            Lng = (double)v.ComentarioLongitud,
                        };
                        if (!v.ComentarioViajeRow.IsComentarioImagenNull() && v.ComentarioImagen != "")
                        {
                            comentario.Imagen = Path.Combine("Resource", "lib", "Viajes", v.ComentarioImagen).ToString().Replace("\\", "//");

                        }
                        else
                        {
                            comentario.Imagen = "";
                        }
                        listaComentarios.Add(comentario);
                    }
                }

                Viaje viaje = new Viaje();
                viaje.Fill(Application.Session.ViajeID);
                _viaje = viaje;

                lblNombre.Text = viaje.ViajeNombre;
                string origen;
                if (!viaje.ViajeRow.IsLugarPartidaNull())
                {
                    origen = viaje.LugarPartida;
                }
                else
                {
                    origen = " No definido";
                }
                string destino;
                if (!viaje.ViajeRow.IsLugarllegadaNull())
                {
                    destino = viaje.Lugarllegada;
                }
                else
                {
                    destino = " No definido";
                }

                DateTime date = viaje.ViajeRow.IsViajeFechaCreacionNull() ? DateTime.Now : viaje.ViajeFechaCreacion;
                label1.Text = origen;
                label2.Text = destino;

                Usuario user = new Usuario();
                user.Fill(viaje.UsuarioID);

                lblUsuarioNombre.Text = $"Creado por {user.UsuarioNombre} el {date.ToShortDateString()}";
                if (!viaje.ViajeRow.IsViajeMeGustasNull())
                {
                    label5.Text = viaje.ViajeMeGustas.ToString();
                }
                else
                {
                    label5.Text = "0";

                }
                if (!viaje.ViajeRow.IsViajeDescargasNull())
                {
                    label4.Text = viaje.ViajeDescargas.ToString();
                }
                else
                {
                    label4.Text = "0";
                }
            }
        }


        private List<LatLng> RecuperaLista(TrayectoViajeCollection pTrayectoViaje, char pEsoreigen)
        {
            List<LatLng> ListaRespuesta = new List<LatLng>();
            List<TrayectoViaje> _AuxTrayecto = new List<TrayectoViaje>();
            if (pEsoreigen == 'S')
            {
                //se recuperan los trayectos que solo son de origen
                _AuxTrayecto = pTrayectoViaje.Cast<TrayectoViaje>().Where<TrayectoViaje>((x) => x.EsOrigen[0] == 'S').ToList<TrayectoViaje>();

            }
            else
            {
                //se recuperan los trayectos que son secundarios
                _AuxTrayecto = pTrayectoViaje.Cast<TrayectoViaje>().Where<TrayectoViaje>((x) => x.TrayectoViajeRow.IsEsOrigenNull() || x.EsOrigen[0] == 'N').ToList<TrayectoViaje>();

            }


            bool primerTrayecto = true;
            //recorro los waitpoint y armo la lista de respuesta
            foreach (TrayectoViaje _Item in _AuxTrayecto)
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
                    ListaRespuesta.Add(WaitPoint);
                    ListaRespuesta.Add(WaitPoint2);
                    primerTrayecto = false;
                }
                else
                {
                    // si hay mas de un trayecto solo tomamos la lat y long del destino para el proximo wait point

                    WaitPoint.Lat = (double)_Item.TrayectoLatidudDestino;
                    WaitPoint.Lng = (double)_Item.TrayectoLongitudDestino;
                    ListaRespuesta.Add(WaitPoint);
                }
            }

            return ListaRespuesta;
        }

        private void htmlPanel1_Appear(object sender, EventArgs e)
        {

            //carga el mapa dentro del html panel
            htmlPanel1.Eval(@" map = L.map('map').setView([-27.4953, -64.9743], 12);
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
            //controlo el estado de la lista de wait point para determinar si debo cargar los waypoint para editar

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


            if (listaWaitPointsSecundarios != null)
            {
                //Tengo valores los cargo
                string jsonlist = JsonConvert.SerializeObject(listaWaitPointsSecundarios);
                //tengo valores creo  la lista y los trasfiero los valores
                htmlPanel1.Eval($@" listaWaitPointsSecundarios=JSON.parse('{jsonlist}');");

            }
            else
            {
                //no tengo valores creo la lista vacia
                htmlPanel1.Eval(@" listaWaitPointsSecundarios=[];");

            }
            if (listaComentarios != null && listaComentarios.Count > 0)
            {
                //Tengo valores los cargo
                string jsonlist = JsonConvert.SerializeObject(listaComentarios);
                //tengo valores creo  la lista y los trasfiero los valores
                htmlPanel1.Eval($@" listaComentarios=JSON.parse('{jsonlist}');");
            }
            else
            {
                htmlPanel1.Eval(@" listaComentarios=[];");
            }
            htmlPanel1.Eval($@" viajeID={Application.Session.ViajeID}");


            //**********************************************************************************************
            htmlPanel1.Eval(@"
                              var control;//declaro variable
                              var marcadores=[];   
                              // para a la ruta
                              var datosRuta = {
                                  resumen: {},
                                  coordenadas: [],
                                  waypoints: [],
                                  instrucciones: [],
                                  inputWaypoints: []
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

                                // Funcion para manejar recuerdos o ruta
                               ManejaClickFotosOMapa = function(e){
                                   ManejaRecuerdos(e);
                                }
                                        
                              /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                    //funcion para manejar el evento click  en el mapa y poder añadir marcadores (puntos de enlace)
    
                                     ManejaClickMapa= function(e) {if(control) { map.removeControl(control) }
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
                                                                                                                                                               if (marcadores.length<=1){window.datosRuta={}}
                                                                                                                                                           });

                                                                                                                         
                                                                                                                                return _PuntoNuevo;
                                                                                                                        },

                                                                                         routeWhileDragging: true,
                                                                                         showAlternatives: false,
                                                                                         lineOptions: {
                                                                                                           styles: [{ color:'blue', opacity: 0.7, weight: 4 }] // Cambia el color, opacidad y grosor de la línea
                                                                                                       },
                                                                                         collapsible: true,  // Activa la opción para contraer el panel de rutas
                                                                                         collapsed: true,
                                                                                         containerClassName: 'routing-container-1',
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
                                                            control.on('routeselected', function() {
                                                                                                    let container = document.querySelector('.routing-container-1');
                                                                                                                                                                                                           
                                                                                                        if (container && !container.querySelector('.custom-title')) {
                                                                                                            var title = document.createElement('h2');
                                                                                                            title.className = 'custom-title';
                                                                                                            title.textContent = 'RUTA SECUNDARIA';
                                                                                                            
                                                                                                            // Insertar el título al inicio del contenedor
                                                                                                            container.insertBefore(title, container.firstChild);}
 
                                                                        })


                                                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                                              //Actualizo los marcadores en el servidor
                                                             // var json = JSON.stringify(datosRuta);
                                                              //App.MiMetodoWeb2(json);

                                                             }
                                   /////////////////////////////////////////////////////////////////////////////////////////////////                         
                                     
                                     //evento click en el mapa
                                      map.on('click', ManejaClickFotosOMapa);
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

            //carga la lista de waitpoint secundarios(los posteriores a la planificacion del viaje)
            htmlPanel1.Eval(@"if(listaWaitPointsSecundarios.length>0)
                               {
                                 for(i=0;i<listaWaitPointsSecundarios.length;i++)
                                    {
                                       let coordenadas = { latlng: L.latLng(listaWaitPointsSecundarios[i].lat, listaWaitPointsSecundarios[i].lng) };
                                       ManejaClickMapa(coordenadas);
                                       
                                    }


                               }
                           ");

            htmlPanel1.Eval(@" var control1;
                               marcadores1=[];   
                              // para a la ruta
                             /* var datosRuta = {
                                                  resumen: {},
                                                  coordenadas: [],
                                                  waypoints: [],
                                                  instrucciones: [],
                                                  inputWaypoints: [],
                                                  EsOrigen:""""
                                              };*/

                             // window.datosRuta=datosRuta //Expongo en una variable global --nivel del contexto windows

                               //defino el icono primer marcador
                              let iconoPrimerMarcador =  L.divIcon({
                                                                   html: '<i class=""fa fa-motorcycle"" style=""color: black; font-size: 30px;""></i>',
                                                                   iconSize: [00,00],
                                                                   iconAnchor: [00,30]
                                                               });
                             //defino el defino el icono ultimo
                             let iconoUltimoMarcador = L.divIcon({
                                                                  html: '<i class=""fas fa-flag-checkered"" style=""color: black; font-size: 30px;""></i>',
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
                                 

                               //funcion para cargar el viaje en progreso
                             RutaProgramada= function(e) { if(control1) { map.removeControl(control1) }
                                                                       
                                                             let lat = e.latlng.lat;
                                                             let lng = e.latlng.lng;
                                                             let nuevoPunto= L.latLng(lat, lng);
                                                             marcadores1.push(nuevoPunto);

                                                             control1=L.Routing.control({
                                                                                         waypoints:marcadores1,
                                                                                         createMarker: function(i, wp) {
                                                                                                                         let opcionesMarcador = {
                                                                                                                                                 draggable: false
                                                                                                                                                };
                                                                                                                        
                                                                                                                                    if (i === 0) {
                                                                                                                                        opcionesMarcador.icon = iconoPrimerMarcador;
                                                                                                                                    } else if (i === marcadores1.length - 1) {
                                                                                                                                               opcionesMarcador.icon = iconoUltimoMarcador;
                                                                                                                                    } else {

                                                                                                                                             iconoIntermedioMarcador.options.html=`<div style=""display: flex; align-items: center;""><i class=""fas fa-map-marker-alt"" style=""color: red; font-size: 30px;""></i><span style=""color: black; margin-left: 5px;"">${i + 1}</span></div>`
                                                                                                                                             opcionesMarcador.icon = iconoIntermedioMarcador;
                                                                                                                                    }
                                                                                                                         let _PuntoNuevo= L.marker(wp.latLng, opcionesMarcador)//.bindPopup('Arrastra este marcador para cambiar la ruta.');
                                                                                                                      
                                                                                                                         return _PuntoNuevo;
                                                                                                                        },

                                                                                         routeWhileDragging: true,
                                                                                         showAlternatives: false,
                                                                                         lineOptions: {
                                                                                                           styles: [{ color:'red', opacity: 0.7, weight: 4 }] // Cambia el color, opacidad y grosor de la línea
                                                                                                       },
                                                                                         collapsible: true,  // Activa la opción para contraer el panel de rutas
                                                                                         collapsed: true,
                                                                                         containerClassName: 'routing-container-2',
                                                                                         router: L.Routing.osrmv1({
                                                                                                                    language: DetalleEspañol.language,
                                                                                                                     profile: 'car'
                                                                                                                    }),
                                                                                                                   formatter: new L.Routing.Formatter(DetalleEspañol) 

                                                                                          }).addTo(map);


                                                         }

                               //traza los trayectos primarios
                               if(listaWaitPoint.length>0)
                               {
                                 for(i=0;i<listaWaitPoint.length;i++)
                                    {
                                       let coordenadas = { latlng: L.latLng(listaWaitPoint[i].lat, listaWaitPoint[i].lng) };
                                       RutaProgramada(coordenadas);
                                       
                                    }
                                 
                                   let container1 = document.querySelector('.routing-container-2');
                                                                                                                                                                    
                                                                 if (container1 && !container1.querySelector('.custom-title')) {
                                                                     var title = document.createElement('h2');
                                                                     title.className = 'custom-title';
                                                                     title.textContent = 'RUTA PRIMARIA';
                                                                     
                                                                     // Insertar el título al inicio del contenedor
                                                                     container1.insertBefore(title, container1.firstChild);}
  

                               }
                 
                     
                                                              
                                                              

                           ");

            //Majeja crear contenido del comentario
            htmlPanel1.Eval(@"
                ManejaContenidoComentario = function(comentario){
                let nuevoPunto= L.latLng(comentario.lat, comentario.lng);
                const customIcon = L.divIcon({
                                className: '',
                                html: `
                                    <div style=""
                                        background-color: #fff;
                                        border: 2px solid #ff7800;
                                        border-radius: 50%;
                                        width: 40px;
                                        height: 40px;
                                        display: flex;
                                        align-items: center;
                                        justify-content: center;
                                        box-shadow: 0 0 5px rgba(0,0,0,0.2);
                                        overflow: hidden;
                                    "">
                                       <div style="" width:25px; height:25px; "">
                                       <svg viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M15 13H9"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M12 10L12 16"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M19 10H18"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M2 13.3636C2 10.2994 2 8.76721 2.74902 7.6666C3.07328 7.19014 3.48995 6.78104 3.97524 6.46268C4.69555 5.99013 5.59733 5.82123 6.978 5.76086C7.63685 5.76086 8.20412 5.27068 8.33333 4.63636C8.52715 3.68489 9.37805 3 10.3663 3H13.6337C14.6219 3 15.4728 3.68489 15.6667 4.63636C15.7959 5.27068 16.3631 5.76086 17.022 5.76086C18.4027 5.82123 19.3044 5.99013 20.0248 6.46268C20.51 6.78104 20.9267 7.19014 21.251 7.6666C22 8.76721 22 10.2994 22 13.3636C22 16.4279 22 17.9601 21.251 19.0607C20.9267 19.5371 20.51 19.9462 20.0248 20.2646C18.9038 21 17.3433 21 14.2222 21H9.77778C6.65675 21 5.09624 21 3.97524 20.2646C3.48995 19.9462 3.07328 19.5371 2.74902 19.0607C2.53746 18.7498 2.38566 18.4045 2.27673 18"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round""></path> </g></svg>
                                        </div>
                                    </div>
                                `
                });
                const marker =L.marker(nuevoPunto, { icon: customIcon}).addTo(map);

                if(comentario.texto && comentario.texto != ''){
                    let popupContent = `
                                <div style=""
                                    display: flex;
                                    flex-direction: column;
                                    align-items: center;
                                    gap: 10px;
                                    max-width: 200px;
                                "">
                                    <p style=""
                                        margin: 0;
                                        font-size: 14px;
                                        color: #333;
                                    "">${comentario.texto}</p>
                                </div>`;
                    if(comentario.imagen && comentario.imagen != ''){
                        popupContent = `
                                <div style=""
                                    display: flex;
                                    flex-direction: column;
                                    align-items: center;
                                    gap: 10px;
                                    max-width: 200px;
                                "">
                                    <img src=""${comentario.imagen}"" alt=""Imagen"" style=""
                                        width: 100%;
                                        height: auto;
                                        object-fit: cover;
                                        border-radius: 8px;
                                    ""/>
                                    <p style=""
                                        margin: 0;
                                        font-size: 14px;
                                        color: #333;
                                    "">${comentario.texto}</p>
                                </div>`;
                    }
                    marker.bindPopup(popupContent).openPopup();
                }

                 marker.on('popupclose', function(e) {
                   let fileInput = document.getElementById(`file-${comentario.id}`);
                   let commentInput = document.getElementById(`comment-${comentario.id}`);
                   if(fileInput && commentInput){
                        const files = fileInput.files;
                        const comment = commentInput.value;
                        if(!files || files.length == 0 || comment == ''){
                            deleteMarker(marker._leaflet_id,comentario.id)
                        }
                    }
                    });        

                };");

            htmlPanel1.Eval(@"
                if(listaComentarios.length > 0){
                    listaComentarios.map(x=>ManejaContenidoComentario(x));
                }
            ");
            
        }

        private void btnTrayectos_Click(object sender, EventArgs e)
        {
            winTrayectos trayectos = new winTrayectos(Application.Session.ViajeID,true);
            trayectos.ShowDialog();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Application.Session.ViajeID = 0;
            EvSalir?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_viaje.ViajeRow.IsViajeDescargasNull())
            {
                _viaje.ViajeDescargas = 1;
            }
            else
            {
                _viaje.ViajeDescargas += 1;
            }
            try
            {
                _viaje.Update();
                CargaDatos();
            }
            catch (Exception)
            {

            }
            UtilidadesViaje.GenerarGpx(Application.Session.ViajeID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_viaje.UsuarioID != Application.Session.UsuarioID)
            {

            if(_viaje.ViajeRow.IsViajeMeGustasNull()){
                _viaje.ViajeMeGustas = 1;
            }
            else
            {
                _viaje.ViajeMeGustas += 1;
            }

            Viaje copia = new Viaje();
            copia.UsuarioID = Application.Session.UsuarioID;
            copia.ViajeNombre = $"{_viaje.ViajeNombre} - Copia";
            copia.ViajeEstado = "A";
            copia.ViajeFechaCreacion = DateTime.Now;
            copia.LugarPartida = _viaje.LugarPartida;
            copia.Lugarllegada = _viaje.Lugarllegada;

            try
            {
                _viaje.Update();
                copia.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al clonar viaje.");
            }

                TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
                trayectos.FillByViajeID(_viaje.ViajeID);

                if (trayectos.Count > 0)
                {
                    try
                    {
                        foreach (TrayectoViaje tra in trayectos)
                        {
                            TrayectoViaje traCopia = new TrayectoViaje();
                            traCopia.Orden = tra.Orden;
                            traCopia.ViajeID = copia.ViajeID; //relaciono con el viaje con el trayecto
                            traCopia.TayectoLatitudOrigen = tra.TayectoLatitudOrigen;
                            traCopia.TrayectoLongitudOrigen = tra.TrayectoLongitudOrigen;
                            traCopia.TrayectoLatidudDestino = tra.TrayectoLatidudDestino;
                            traCopia.TrayectoLongitudDestino = tra.TrayectoLongitudDestino;
                            traCopia.TrayectoOrigen = tra.TrayectoOrigen;
                            traCopia.TrayectoDestino = tra.TrayectoDestino;
                            traCopia.Instrucciones = tra.Instrucciones;
                            traCopia.Trayectokm = tra.Trayectokm;
                            traCopia.TiempoEstimado = tra.TiempoEstimado;
                            traCopia.EsOrigen = tra.EsOrigen;
                            traCopia.Update();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se produjo un error al clonar trayectos.");
                    }
                }

                winNuevoViaje popUp = new winNuevoViaje(copia.ViajeID);
                popUp.EvAceptar += (id) => EvClonar?.Invoke(id);
                popUp.EvSalir += () => EvClonar?.Invoke(0);
                popUp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No puedes clonar un viaje creado por ti mismo.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
