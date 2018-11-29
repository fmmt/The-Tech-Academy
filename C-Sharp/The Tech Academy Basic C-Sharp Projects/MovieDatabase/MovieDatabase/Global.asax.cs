using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using MovieDatabase.Migrations;
using MovieDatabase.Models;

namespace MovieDatabase
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MovieModel, Configuration>());
        }
    }
}
