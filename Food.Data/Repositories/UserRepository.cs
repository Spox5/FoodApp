using Food.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Food.Data.Repositories
{
    class UserRepository
    {
        private readonly FoodContext foodContext;

        public UserRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }

        public List<User> GetUserByName(int name)
        {
            return foodContext.Users.Where(user => user.Name == name);

        }
    }
}
