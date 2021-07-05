using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen 'Başlık' alanını boş bırakmayınız!")]
        [MaxLength(100)]
        [Display(Name = "Slider Başlık")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen sıra numarası giriniz!")]
        [Display(Name = "Sıra Numarası")]
        public int Sort { get; set; }

        [NotMapped]
        [Display(Name = "Görsel")]
        public IFormFile ImageFile { get; set; }
    }
}
