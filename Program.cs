using RaiderPlan.Sitio.Viajes;
using System;
using System.Runtime.InteropServices.ComTypes;
using Wisej.Core;
using Wisej.Web;
using Raiderplan1;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.Ajax.Utilities;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using RaiderPlan.Sitio.Utiles;

namespace RaiderPlan
{
    internal static class Program
    {
        //


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.MainPage = new Page1();
        }

        [WebMethod]
        public static void GeneraViaje(string jsonParametro)
        {

            // var parametro= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Marcador>>(jsonParametro);
            Ruta parametro = Newtonsoft.Json.JsonConvert.DeserializeObject<Ruta>(jsonParametro);

            UtilidadesViaje.GuardaViaje(parametro, Application.Session.ViajeID);

        }

        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

    }


}