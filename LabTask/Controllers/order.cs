using LabTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTask.Controllers;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        var orders = new List<Order>
        {
            new RegularOrder { Id = 1, OrderDate = DateTime.Now.AddDays(-2), Status = "Delivered", Items = new List<OrderItem> { new OrderItem { ProductId = 1, Product = new Product { Name = "Laptop" }, Quantity = 1, UnitPrice = 1200m } } },
            new ExpressOrder { Id = 2, OrderDate = DateTime.Now.AddDays(-1), Status = "Processing", Items = new List<OrderItem> { new OrderItem { ProductId = 2, Product = new Product { Name = "Mouse" }, Quantity = 2, UnitPrice = 25m } } },
            new BulkOrder { Id = 3, OrderDate = DateTime.Now, Status = "New", Items = new List<OrderItem> { new OrderItem { ProductId = 3, Product = new Product { Name = "Keyboard" }, Quantity = 10, UnitPrice = 45m } } }
        };
        return View(orders);
    }
}