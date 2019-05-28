using JBX.Application.DummyQuery;
using System;

namespace JBX.WebFormApp.Catalog
{
    public partial class Catalog : System.Web.UI.Page
    {
        IDummyQuery _dummyQuery;
        public Catalog(IDummyQuery dummyQuery)
        {
            _dummyQuery = dummyQuery;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           var planets = _dummyQuery.GetPlanets();
           var xxx = "";
        }
    }
}