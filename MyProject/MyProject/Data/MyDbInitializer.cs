using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task9.Models;

namespace MyProject.Models
{
    public static class MyDbInitializer
    {
        public static void Initialize(MyProjectContext context)
        {
            context.Database.EnsureCreated();


            if (context.Products.Any())
                return;

            context.Products.AddRange(new Product[]
            {
                new Product { ProductName = "IPhone XR", Manufacturer = "USA", Price = 17800, ProductCount = 3 },
                new Product { ProductName = "IPhone SE", Manufacturer = "USA", Price = 13300, ProductCount = 1 },
                new Product { ProductName = "IPhone 11", Manufacturer = "USA", Price = 22000, ProductCount = 2 },
                new Product { ProductName = "IPhone 12", Manufacturer = "USA", Price = 28000, ProductCount = 2 },

                new Product { ProductName = "Samsung M21", Manufacturer = "Korea", Price = 6000, ProductCount = 6 },
                new Product { ProductName = "Samsung S10", Manufacturer = "Korea", Price = 21000, ProductCount = 5 },
                new Product { ProductName = "Samsung M31", Manufacturer = "Korea", Price = 7300, ProductCount = 4 },

                new Product { ProductName = "Huawei P Smart", Manufacturer = "China", Price = 5500, ProductCount = 5 },
                new Product { ProductName = "Huawei Nova 5T", Manufacturer = "China", Price = 10000, ProductCount = 6 },
                new Product { ProductName = "Huawei P40 Lite", Manufacturer = "China", Price = 7000, ProductCount = 6 },
                new Product { ProductName = "Huawei Y6P", Manufacturer = "China", Price = 4200, ProductCount = 7 },
                new Product { ProductName = "Huawei P40 Pro", Manufacturer = "China", Price = 24000, ProductCount = 3 },

                new Product { ProductName = "Meizu 16", Manufacturer = "Taiwan", Price = 4600, ProductCount = 3 },
                new Product { ProductName = "Meizu Note 9", Manufacturer = "Taiwan", Price = 4400, ProductCount = 3 },
                new Product { ProductName = "Meizu M10", Manufacturer = "Taiwan", Price = 3300, ProductCount = 3 },
                new Product { ProductName = "Meizu 16", Manufacturer = "Taiwan", Price = 4600, ProductCount = 3 }
            });

            context.SaveChanges();

            if (context.Customers.Any())
                return;

            context.Customers.AddRange(new Customer[] {
                new Customer { FirstName = "Ivan", LastName = "Ivanov" },
                new Customer { FirstName = "Petr", LastName = "Petrov" },
                new Customer { FirstName = "Sidor", LastName = "Sidorov" },
                new Customer { FirstName = "Nikolay", LastName = "Nikolaev" },
                new Customer { FirstName = "Alexandr", LastName = "Alexandrov" },
                new Customer { FirstName = "Denis", LastName = "Denisov" },
                new Customer { FirstName = "Kiril", LastName = "Kirilov" },
                new Customer { FirstName = "Vladimir", LastName = "Vladimirov" },
                new Customer { FirstName = "Valerii", LastName = "Valerenko" },
                new Customer { FirstName = "Taras", LastName = "Tarasov" }
            });

            context.SaveChanges();

            if (context.Orders.Any())
                return;

            context.Orders.AddRange(new Order[]
            {
                new Order { CreateAt = new DateTime(2020, 10, 10), Price = 20000, ProductCount = 2, CustomerId = 1, ProductId = 10 },
                new Order { CreateAt = new DateTime(2020, 10, 11), Price = 28000, ProductCount = 4, CustomerId = 3, ProductId = 11 },
                new Order { CreateAt = new DateTime(2020, 09, 14), Price = 18000, ProductCount = 3, CustomerId = 4, ProductId = 5 },
                new Order { CreateAt = new DateTime(2020, 09, 18), Price = 22000, ProductCount = 1, CustomerId = 6, ProductId = 3 },
                new Order { CreateAt = new DateTime(2020, 09, 25), Price = 3300, ProductCount = 1, CustomerId = 7, ProductId = 16 },
                new Order { CreateAt = new DateTime(2020, 10, 11), Price = 17800, ProductCount = 1, CustomerId = 9, ProductId = 1 },
                new Order { CreateAt = new DateTime(2020, 10, 23), Price = 10000, ProductCount = 1, CustomerId = 1, ProductId = 10 },
                new Order { CreateAt = new DateTime(2020, 10, 11), Price = 17800, ProductCount = 1, CustomerId = 9, ProductId = 1 }
            });


            context.SaveChanges();

        }
    }
}
