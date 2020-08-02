using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreTwo.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }        

        
        public string Email { get; set; }

        public string Director { get; set; }
        public enum LanguageDialect
        {
            English,
            Japanese,
            Chinese
        }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }

}
