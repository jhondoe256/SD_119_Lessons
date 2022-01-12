using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class RestaurantDetail
    {
        // use RatingListItems instead of actual Ratings
        // Avoid the recursive problem
        public List<RatingListItem> Ratings { get; set; }
    }
}