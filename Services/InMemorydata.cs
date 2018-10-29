using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Core.Models;

namespace First_Core.Services
{
    public class InMemorydata : IRestaurantData
    {
        public InMemorydata()
        {
            _restaurants = new List<Restaurant>
                {
                    new Restaurant { Id = 1, Name = "Rakesh" },
                    new Restaurant { Id = 2, Name = "Kaddi" },
                    new Restaurant { Id = 3, Name = "Rocky" }
                };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r=>r.Id);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        List<Restaurant> _restaurants;
    }
}
