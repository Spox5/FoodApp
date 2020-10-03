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

        public User GetById(int id)
        {
            return foodContext.Users.FirstOrDefault(user => user.Id == id);
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

        public void Update(User user)
        {
            foodContext.Users.Update(user);
            foodContext.SaveChanges();
        }

        public bool DoesUserExist(string userName)
        {
            return foodContext.Users.Any(x => x.Name == userName);
        }
    }
}
