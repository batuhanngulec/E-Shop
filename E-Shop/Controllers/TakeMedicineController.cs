using BusinessLayer.Concrate;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace E_Shop.Controllers
{
    public class TakeMedicineController : Controller
    {

        
        DataContext db = new DataContext();
        RecipeRepository recipeRepository = new RecipeRepository();
        // Get take medicine
        public ActionResult Index(RecipeCreation data)
        {
            data.PrescriptionCode = Guid.NewGuid();
            return View();
        }
        
        public ActionResult UrunGetir(int id)
        {
            var urun = db.RecipeCreation.Find(id);
            return View("UrunGetir",urun);
        }
    }
}