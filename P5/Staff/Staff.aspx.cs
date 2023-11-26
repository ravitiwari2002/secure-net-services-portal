using EncDec;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace P5.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        private FormsAuthenticationTicket userTicket;
        protected void Page_Load(object sender, EventArgs e)
        {
            //check for the authentication
            if (!this.isMemberLoggedIn())
            {                
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                if (Session["id"] != null)
                {
                    Label1.Text = "Welcome " + Session["id"].ToString() + "!";
                }
            }
        }       

        //check if staff is logged in
        private bool isMemberLoggedIn()
        {
            try
            {
                HttpCookie authCookie = Request.Cookies.Get(FormsAuthentication.FormsCookieName);
                if (authCookie == null)
                {
                    return false;
                }
                userTicket = FormsAuthentication.Decrypt(authCookie.Value);
            }
            catch (ArgumentException)
            {
                return false;
            }

            if (userTicket == null)
            {
                return false;
            }
            return true;
        }

      
        //read xml file, check for duplicates, if no duplicates then write the data to xml file
        protected void bttn_AddStaff_Click(object sender, EventArgs e)
        {
            string XmlPath;
            XmlPath = Server.MapPath("~/App_Data/") + "Members.xml";
            XmlDocument xdoc = new XmlDocument();
            EncryptionDecryption encrypter = new EncryptionDecryption();

            xdoc.Load(XmlPath);
            XmlElement root = xdoc.DocumentElement;

            //dataset checking for duplicate
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(XmlPath, new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Username";
            int index = dv.Find(txt_Username.Text);

            if(index == -1)
            {
                EncryptionDecryption obj = new EncryptionDecryption();
                string name = txt_Username.Text;
                XDocument doc = XDocument.Load(HttpContext.Current.Server.MapPath("../App_Data/Staff.xml"));
                XElement staff = doc.Element("Staff");
                staff.Add(new XElement("User", new XElement("Username", txt_Username.Text), new XElement("Password", obj.Encrypt(txt_Password.Text))));
                doc.Save(HttpContext.Current.Server.MapPath("../App_Data/Staff.xml"));

                txt_Username.Text = "";
                txt_Password.Text = "";

                var config = XDocument.Load(Server.MapPath("~/Staff/Web.config"));
                var targetNode = config.Root.Element("system.web").Element("authorization").Element("allow").Attribute("users");

                targetNode.Value = targetNode.Value + "," + name;
                config.Save(Server.MapPath("~/Staff/Web.config"));

                Label2.Text = "";
                Label2.Text = "Staff Added!";
            }
            else
            {
                Label2.Text = "";
                Label2.Text = "Sorry, Username is already taken";
            }        

        }

        //logout button event
        protected void Button1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Response.Redirect("../Default.aspx");
        }

        //find number of registered members
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = "";

            int count;
            string XmlPath;
            XmlPath = Server.MapPath("~/App_Data/") + "Members.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(XmlPath);

            XmlNodeList list = xdoc.GetElementsByTagName("User");
            count = list.Count;

            Label3.Text = "There are total " + count + " registered members.";
        }
    }
}