using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class SearchViewModel
    {
        public string SearchTitle { get; set; }
        public bool InDescription { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }

        public List<Product> Result { get; set; }
    }
}
