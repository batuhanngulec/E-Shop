using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bos Gecilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bos Gecilemez")]
        [Display(Name = "TC")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        public string TC { get; set; }

        [Required(ErrorMessage = "Bos Gecilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        public string SurName { get; set; }

        //[Required(ErrorMessage = "Bos Gecilemez")]
        //[Display(Name = "E-Posta")]
        //[StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        //[EmailAddress(ErrorMessage ="E-mail formati seklinde giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bos Gecilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalidir.")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Bos Gecilemez")]
        //[Display(Name = "Sifre")]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olmalidir.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Bos Gecilemez")]
        //[Display(Name = "Sifre")]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olmalidir.")]
        //[DataType(DataType.Password)]
        //[Compare("Password",ErrorMessage ="Sifreler Uyusmuyor")]
        public string RePassword { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 karakter olmalidir.")]
        public string Role { get; set; }

    }
}
