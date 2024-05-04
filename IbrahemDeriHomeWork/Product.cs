using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbrahemDeriHomeWork
{
    internal class Product
    {
       
        static int id = 1;
        public int number { get;  }
        string title { get; set; }
        public int price { get; set; }
        public int CustomerId { get; set; }
        public Product( string title, int price, int customerId)
        {
            this.number = id;
            id++;
            this.title = title;
            this.price = price;
            CustomerId = customerId;
        }
        //===============for add Products and check if id item in list before =============
        public void addProduct(Product product)
        {
            
            DB.Products.Add(product);
           
            
        }
        public List<Product> getProducts()
        {
            return DB.Products;
        }
        public Product getProduct(int product)
        {
            int check = -1;
            foreach (Product item in DB.Products)
            {
                if (item.number == product)
                {
                    return item;
                }   
            }
             throw new Exception("Error this number is not exist before ");

        }
        public void deletProduct(int product)
        {
            int check = -1;
            foreach (Product item in DB.Products)
            {
                if (item.number == product)
                {
                   DB.Products.Remove(item);
                }
            }
            throw new Exception("Error this number is not exist before ");

        }
        
        public String ToString()
        {
            return "number: "+ this.number +"title: "+ this.title +"price: "+ this.price +"Customer id : "+ this.CustomerId;
        }
        public void updateProduct(List<Product> products)
        {
            DB.Products = products;
        }
        public void seeAllProduct()
        {
            foreach (Product item in DB.Products)
            {
               Console.WriteLine(item.ToString);

                
            }

        }
        public Product getProductByCustomerId(int product)
        {
            int check = -1;
            foreach (Product item in DB.Products)
            {
                if (item.CustomerId == product)
                {
                    return item;
                }
            }
            throw new Exception("Error this number Customer A is not exist before ");

        }

    }
}
