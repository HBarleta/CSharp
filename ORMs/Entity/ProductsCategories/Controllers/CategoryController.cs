using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;
namespace ProductsCategories.Controllers;

public class CategoryController : Controller
{
    private MyContext db;
    public CategoryController(MyContext context)
    {
        db = context;
    }

    [HttpGet("/categories/new")]
    public IActionResult NewCategory()
    {
        ViewBag.allCategories = db.Categories.ToList();

        return View("NewCategory");
    }

    [HttpPost("/category/add")]
    public IActionResult AddCategory(Category newCategory)
    {
        {
            if (!ModelState.IsValid)
            {
                return View("NewCategory");
            }
            db.Categories.Add(newCategory);
            db.SaveChanges();
            Console.WriteLine(newCategory.CategoryName);
            return RedirectToAction("NewCategory");
        };
    }
    [HttpGet("/category/one/{categoryId}")]
    public IActionResult oneCategory(int categoryId)
    {
        List<Product> AllProds = db.Products.ToList();
        ViewBag.checklist = db.ProductCategories.Where(pc => pc.CategoryId == categoryId);
        // new list to hold included ProductId
        List<int> includedProdsInt = new List<int>();
        List<Product> includedProds = new List<Product>();
        // iterating through list and placing those int Ids inside includedProdsInt
        foreach (ProductCategory pc in ViewBag.checklist)
        {
            includedProdsInt.Add(pc.ProductId);
        }
        // new list to hold categories product is already included in
        List<Product> filteredProds = new List<Product>();
        // iterate through all categories and adding all categories not linked to filteredCats list
        foreach (Product prod in AllProds)
        {
            if (!includedProdsInt.Contains(prod.ProductId))
            {
                filteredProds.Add(prod);
            }
            else
            {
                includedProds.Add(prod);
            }
        }
        Category? category = db.Categories.FirstOrDefault(p => p.CategoryId == categoryId);
        ViewBag.catName = category.CategoryName;
        ViewBag.catId = categoryId;
        ViewBag.AllProds = filteredProds;
        ViewBag.includedProds = includedProds;
        return View("CategoryProductForm");
    }
    [HttpPost("/category/product/add/{catId}")]
    public IActionResult addProdCat(ProductCategory newProdCatLink, int catId)
    {
        newProdCatLink.CategoryId = catId;
        if (!ModelState.IsValid)
        {
            return View("CategoryProductForm");
        }
        db.ProductCategories.Add(newProdCatLink);
        db.SaveChanges();
        return RedirectToAction("NewCategory");
    }
}