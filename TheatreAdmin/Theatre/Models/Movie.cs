using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Theatre.Models
{
    public class Movie
    {
       
        public int Id { get; set; }
        public string MovieName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        [DataType(DataType.EmailAddress)]
        public EmailAddressAttribute Email { get; set; }

        public enum Language
        {
            English,
            Japanese,
            Chinese
        }  

    }
}

