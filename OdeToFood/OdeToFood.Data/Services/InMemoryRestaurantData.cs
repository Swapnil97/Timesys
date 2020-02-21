using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
            new Restaurant { Id=1 , Name="Scotts pizza" , Cuisine=CuisineType.French },
            new Restaurant { Id = 2, Name = "Joes pizza", Cuisine = CuisineType.Russian },
            new Restaurant { Id = 3, Name = "Dominoes pizza", Cuisine = CuisineType.Indian },

            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
