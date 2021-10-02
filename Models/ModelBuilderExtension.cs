using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyWebAppMVC.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                 new Employee
                 {
                     Id = 1,
                     Name = "Mary",
                     Department = Dept.IT,
                     Email = "Helloo@gmail.com"
                 },
                 new Employee
                 {
                     Id = 2,
                     Name = "MHeey",
                     Department = Dept.IT,
                     Email = "Hdjdo@gmail.com"
                 }
                
                );
        }
    }
}
