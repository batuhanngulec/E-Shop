using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class PrescriptionMedicine
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bos gecilemes")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bos gecilemes")]
        [Display(Name = "Stok kodu:")]
        public int StockCode { get; set; }

        
    }
}