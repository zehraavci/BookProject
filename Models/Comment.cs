using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen yorum giriniz!")]
        [Display(Name = "Yorum")]
        [MaxLength(1750)]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }

        [Display(Name = "Kitap")]
        public int ProductId { get; set; }
        [Display(Name = "Yorum Yapan")]
        public string BookUserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual BookUser BookUser { get; set; }
    }
}
