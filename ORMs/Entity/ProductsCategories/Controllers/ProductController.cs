using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;
namespace ProductsCategories.Controllers;

// Product categories will exist in this controller since Categories will not exist without a product
public class ProductController : Controller
{
    private MyContext db;
    public ProductController(MyContext context)
    {
        db = context;
    }

    [HttpGet("/products/new")]
    public IActionResult NewProduct()
    {
        ViewBag.AllProducts = db.Products.ToList();
        return View("NewProduct");
    }

    [HttpPost("/products/add")]
    public IActionResult AddProduct(Product newProduct)
    {
        {
            if (!ModelState.IsValid)
            {
                return View("NewProduct");
            }
            db.Products.Add(newProduct);
            db.SaveChanges();
            Console.WriteLine(newProduct.ProductName);
            return RedirectToAction("NewProduct");
        };
    }
    [HttpGet("/product/one/{productId}")]
    public IActionResult oneProduct(int productId)
    {
        List<Category> allCats = db.Categories.ToList();
        // checklist will check if a relationship exists with current productId
        ViewBag.checklist = db.ProductCategories.Where(pc => pc.ProductId == productId);
        // new list to hold included categories
        List<int> includedCatsInt = new List<int>();
        List<Category> includedCats = new List<Category>();
        // iterating through list and placing those int Ids inside includedCats
        foreach (ProductCategory pc in ViewBag.checklist)
        {
            includedCatsInt.Add(pc.CategoryId);
        }
        // new list to hold categories product is already included in
        List<Category> filteredCats = new List<Category>();
        // iterate through all categories and adding all categories not linked to filteredCats list
        foreach (Category cat in allCats)
        {
            if (!includedCatsInt.Contains(cat.CategoryId))
            {
                filteredCats.Add(cat);
            }
            else
            {
                includedCats.Add(cat);
            }
        }
        Product? product = db.Products.FirstOrDefault(p => p.ProductId == productId);
        ViewBag.includedCats = includedCats;
        ViewBag.allCats = filteredCats;
        ViewBag.productName = product.ProductName;
        ViewBag.productId = product.ProductId;
        return View("ProductCategoryForm");
    }

    [HttpPost("/product/category/add/{productId}")]
    public IActionResult addProdCat(ProductCategory newProdCatLink, int productId)
    {
        newProdCatLink.ProductId = productId;

        if (!ModelState.IsValid)
        {
            return View("ProductCategoryForm");
        }
        db.ProductCategories.Add(newProdCatLink);
        db.SaveChanges();
        return RedirectToAction("NewProduct");
    }

}