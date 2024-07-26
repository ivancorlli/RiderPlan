using RaiderPlan.Sitio.Viajes;
using Raiderplan1;
using System.Text;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.Utiles
{
    public static class UtilidadesViaje
    {
     /// <summary>
     /// este metodo se encarga de guardar todos los trayecto para cada viaje
     /// </summary>
     /// <param name="parametro"></param>
        public static void GuardaViaje(Ruta parametro, long pViajeID)
        {
            //controlo que el parametro no llegue nulo o con un solo punto
            if (parametro.InputWaypoints.Count > 1)
            {
                //recorro los waypoints (los distintos marcadores para armar los trayectos del viaje en el detalle)
                int oOrden = 1;// establece el orden de los trayectos
                int inicioInstrucion = 0;//para establecer el indice de las instrucciones y poder concatenar las instruciones correctamente
                //recorro los puntos maracados en el mapa menos el ultimo ya que este marca el destino
                for (int i = 0; i < parametro.InputWaypoints.Count - 1; i++)
                {
                    TrayectoViaje oTrayectoViaje = new TrayectoViaje();

                    oTrayectoViaje.Orden = oOrden;
                    oTrayectoViaje.ViajeID = pViajeID; //relaciono con el viaje con el trayecto
                    oTrayectoViaje.TayectoLatitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lng; ;

                    oTrayectoViaje.TrayectoLatidudDestino = (decimal)parametro.InputWaypoints[i + 1].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudDestino = (decimal)parametro.InputWaypoints[i + 1].LatLng.Lng;

                    double distanciaTrayecto = 0;//acumula el total en metros de el trayecto
                    double tiempoTrayecto = 0;//acumula el tiempo en seg
                    StringBuilder concatenacionInstrucciones = new StringBuilder();// para realizar la concatenacion
                    int auxIndice = 0;
                    for (int J = inicioInstrucion; J < parametro.Instrucciones.Count; J++)
                    {

                        //Mientras sea distinto del waitpointreach "es la llegada aun punto intermedio"
                        // concateno las instruccioness
                        if (parametro.Instrucciones[J].Type != "WaypointReached")
                        {
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Text);
                            concatenacionInstrucciones.Append(" por: " + parametro.Instrucciones[J].Distance.ToString() + " mts");
                            concatenacionInstrucciones.Append(";");
                            distanciaTrayecto += parametro.Instrucciones[J].Distance;
                            tiempoTrayecto += parametro.Instrucciones[J].Time;
                        }
                        //llego aun punto intermedio termina las instrucciones para el trayecto
                        else
                        {
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Road + " ,");
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Text);
                            auxIndice = J + 1;
                            break; //dejo de concatenarlas instrucciones 
                        }

                        auxIndice = J;
                    }

                    inicioInstrucion = auxIndice;
                    oTrayectoViaje.TrayectoOrigen = parametro.Instrucciones[0].Road;
                    oTrayectoViaje.TrayectoDestino = parametro.Instrucciones[auxIndice].Road;
                    oTrayectoViaje.Instrucciones = concatenacionInstrucciones.ToString();
                    oTrayectoViaje.Trayectokm = Math.Round((decimal)distanciaTrayecto / 1000);//transformo a km
                    oTrayectoViaje.TiempoEstimado = Math.Round((decimal)tiempoTrayecto / 60);//transformo a minutos

                    oOrden += 1; //para establecer el orden de los trayectos
                    //guardo el trayecto
                    try
                    {
                        oTrayectoViaje.Update();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"No se pudo guardar el {oOrden.ToString()}° trayecto");
                        return; // se corta el proceso de guardado de los proyectos
                    }
                }

            }
            else
            {
                MessageBox.Show("Necesita un origen y un destino para poder guardar");
            }
        }


    }
}
