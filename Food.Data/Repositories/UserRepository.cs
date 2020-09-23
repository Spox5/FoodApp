using Food.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Food.Data.Repositories
{
    public class UserRepository
    {
        private readonly FoodContext foodContext;

        public UserRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }

        public User GetByName(string name)
        {
            return foodContext.Users.FirstOrDefault(user => user.Name == name);
        }

        public void Add(User user)
        {
            foodContext.Users.Add(user);
            foodContext.SaveChanges();
        }

        public bool CheckUserNameAvailability(string userName)
        {
            System.Threading.Thread.Sleep(200);
            var SearchData = foodContext.Users.Where(x => x.Name == userName).SingleOrDefault();
            if (SearchData != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
