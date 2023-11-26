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
    public partial class login : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {   
            //check the session role and redirect accordingly
            if (Session["role"] != null && Session["role"] == "Member")
            {
                Response.Cookies["memberCookie"].Expires = DateTime.Now.AddDays(-1);
                Session.Abandon();
            }

            else if (Session["role"] != null && Session["role"] == "Staff")
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
            } 
        }

        //authenticate the credentials in xml file
        protected void bttn_Login_Click(object sender, EventArgs e)
        {
            EncryptionDecryption obj = new EncryptionDecryption();

            bool authSuccessful = false;            
            if (staffUsername.Text == "")
            {
                errorLabelDisplay.Text = "Username cannot be empty!";
                errorLabelDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (staffPassword.Text == "")
            {
                errorLabelDisplay.Text = "Password cannot be empty!";
                errorLabelDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                authSuccessful = searchStaffXML(staffUsername.Text, obj.Encrypt(staffPassword.Text));
                if (authSuccessful)
                {
                    Session["id"] = staffUsername.Text;
                    Session["role"] = "Staff";
                    errorLabelDisplay.Text = "Successfully Logged In!";
                    errorLabelDisplay.ForeColor = System.Drawing.Color.Green;                    
                    FormsAuthentication.RedirectFromLoginPage(staffUsername.Text, false);
                    Response.Redirect("~/Staff/Staff.aspx");
                }
                else
                {
                    errorLabelDisplay.Text = "Invalid Username and Password Combination!";
                    errorLabelDisplay.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        //search function to search staff in xml file
        private bool searchStaffXML(string uname, string staffPassword)
        {
            XmlTextReader xmlReader = new XmlTextReader(HttpContext.Current.Server.MapPath("App_Data/Staff.xml"));
            if (xmlReader == null)
            {
                xmlReader.Close();
                return false;
            }
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Username")
                {
                    xmlReader.Read();
                    if (xmlReader.Value.ToString() == uname)
                    {
                        while (xmlReader.Read())
                        {
                            if (xmlReader.Name == "Password")
                            {
                                xmlReader.Read();
                                if (xmlReader.Value.ToString() == staffPassword)
                                {
                                    xmlReader.Close();
                                    return true;
                                }
                                else
                                {
                                    xmlReader.Close();
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            xmlReader.Close();
            return false;
        }
    }
}