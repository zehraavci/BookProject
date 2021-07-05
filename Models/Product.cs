using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }

        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Lütfen kitap için bir isim giriniz!")]
        [MaxLength(175)]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [MaxLength(1750)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Kitap Stok Kodu")]
        [Required(ErrorMessage = "Lütfen kitap için benzersiz bir kod giriniz!")]
        [MaxLength(30)]
        public string Code { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Lütfen kitap fiyatını giriniz!")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Lütfen kitabın ISBN bilgisini giriniz!")]
        [Display(Name = "ISBN")]
        [MaxLength(30)]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "Lütfen sıra numarası giriniz!")]
        [Display(Name = "Sıra Numarası")]
        public int Sort { get; set; }

        [Required(ErrorMessage = "Lütfen kitabın stok adedini giriniz!")]
        [Display(Name = "Stok Adeti")]
        public int Qty { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Görsel")]
        public string Image { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

        [Display(Name = "Yazar")]
        public int AuthorId { get; set; }

        [Display(Name = "Yayıncı")]
        public int PublisherId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher{ get; set; }

        [NotMapped]
        [Display(Name = "Görsel")]
        public IFormFile ImageFile { get; set; }


    }
}
