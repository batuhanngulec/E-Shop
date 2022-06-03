using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class RecipeCreation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bos gecilemez")]
        [Display(Name = "Müşteri TC")]
        
        public int CustomerTC { get; set; }


        
        [Display(Name = "Reçeteli Ürün Ekleme")]
        public string AdPrescriptionProduct { get; set; }



        [Required(ErrorMessage = "Bos gecilemez")]
        [Display(Name = "Reçete kodu:")]
        public Guid PrescriptionCode { get; set; }  


        public virtual PrescriptionMedicine PrescriptionMedicine { get; set; }

        public virtual List<PrescriptionMedicine> PrescriptionMedicines { get; set; }
    }
}
