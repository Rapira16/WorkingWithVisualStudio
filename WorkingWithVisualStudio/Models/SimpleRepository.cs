﻿using System.Collections.Generic;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product> { };
        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository() {
            var initiallItems = new[]
            {
                new Product { Name = "Kayak", Price = 275M},
                new Product { Name = "Lifejacket", Price = 48.95M},
                new Product { Name = "Soccer ball", Price = 19.50M},
                new Product { Name = "Corner flag", Price = 34.95M}
            };
            foreach (var p in initiallItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    } 
}
