using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class Restaurant
    {
        public string RestaurantName;
        readonly List<string> _restaurants = new List<string> { "Restaurant 1", "Restaurant 2", "Restaurant 3", "Restaurant 4" };

        public Restaurant()
        {
            Random randomRestaurant = new();
            int index = randomRestaurant.Next(_restaurants.Count);
            RestaurantName = _restaurants[index];
        }


    }
}
