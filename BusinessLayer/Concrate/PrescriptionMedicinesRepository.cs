using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class PrescriptionMedicinesRepository: GenericRepository<PrescriptionMedicine>
    {
        DataContext db = new DataContext();
        //public List<RecipeCreation> Details(int id)
        //{
        //    return db.RecipeCreation.Where(x => x.Id == id).ToList();
        //}
    }
}
