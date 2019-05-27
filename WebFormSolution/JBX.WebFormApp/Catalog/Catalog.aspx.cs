using JBX.Application.DummyQuery;
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
        IDatax _dummyQuery;
        public Catalog(IDatax dummyQuery)
        {
            _dummyQuery = dummyQuery;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           var planets = _dummyQuery.GetData();
           var xxx = "";
        }
    }
}