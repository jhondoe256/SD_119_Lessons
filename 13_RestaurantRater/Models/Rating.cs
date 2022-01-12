using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0, 5)]
        public double FoodScore { get; set; }
        [Required]
        [Range(0, 5)]
        public double CleanlinessScore { get; set; }
        [Required]
        [Range(0, 5)]
        public double AtmosphereScore { get; set; }

        public double AverageRating
        {
            get
            {
                return (FoodScore * 2 + CleanlinessScore + AtmosphereScore) / 4;
            }
        }

        // EF will assume that this is a foreign key without this annotation because it's along the lines of [DbSet name]Id
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}