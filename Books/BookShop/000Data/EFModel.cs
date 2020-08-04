using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace BookShop._000Data
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        [StringLength(50)]
        [Required]
        public string AuthorName { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}

