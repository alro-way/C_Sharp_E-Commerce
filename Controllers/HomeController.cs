using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace C_Sharp_ECommerce.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // public IActionResult Index()
        // {
        //     return View("Dashboard");
        // }

//DASHBOARD PAGE
        public IActionResult Dashboard()
        {
            List<Product> LastProducts= dbContext.Products   
                .OrderByDescending(c=>c.CreatedAt)
                .Take(4)
                .ToList();
            ViewBag.LastProducts = LastProducts;
            List<Order> LastOrders= dbContext.Orders  
                .Include(od=>od.Buyer)
                .Include(od=>od.Purchase) 
                .OrderByDescending(c=>c.CreatedAt)
                .Take(3)
                .ToList();
            ViewBag.LastOrders = LastOrders;
            List<Customer> LastCustomers = dbContext.Customers   
                .OrderByDescending(c=>c.CreatedAt)
                .Take(3)
                .ToList();
            ViewBag.LastCustomers = LastCustomers;

            return View("Dashboard");
        }

     

//CUSTOMER PAGE -- Search form is NOT ready
        public IActionResult Customers()
        {
            List<Customer> AllCustomers = dbContext.Customers   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            ViewBag.AllCustomers = AllCustomers;
            return View("Customers");
        }

        public IActionResult CreateCustomer(Customer newCustomer)
        {
            List<Customer> AllCustomers = dbContext.Customers   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            if(ModelState.IsValid)
            {
                Customer oldCustomer = dbContext.Customers
                    .FirstOrDefault(c=>c.Name == newCustomer.Name);
                if(oldCustomer != null)
                {
                    ViewBag.AllCustomers = AllCustomers;
                    ModelState.AddModelError("Name", "ERROR: Customer with such Name already exists!");
                    return View("Customers");
                }
                dbContext.Customers.Add(newCustomer);
                dbContext.SaveChanges();
                return RedirectToAction("Customers");
            }
            
            ViewBag.AllCustomers = AllCustomers;
            return View("Customers");
        }

        public IActionResult CustDelete(int CustomerId)
        {
            Customer oldCustomer = dbContext.Customers
                .FirstOrDefault(c=>c.CustomerId == CustomerId);
            dbContext.Customers.Remove(oldCustomer);
            dbContext.SaveChanges();
            return RedirectToAction("Customers");
        }



//PRODUCT PAGE

        public IActionResult Products()
        {
            List<Product> AllProducts= dbContext.Products   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            ViewBag.AllProducts = AllProducts;
            return View("Products");
        }

        public IActionResult CreateProduct(Product newProduct)
        {
            
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            List<Product> AllProducts= dbContext.Products   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            ViewBag.AllProducts = AllProducts;
            return View("Products");
        }

        [HttpGet("delete/product/{ProductId}")]
        public IActionResult DeleteProduct(int ProductId) 
        {
            Product ProductToDelete = dbContext.Products
                .SingleOrDefault(w => w.ProductId == ProductId);
            dbContext.Products.Remove(ProductToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Products");
        }
// SEARCH
// WITH ERROR - DUBLICATES INFO TO SECOND FORM - USE WRAPPER MODEL
        [HttpPost("/product/search")]
        public IActionResult SearchProduct(Product searchProd) 
        {
            var SearchProducts = dbContext.Products  
                .Where(p => p.ProductName.Contains(searchProd.ProductName)) 
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            Console.WriteLine(SearchProducts);
            ViewBag.AllProducts = SearchProducts;
            return View("Products");
        }

// DateTimeOffset NOT WORK
        [HttpPost("/order/search")]
        public IActionResult SearchOrder(Order searchOrder) 
        {
                // .Include(od=>od.Purchase)
                // .ThenInclude(b => b.Name)
                // .Include(od=>od.Buyer)
            var SearchOrders = dbContext.Orders  
                .ToList();

            SearchOrders.Where(b => b.Buyer.Name.Contains(searchOrder.Buyer.Name)).OrderByDescending(c=>c.CreatedAt);

           
            ViewBag.AllCustomers = dbContext.Customers.ToList();
            ViewBag.AllOrders = SearchOrders;
            ViewBag.AllProducts = dbContext.Products.ToList();
            return View("Orders");
        }


//ORDERS PAGE


public IActionResult Orders()
        {
            List<Customer> AllCustomers = dbContext.Customers
                .OrderByDescending(c=>c.CreatedAt)   
                .ToList();
            ViewBag.AllCustomers = AllCustomers;

            List<Product> AllProducts= dbContext.Products   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            ViewBag.AllProducts = AllProducts;

            List<Order> AllOrders = dbContext.Orders
                .Include(od=>od.Buyer)
                .Include(od=>od.Purchase)
                .OrderByDescending(o=>o.CreatedAt)
                .ToList();
            ViewBag.AllOrders = AllOrders;
            return View("Orders");
        }

        public IActionResult CreateOrder(Order newOrder)
        {
            
            if(ModelState.IsValid)
            {
                
                Product thisProduct = dbContext.Products
                    .SingleOrDefault(p => p.ProductId == newOrder.ProductId);
                if(thisProduct.Quant < newOrder.OrderQuantity)
                {
                    ModelState.AddModelError("OrderQuantity", "There is no enougph products for your Order!");
                    List<Order> AllOrdersNew = dbContext.Orders
                        .Include(od=>od.Buyer)
                        .Include(od=>od.Purchase)
                        .OrderByDescending(o=>o.CreatedAt)
                        .ToList();
                    ViewBag.AllOrders = AllOrdersNew; 
                    List<Customer> AllCustomersNew = dbContext.Customers
                        .OrderByDescending(c=>c.CreatedAt)   
                        .ToList();
                    ViewBag.AllCustomers = AllCustomersNew;

                    List<Product> AllProductsNew= dbContext.Products   
                        .OrderByDescending(c=>c.CreatedAt)
                        .ToList();
                    ViewBag.AllProducts = AllProductsNew;
                    return View("Orders");
                }
                thisProduct.Quant = thisProduct.Quant - newOrder.OrderQuantity;
                dbContext.Orders.Add(newOrder);
                dbContext.SaveChanges();
                return RedirectToAction("Orders");
            }
            List<Customer> AllCustomers = dbContext.Customers
                .OrderByDescending(c=>c.CreatedAt)   
                .ToList();
            ViewBag.AllCustomers = AllCustomers;

            List<Product> AllProducts= dbContext.Products   
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            ViewBag.AllProducts = AllProducts;

            List<Order> AllOrders = dbContext.Orders
                .Include(od=>od.Buyer)
                .Include(od=>od.Purchase)
                .OrderByDescending(o=>o.CreatedAt)
                .ToList();
            ViewBag.AllOrders = AllOrders;
            return View("Orders");
        }

        [HttpGet("delete/order/{OrderId}")]
        public IActionResult DeleteOrder(int OrderId) 
        {
            Order OrderToDelete = dbContext.Orders
                .Include(od=>od.Buyer)
                .Include(od=>od.Purchase)
                .FirstOrDefault(w => w.OrderId == OrderId);
            dbContext.Orders.Remove(OrderToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Orders");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
