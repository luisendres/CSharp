using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProdAndCat.Models;

namespace ProdAndCat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ProdAndCatContext db;
        public HomeController(ProdAndCatContext context)
        {
            db = context;
        }
// ----------------------------------------------------------------------------------------------------------------------------------------->
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Product> allProducts = db.Products.ToList();
            return View("Index", allProducts);
        }

        [HttpPost("/create")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if (ModelState.IsValid == false)
            {
                List<Product> allProducts = db.Products.ToList();
                return View("Index", allProducts);
            }

            db.Products.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/products/{productId}")]
        public IActionResult ProductDetails(int productId)
        {
            Product product = db.Products
            .Include(product => product.Associations)
            .ThenInclude(productCat => productCat.Category)
            .FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.CategoriesToAdd = db.Categories.ToList();
            // ViewBag.CategoriesToAdd = db.Categories.Where(c => c.Associations != c.).ToList();

            return View("ProductDetails", product);
        }

        [HttpPost("/products/{productId}/add-category")]
        public IActionResult AddCatToProd(int productId, Association newAssociation)
        {
            newAssociation.ProductId = productId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();

            return RedirectToAction("ProductDetails", new { productId = productId});
        }
// ----------------------------------------------------------------------------------------------------------------------------------------->
        [HttpGet("/categories")]
        public IActionResult Categories()
        {
            List<Category> allCategories = db.Categories.ToList();
            return View("Categories", allCategories);
        }

        [HttpPost("/categories/create")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if (ModelState.IsValid == false)
            {
                List<Category> allCategories = db.Categories.ToList();
                return View("CreateCategory", allCategories);
            }

            db.Categories.Add(newCategory);
            db.SaveChanges();
            return RedirectToAction("Categories");
        }

        [HttpGet("/categories/{categoryId}")]
        public IActionResult CategoryDetails(int categoryId)
        {
            Category category = db.Categories
            .Include(category => category.Associations)
            .ThenInclude(categoryProd => categoryProd.Product)
            .FirstOrDefault(c => c.CategoryId == categoryId);

            if (category == null)
            {
                return RedirectToAction("Categories");
            }

            ViewBag.ProductsToAdd = db.Products.ToList();

            return View("CategoryDetails", category);
        }

        [HttpPost("/categories/{categoryId}/add-poroducts")]
        public IActionResult AddProdToCat(int categoryId, Association newAssociation)
        {
            newAssociation.CategoryId = categoryId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();

            return RedirectToAction("CategoriesDetails", new { categoryId = categoryId});
        }
// ----------------------------------------------------------------------------------------------------------------------------------------->
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
