using _13_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _13_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> RateRestaurant(Rating model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ratings.Add(model);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllRatings()
        {
            return Ok(await _context.Ratings.ToListAsync());
        }

        [HttpGet]
        [Route("api/Rating/ByRestaurant/{id}")]
        // [ActionName("ByRestaurant")] // <- this should be the same but it's not
        // api/Rating/ByRestaurant/4
        public async Task<IHttpActionResult> GetRatingsForRestaurant(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            List<Rating> ratings = await _context.Ratings.Where(r => r.RestaurantId == id).ToListAsync();
            return Ok(ratings);
        }

        [HttpGet]
        [Route("api/Rating/ById/{id}")]
        // api/Rating/1
        public async Task<IHttpActionResult> GetRatingById(int id)
        {
            Rating rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }
            return Ok(rating);
        }
    }
}
