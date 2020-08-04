using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreEf._000Data
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }

        public string Author { get; set; }
    }
   
}
