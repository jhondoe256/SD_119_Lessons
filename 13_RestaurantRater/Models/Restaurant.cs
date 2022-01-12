using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        // public int CountryId { get; set; }
        // public virtual Country Country { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}