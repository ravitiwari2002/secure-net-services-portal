using EncDec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace P5
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            //check session roles 
            if (Session["role"] != null && Session["role"] == "Member")
            {
                Response.Redirect("Member.aspx");
            }
            else if (Session["role"] != null && Session["role"] == "Staff")
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //If button checked, save info to cookies
            bool authenticate = false;           

            XmlTextReader xmlReader = new XmlTextReader(HttpContext.Current.Server.MapPath("App_Data/Members.xml"));

            if (xmlReader == null)
            {
                authenticate = false;
            }
            else
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.Name == "Username")
                    {
                        xmlReader.Read();

                        if (xmlReader.Value.ToString() == Login1.UserName)
                        {
                            while (xmlReader.Read())
                            {
                                if (xmlReader.Name == "Password")
                                {
                                    xmlReader.Read();

                                    //encrypt password to check
                                    EncryptionDecryption encrypter = new EncryptionDecryption();
                                    string pass = encrypter.Encrypt(Login1.Password);

                                    if (xmlReader.Value.ToString() == pass)
                                    {
                                        xmlReader.Close();
                                        authenticate = true;
                                        Session["id"] = Login1.UserName;
                                        Session["role"] = "Member";
                                        createFormsAuthTicket(Login1.UserName, false);
                                    }
                                }

                            }
                        }
                        else
                            authenticate = false;
                    }
                }
            }
            //if succesful authenticate then redirect
            if (authenticate)
            {
                e.Authenticated = true;                
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName.ToString(), false);
                Response.Redirect("Member.aspx");
            }
            else
            {
                e.Authenticated = false;
                Response.Redirect("Default.aspx");
            }
        }

        //create Auth Ticket
        private void createFormsAuthTicket(string username, bool isPersistent)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                1,
                username,
                DateTime.Now,
                DateTime.Now.AddMinutes(30),
                isPersistent,
                "Member");
            string encryptedTicket = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie("memberCookie", encryptedTicket);            
            Response.Cookies.Add(cookie);

        }

        //button event for registering as member
        protected void memberSignup(object sender, EventArgs e)
        {
            Response.Redirect("MemberSignUp.aspx");

        }
    }
}