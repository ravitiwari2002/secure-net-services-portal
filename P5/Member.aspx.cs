using EncDec;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Management;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5
{
    public partial class Member : System.Web.UI.Page
    {
        private FormsAuthenticationTicket userTicket;
        protected void Page_Load(object sender, EventArgs e)
        {            
            //check if user is already logged in
            if (!this.isMemberLoggedIn())
            {
                Response.Redirect("~/MemberLogin.aspx");
            }
            else
            {
                if (Session["id"] != null)
                {
                    Label20.Text = "Welcome " + Session["id"].ToString() + "!";
                }
            }            
        }

        public class Util
        {
            public Boolean checkZIP(string zipcode)
            {
                // Checks the validity of the ZIP code
                string usZipValid = @"^\d{5}(?:[-\s]\d{4})?$"; // makes sure that the zipcode is a valid US ZIP

                if (Regex.Match(zipcode, usZipValid).Success)
                    return true;
                else
                    return false;
            }

            //clears the label
            public void clearLabel(Label lbl)
            {

                lbl.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        //function to check if member is already logged in
        private bool isMemberLoggedIn()
        {
            try
            {
                HttpCookie authCookie = Request.Cookies.Get("memberCookie");
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

        //button event to get the weather forecast
        protected void Button2_Click(object sender, EventArgs e)
        {
            WeatherService.Service3Client client = new WeatherService.Service3Client();

            string zip = TextBox1.Text;
            string[] data;

            Util util = new Util();
            util.clearLabel(Label5);
            util.clearLabel(Label6);
            util.clearLabel(Label7);
            util.clearLabel(Label8);
            util.clearLabel(Label9);
            util.clearLabel(Label10);

            if (!String.IsNullOrWhiteSpace(TextBox1.Text) && util.checkZIP(zip))
            {
                data = client.Weather5day(zip);

                if (data.Length > 1)
                {
                    Label5.Text = data[0];
                    Label6.Text = data[1];
                    Label7.Text = data[2];
                    Label8.Text = data[3];
                    Label9.Text = data[4];
                    Label10.Text = data[5];
                }
                else
                {
                    Label5.Text = data[0];
                }
            }
            else
            {
                Label5.Text = "Please enter a valid zip code";
            }
        }

        //button event to get the nearest store location
        protected void Button3_Click(object sender, EventArgs e)
        {
            ExclusiveServices.Service1Client client = new ExclusiveServices.Service1Client();         //connect with the service reference

            Util util = new Util();
            util.clearLabel(Label11);

            //store input in variables
            string zipcode = TextBox2.Text;
            string storeName = TextBox3.Text;
            string data;


            if (!String.IsNullOrWhiteSpace(TextBox2.Text) && !String.IsNullOrWhiteSpace(TextBox3.Text))         //check for valid input
            {
                if (util.checkZIP(zipcode))
                {
                    data = client.findNearestStore(zipcode, storeName);                 //call the service
                    var output = data.Split(new[] { '|' });

                    if (output.Length > 1)                                              //view the result in the label
                    {
                        Label11.Text += "Store Name: " + output[0] + "<br />";
                        Label11.Text += "Store Ratings: " + output[1] + "<br />";
                        Label11.Text += "Store Address: " + output[2];
                    }
                    else
                        Label11.Text = output[0];
                }
                else
                    Label11.Text = "Please Enter a valid US ZIP code";
            }
            else
                Label11.Text = "Please fill all the details";
        }
             

        //logout button to end the session
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Cookies["memberCookie"].Expires = DateTime.Now.AddDays(-1);
            FormsAuthentication.SignOut();
            Session.Abandon();
            Response.Redirect("~/Default.aspx");
        }

        //button event to convert the currency
        protected void Button6_Click1(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client convertCurrency = new CurrencyConverterService.Service1Client();
            Label21.Text = "Converted Amount: " + convertCurrency.ConvertCurrency(TextBox8.Text, TextBox9.Text, TextBox4.Text);
        }
        //button event to encrypt
        protected void Button7_Click(object sender, EventArgs e)
        {
            EncryptionDecryption obj = new EncryptionDecryption();

            Label22.Text = obj.Encrypt(TextBox10.Text);
        }

        //button event to decrypt
        protected void Button8_Click(object sender, EventArgs e)
        {
            EncryptionDecryption obj = new EncryptionDecryption();
            Label23.Text = obj.Decrypt(TextBox12.Text);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if(Session["generatedString"].ToString() == WebUserControl21.code)
            {
                Label24.Text = "You have verified successfully!!!";
            }
            else
            {
                Label24.Text = "Invalid Captcha Code, Please try again";
            }
        }
    }
}