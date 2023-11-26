using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "Today's Date:  " + DateTime.Today.ToString("MM/dd/yyyy") + " And Current Time: " + DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}