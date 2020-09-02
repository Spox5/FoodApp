using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Food.Data
{
    class FoodContextFactory : IDesignTimeDbContextFactory<FoodContext>
    {
        private string connectionString = "Server=DESKTOP-D0B1296\\SQLEXPRESS;Database=Food;Trusted_Connection=True;";
        public FoodContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FoodContext>();

            return new FoodContext(builder.UseSqlServer(connectionString).Options);
        }
    }
}
