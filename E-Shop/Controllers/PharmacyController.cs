using BusinessLayer.Concrate;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class PharmacyController : Controller
    {

        RecipeRepository recipeRepository = new RecipeRepository();
        DataContext db = new DataContext();
        // GET: Pharmacy
        public ActionResult Index()
        {
            return View(recipeRepository.List());
        }

        public ActionResult Create()
        {

            return View();

        }


        [HttpPost]

        public ActionResult Create(RecipeCreation data)
        {

            //Guid newGuid = Guid.Parse(data.PrescriptionCode);
            data.PrescriptionCode = Guid.NewGuid();
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Hata Olustu.");
            }

            recipeRepository.Insert(data);
            return RedirectToAction("Index");

        }


    }


}