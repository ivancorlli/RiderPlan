using RaiderPlan.Sitio.Viajes;
using System;
using System.Runtime.InteropServices.ComTypes;
using Wisej.Core;
using Wisej.Web;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
        public static void MiMetodoWeb2(string jsonParametro)
        {
            
            var parametro= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Marcador>>(jsonParametro);
            Viajes.MiMetodoWeb(parametro);
        }

        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    
    }
    
 
}