using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Product 1", Price = 50 };
            var product2 = new Product { Id = 2, Name = "Product 2", Price = 100 };
            var product3 = new Product { Id = 3, Name = "Product 3", Price = 200 };

            var cartProduct1 = new CartProduct { Id = 1, Product = product1, Quantity = 5, Price = 10 };
            var cartProduct2 = new CartProduct { Id = 2, Product = product2, Quantity = 3, Price = 20 };
            var cartProduct3 = new CartProduct { Id = 3, Product = product3, Quantity = 2, Price = 30 };

            var cartProducts = new List<CartProduct> { cartProduct1, cartProduct2, cartProduct3 };

            return View(cartProducts);
        }
    }
}
