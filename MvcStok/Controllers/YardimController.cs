﻿using MvcStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class YardimController : Controller
    {
        // GET: Yardim
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var about = db.TBLHAKKIMDA.ToList();
            return View(about);
        }
    }
}