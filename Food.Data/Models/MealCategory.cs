using System;
using System.Collections.Generic;
using System.Text;

namespace Food.Data.Models
{
    public class MealCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
