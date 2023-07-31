using DependencyInjectionDatabaseExample.Concrete;
using DependencyInjectionDatabaseExample.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDatabaseExample
{
    public class DBOptionsCenter
    {
        private readonly AppDbContext _context;

        public DBOptionsCenter(AppDbContext context)
        {
            _context = context;
        }

        public void AddEntities()
        {
            Category category1 = new Category();
            category1.Name = "Manav";

            Category category2 = new Category();
            category2.Name = "Şarküteri";

            Category category3 = new Category();
            category3.Name = "Kasap";

            _context.Categories.Add(category1);
            _context.Categories.Add(category2);
            _context.Categories.Add(category3);
            _context.SaveChanges();


            Product product1 = new Product();
            product1.Name = "Salam";
            product1.Description = "Kahvaltılık";
            product1.Price = 25;
            product1.CategoryId = 1;

            Product product2 = new Product();
            product2.Name = "Zeytin";
            product2.Description = "Kahvaltılık";
            product2.Price = 13;
            product2.CategoryId = 1;

            Product product3 = new Product();
            product3.Name = "Elma";
            product3.Description = "Meyve";
            product3.Price = 18;
            product3.CategoryId = 2;

            Product product4 = new Product();
            product4.Name = "Patlıcan";
            product4.Description = "Sebze";
            product4.Price = 12;
            product4.CategoryId = 2;

            Product product5 = new Product();
            product5.Name = "Bonfile";
            product5.Description = "Tavuk Eti";
            product5.Price = 140;
            product5.CategoryId = 3;

            _context.Products.AddRange(product1, product2, product3, product4, product5);
            _context.SaveChanges();
        }
    }
}
