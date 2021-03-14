using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_Product.Models
{
    public class CreateClothViewModel
    {
        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [StringLength(maximumLength: 100, ErrorMessage = "Максимальна довжина поля - 100 символів")]
        [DisplayName("Name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [StringLength(maximumLength: 100, ErrorMessage = "Максимальна довжина поля - 100 символів")]
        [DataType(DataType.Currency)]
        [DisplayName("Price: ")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [StringLength(maximumLength: 500, ErrorMessage = "Максимальна довжина поля - 500 символів")]
        [DataType(DataType.Currency)]
        [DisplayName("Color: ")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [StringLength(maximumLength: 500, ErrorMessage = "Максимальна довжина поля - 500 символів")]
        [DataType(DataType.Currency)]
        [DisplayName("Size: ")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [DataType(DataType.Url)]
        [DisplayName("Image URL: ")]
        public string URL_Image { get; set; }


        [Required(ErrorMessage = "Це поле є обов'язковим")]
        [StringLength(maximumLength: 500, ErrorMessage = "Максимальна довжина поля - 500 символів")]
        [DataType(DataType.MultilineText)]
        [DisplayName("Details: ")]
        public string Details { get; set; }
    }
}