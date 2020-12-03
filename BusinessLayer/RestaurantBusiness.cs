using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RestaurantBusiness
    {
        public readonly RestaurantRepository restaurantRepository;

        public RestaurantBusiness()
        {
            this.restaurantRepository = new RestaurantRepository();
        }

        public List<Restaurant> GettAll()
        {
            return this.restaurantRepository.GettAllRestaurant();
        }

        public bool InsertMenuItems(Restaurant r)
        {
            if (this.restaurantRepository.InsertMenuItems(r) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Restaurant> GetBetweenPrice(decimal min, decimal max)
        {
            return this.restaurantRepository.GettAllRestaurant().Where(r => r.Price > min && r.Price < max).ToList();
        }
    }
}
