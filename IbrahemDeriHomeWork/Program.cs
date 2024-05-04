// See https://aka.ms/new-console-template for more information
using IbrahemDeriHomeWork;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

String s1 = "https://www.google.com/test1/nameDomin";
string [] s2  = s1.Split(":");
Console.WriteLine(s1.Split(":")[1].Split("//")[1].Split(".com")[1]);
Setting set = new Setting(s1);
Console.WriteLine(set.getUrl());
Console.WriteLine("path is "+set.getPath());
Console.WriteLine("protocol is " + set.getProtocol());
Customer customer = new Customer("Ibrahem");
Product product = new Product("Test", 200, 1);
product.addProduct(product);
customer.addCustomer(customer);
customer.addCustomer(customer);
foreach(Product item in DB.Products)
{
    Console.WriteLine(item.ToString());
}

