﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            
        }

        protected void memberButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Member.aspx");
        }

        protected void staffButtonClick(object sender, EventArgs e)
        {            
            Response.Redirect("~/login.aspx");
        }
    }
}