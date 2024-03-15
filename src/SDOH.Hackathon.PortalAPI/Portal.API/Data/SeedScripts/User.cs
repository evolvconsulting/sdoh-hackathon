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
        public static ModelBuilder HasUserSeedData(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().HasData(
            //     new User { Id = 1, UserName = "generic", EmailAddress = "brandonguytoncs@gmail.com" }
            // );
            return modelBuilder;
        }
        //public static ModelBuilderExtensions HasEmployeeSeedData(this ModelBuilder model)
        //{
        //    model.Entity<Employee>().HasData(new Employee { });
        //    return model;
        //}
    }
}
