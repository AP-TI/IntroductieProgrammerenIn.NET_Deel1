using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Deel1Oefening1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelConnectionstring.Text = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }
    }
}