using SitioPersonal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioPersonal.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe
        public ActionResult AboutMe()
        {
            //GetResume resume = new GetResume();
            //resume.ResumeName = "/assets/ANGELO_MUNOZ_CVITAE-ED_v2.1.pdf";
            //return View(resume);
            //return View();
            /*if the user types in /Contact/Contact the page will be redirected to Home/Home
            The Contact view will be shown only after the message was sent. */
            return RedirectToRoute("Default", new { controller = "Home", action = "Home" });
        }


    }
}