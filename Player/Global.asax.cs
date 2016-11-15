using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;

namespace Player
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new Models.PlayerDbInitializer());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
