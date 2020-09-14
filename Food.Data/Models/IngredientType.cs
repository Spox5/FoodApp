using System;
using System.Collections.Generic;
using System.Text;

namespace Food.Data.Models
{
    public class IngredientType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
