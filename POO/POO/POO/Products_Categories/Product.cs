using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Products_Categories
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public Int16 Status { get; set; }
        public Category Category { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Product details:");
            Console.WriteLine($"ID: {IdProduct}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Image: {Image}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Status: {(Status == 1 ? "Activo" : "Inactivo")}");

            if (Category != null)
            {
                Console.WriteLine($"Category: {Category.Name}");
            }
        }
        public void AddStock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero");
                return;
            }
            Stock += quantity;
        }
        public void TakeStock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero");
                return;
            }
            int newStock = Stock - quantity;

            if (newStock < 0)
            {
                Console.WriteLine("Insufficient stock");
            }
            else
            {
                Stock = newStock;
                Console.WriteLine($"New stock:{Stock}");
            }
        }
    }
}
