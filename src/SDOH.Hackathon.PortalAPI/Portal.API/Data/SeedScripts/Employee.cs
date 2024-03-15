using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.SeedScripts
{
    public static partial class ModelBuilderExtensions
    {
        public static ModelBuilder HasEmployeeSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "William", LastName = "Shakespeare" }
               , new Employee { Id = 2, FirstName = "Billiam", LastName = "Bakespeare" }
            );
            return modelBuilder;
        }
    }
}
