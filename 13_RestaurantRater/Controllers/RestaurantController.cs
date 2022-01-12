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
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> CreateRestaurant(Restaurant model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Restaurants.Add(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync();

            List<RestaurantListItem> restaurantList = restaurants.Select(r => new RestaurantListItem()
            {
                Name = r.Name,
                Location = r.Location,
                AverageRating = r.Ratings.Count == 0 ? 0 : r.Ratings.Select(rating => rating.AverageRating).Average()
            }).ToList();
            
            return Ok(restaurantList);


            List<RestaurantListItem> restaurantListTwo = restaurants.Select(r => {
                List<Rating> ratings = r.Ratings;
                double average;
                if (ratings.Count == 0)
                {
                    average = 0;
                }
                average = ratings.Select(a => a.AverageRating).Average();

                return new RestaurantListItem()
                {
                    Name = r.Name,
                    Location = r.Location,
                    AverageRating = average
                };
            }).ToList();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            RestaurantDetail restaurantDetail = new RestaurantDetail()
            {
                // Ratings = restaurant.Ratings.Select(r =>
                //     new RatingListItem() {
                //         FoorScore = r.FoodScore etc...
                //     }).ToList()
            };

            return Ok(restaurantDetail);
        }


        [HttpPut]
        public async Task<IHttpActionResult> UpdateRestaurant([FromUri] int id, [FromBody] Restaurant model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant.Name = model.Name;
            restaurant.Location = model.Location;

            /*
            int updateCount = await _context.SaveChangesAsync();
            if (updateCount == 1)
            {
                return Ok();
            } else
            {
                return InternalServerError();
            }
            */
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRestaurant([FromUri] int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            _context.Restaurants.Remove(restaurant);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }
    }
}
