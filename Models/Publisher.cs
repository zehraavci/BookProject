using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen 'Yayıncı Adı' alanını boş bırakmayınız!")]
        [MaxLength(100)]
        [Display(Name = "Yayıncı Adı")]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
