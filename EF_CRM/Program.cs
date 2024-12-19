using EF_CRM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Net.Http.Headers;

using CRMContext context = new CRMContext();
Customer cust1 = new Customer()
{
    FirstName = "Anna",
    LastName = "Karenina",
    Email = "anna@karenina.com",
    Telephone = "123456789"
};

//Customer cust2 = new Customer()
//{
//    FirstName = "John",
//    LastName = "Smith",
//    Email = "john@smith.com",
//    Telephone = "012345678"
//};

//context.Customers.Add(cust1);
//context.Customers.Add(cust2);
//context.SaveChanges();

//Customer? cust1 = context.Customers.Find(1);
Customer? anna = context.Customers
    .Where(c => c.FirstName.ToLower() == "anna")
    .FirstOrDefault();
List<Customer> custList = context.Customers.ToList();
List<Customer> custList2 = context.Customers
    .Where(c => c.LastName == "Karenina")
    .ToList();

//if (cust1 is not null) context.Remove(cust1);

Customer? cust2 = context.Customers.Find(2);
if (cust2 is not null)
{
    cust2.FirstName = "JohnUpdated";
}



//Product prod1 = new Product()
//{
//    Name = "Keyboard",
//    Color = "Black",
//    Price = 50.99f
//};

//context.Products.Add(prod1);

Product? prod1fromdb = context.Products
    .Where(p => p.Name == "Keyboard" && p.Color == "Black")
    .FirstOrDefault();
Customer? annafromdb = context.Customers
    .Where(c => c.FirstName == "Anna" && c.LastName == "Karenina")
    .FirstOrDefault();

//if (annafromdb is not null && prod1fromdb is not null)
//{
//    Order order1 = new Order()
//    {
//        OrderDate = DateTime.Now,
//        Product = prod1fromdb,
//        Customer = annafromdb
//    };

//    context.Orders.Add(order1);
//}

Order? order2 = context.Orders
    .Include(o => o.Customer)
    .Include(o => o.Product)
    .Where(o => o.Id == 1)
    .FirstOrDefault();

Customer custfromorder2 = order2.Customer;
custfromorder2.FirstName = "AnnaUpdated";

CustomerOrder? co = context.Orders
    .Where(o => o.Id == 1)
    .Include(o => o.Customer)
    .Include(o => o.Product)
    .Select(o => new CustomerOrder()
        { 
            OrderDate = o.OrderDate,
            CustomerName = o.Customer.FirstName + "  " + o.Customer.LastName,
            ProductName = o.Product.Name
        }
    )
    .FirstOrDefault();

List<CustomerOrder> colist = context.Orders
    .Include(o => o.Customer)
    .Include(o => o.Product)
    .Select(o => new CustomerOrder()
    {
        OrderDate = o.OrderDate,
        CustomerName = o.Customer.FirstName + "  " + o.Customer.LastName,
        ProductName = o.Product.Name
    }
    )
    .ToList();

context.SaveChanges();

Console.WriteLine("End of application");