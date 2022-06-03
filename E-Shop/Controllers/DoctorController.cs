using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    
    public class DoctorController : Controller
    {
        
        public ActionResult Index()
        {
            DataContext db = new DataContext();


            return View();
        }

        


    }
}