using JBX.Application.DummyQuery;
using JBX.Reader;
using JBX.WebFormApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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