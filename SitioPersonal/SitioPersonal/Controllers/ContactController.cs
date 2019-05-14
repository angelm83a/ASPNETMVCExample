using SitioPersonal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SitioPersonal.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            ActivitiesModel activities = new ActivitiesModel();
            activities.SetMessageOnScreenHeader = "empty";
            activities.SetMessageOnScreenTextBlock = "empty";

            /*if the user types in /Contact/Contact the page will be redirected to Home/Home
            The Contact view will be shown only after the message was sent. */
            return RedirectToRoute("Default", new { controller = "Home", action = "Home" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ActivitiesModel model)
        {
            ActivitiesModel activities = new ActivitiesModel();

            activities.FromName = Request.Form["name"].ToString(); //busca dentro del formulario
            activities.FromEmail = Request.Form["email"].ToString();
            activities.FromMessage = Request.Form["message"].ToString();

            string fromSiteEmail = ConfigurationManager.AppSettings["SmtpUser"]; //or no-reply@no-reply.com

            //SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            SmtpClient SmtpServer = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
            var mail = new System.Net.Mail.MailMessage();
            mail.From = new MailAddress(fromSiteEmail);
            mail.To.Add("Youremail@yahoo.com");
            mail.Subject = "Message from site: " + activities.FromName;
            mail.IsBodyHtml = true;
            string htmlBody;
            //htmlBody = activities.FromName + " \n" + activities.FromMessage;
            htmlBody = activities.FromName + "\n" + activities.FromEmail + "\n" + activities.FromMessage;

            mail.Body = htmlBody;
            //SmtpServer.Port = 587;
            SmtpServer.Port = Int32.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            SmtpServer.UseDefaultCredentials = false;

            //SmtpServer.Credentials = new System.Net.NetworkCredential("Youremail@hotmail.com", "Pass*********");
            SmtpServer.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["SmtpUser"], ConfigurationManager.AppSettings["SmtpPass"]);
            //SmtpServer.EnableSsl = true;
            SmtpServer.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["EnableSsl"]);
            SmtpServer.Send(mail);
            await Task.Delay(5000);
            
            return View(model);
        } 
    }
}