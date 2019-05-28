using JBX.Application.DummyQuery;
using JBX.Reader;
using JBX.WebFormApp.Data;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace JBX.WebFormApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = this.AddUnity();

            container.RegisterType<IDummyQuery, DummyQuery>();
            container.RegisterType<IDummyData, DummyData>();
        }
    }
}