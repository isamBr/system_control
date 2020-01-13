using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace System_Controle
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //to enable camelnotation for Json.Format
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();//using Newtonsoft.Json.Serialization;
            settings.Formatting = Newtonsoft.Json.Formatting.Indented;
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
