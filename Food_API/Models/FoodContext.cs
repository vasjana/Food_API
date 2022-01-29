using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Food_API.Models
{
    public class FoodContext : DbContext
    {
       
        public FoodContext(DbContextOptions<FoodContext> options)
           : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; }
    }
}
