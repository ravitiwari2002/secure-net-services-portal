using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace P5
{
    public partial class CaptchaImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            ImageVerifierService.ServiceClient captcha = new ImageVerifierService.ServiceClient();
            string verifyString, number;
            if (Session["generatedString"] == null)
            {
                if (Session["number"] == null)
                {
                    number = "5";
                }
                else
                {
                    number = Session["number"].ToString();
                }
                verifyString = captcha.GetVerifierString(number);
                Session["generatedString"] = verifyString;
            }
            else
            {
                verifyString = Session["generatedString"].ToString();
            }
            Stream myStream = captcha.GetImage(verifyString);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(myStream);
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}