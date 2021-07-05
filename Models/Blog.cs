using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Blog
    {
        public Blog()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen 'Blog Başlık' alanını boş bırakmayınız!")]
        [MaxLength(100)]
        [Display(Name = "Blog Başlık")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen 'Blog İçerik' alanını boş bırakmayınız!")]
        [MaxLength(1750)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Blog İçerik")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen sıra numarası giriniz!")]
        [Display(Name = "Sıra Numarası")]
        public int Sort { get; set; }

        [Display(Name = "Görsel")]
        public string Image { get; set; }

        [ScaffoldColumn(false)]
        public string Link { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [NotMapped]
        [Display(Name = "Görsel")]
        public IFormFile ImageFile { get; set; }
    }
}
