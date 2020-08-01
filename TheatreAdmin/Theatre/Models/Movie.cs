using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Theatre.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public int MyProperty { get; set; }
        [DataType(DataType.EmailAddress)]
        public EmailAddressAttribute EmailAddress { get; set; }
        public enum Language 
        {
            English,
            Japanese,
            Chinese
        }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

