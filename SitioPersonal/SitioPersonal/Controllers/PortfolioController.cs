﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioPersonal.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Portfolio()
        {
            //return View();
            /*if the user types in /Contact/Contact the page will be redirected to Home/Home
            The Contact view will be shown only after the message was sent. */
            return RedirectToRoute("Default", new { controller = "Home", action = "Home" });
        }
    }
}