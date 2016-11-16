using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TDE_TEC_PROG_ll
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public String test;
        protected void Page_Load(object sender, EventArgs e)
        {
            test = Request.QueryString["id"];
        }
    }
}