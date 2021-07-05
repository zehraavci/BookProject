using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen kategori için bir başlık giriniz!")]
        [MaxLength(50)]
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Kategori Açıklama")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
