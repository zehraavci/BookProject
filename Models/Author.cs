using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen 'Yazar Adı' alanını boş bırakmayınız!")]
        [MaxLength(100)]
        [Display(Name = "Yazar Adı")]
        public string Fullname {get;set;}

        [Required(ErrorMessage = "Lütfen 'Yazar Hakkında' alanını boş bırakmayınız!")]
        [MaxLength(1750)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Yazar Hakkında")]
        public string About { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
