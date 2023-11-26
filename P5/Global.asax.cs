using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace P5
{
    public class Global : System.Web.HttpApplication
    {
        
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["SessionCounter"] = 0;          //initialize the session counter to 0
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Int32 counter = ((Int32)Application["SessionCounter"]);                 //get number of sessions
            counter = counter + 1;                                                  //increase session counter by 1                                         
        }      

        protected void Session_End(object sender, EventArgs e)
        {
            Int32 counter = ((Int32)Application["SessionCounter"]);                 //get the number of sessions
            counter = counter - 1;                                                  //decrement the session counter by 1
        }

        void Application_Error(object sender, EventArgs e)
        {
            
            Server.Transfer("Error.aspx");                                          //if an error occurs transfer to Error page
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //event to get the username and roles from cookies after authentication

            HttpCookie decryptedCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

            if (decryptedCookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(decryptedCookie.Value);

                var identity = new GenericIdentity(ticket.Name);
                var roles = ticket.UserData.Split(',');
                var principal = new GenericPrincipal(identity, roles);

                HttpContext.Current.User = principal;
                Thread.CurrentPrincipal = HttpContext.Current.User;
            }
        }
    }
}