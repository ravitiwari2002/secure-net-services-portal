using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;
using System.Xml;
using EncDec;
using System.Data;

namespace P5
{
    public partial class MemberSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //button event to add the member to xml file
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(UserName.Text)))
            {
                if (Password.Text == ConfirmPassword.Text && !(String.IsNullOrEmpty(Password.Text)))
                {
                    if (Session["generatedString"].ToString() == WebUserControl21.code)
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
                        int index = dv.Find(UserName.Text);

                        //if node not found then add to the file
                        if(index == -1)
                        {
                            string encrypted_password = encrypter.Encrypt(Password.Text);

                            xmlFile.Close();

                            XmlWriterSettings xmlSettings = new XmlWriterSettings();
                            xmlSettings.Indent = true;
                            xmlSettings.NewLineOnAttributes = true;

                            XmlDocument xref = new XmlDocument();
                            xref.Load(HttpContext.Current.Server.MapPath("App_Data/Members.xml"));

                            XPathNavigator xmlNav = xref.CreateNavigator();

                            xmlNav.MoveToChild("Members", "");
                            XmlWriter xmlWriter = xmlNav.AppendChild();

                            xmlWriter.WriteStartElement("User");
                            xmlWriter.WriteElementString("Username", UserName.Text);
                            xmlWriter.WriteElementString("Password", encrypted_password);
                            xmlWriter.WriteEndElement();


                            xmlWriter.Close();

                            xref.Save(HttpContext.Current.Server.MapPath("App_Data/Members.xml"));
                            error.Text = "";
                            error.Visible = true;
                            error.Text = "Registered successfully, You will be redirected to the login page in 5 seconds...";
                            Response.AppendHeader("Refresh", "5;url=Member.aspx");                           
                        }
                        //otherwise return the message
                        else
                        {
                            error.Text = "";
                            error.Visible = true;
                            error.Text = "Sorry, Username is already taken";
                            xmlFile.Close();
                        }           

                    }
                    else
                    {
                        error.Visible = true;
                        error.Text = "Incorrect Captcha";
                    }
                }
                else
                {
                    //show pw do not match
                    error.Visible = true;
                    error.Text = "Passwords Must Match!";
                }
            }
            else
            {
                error.Visible = true;
                error.Text = "Please Enter A Username";
            }
        }
    }
}