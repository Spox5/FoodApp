﻿using Food.Data.Models;
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

        public User GetByEmail(string email)
        {
            return foodContext.Users.FirstOrDefault(user => user.Email == email);
        }

        public User GetByGuid(Guid g)
        {
            return foodContext.Users.FirstOrDefault(user => user.guid == g);
        }

        public void RemoveUnactiveAndOlderThan(DateTime dataTime)
        {
            var usersToRemove = foodContext.Users.Where(user => user.RegisterAt < dataTime && !user.IsActive);
            foodContext.Users.RemoveRange(usersToRemove);
            foodContext.SaveChanges();
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

        public bool DoesUserExistByEmail(string userEmail)
        {
            return foodContext.Users.Any(x => x.Email == userEmail);
        }
    }
}
