﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LineaAzulReservas.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar() {
            return View();
        }
        public ActionResult Actualizar()
        {
            return View();
        }
    }
}
