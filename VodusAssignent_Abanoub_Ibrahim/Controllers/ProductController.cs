using Microsoft.AspNetCore.Mvc;
using VodusAssignent_Abanoub_Ibrahim.Dtos;
using VodusAssignent_Abanoub_Ibrahim.Models;
using VodusAssignent_Abanoub_Ibrahim.Services;

namespace VodusAssignent_Abanoub_Ibrahim.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await  _productService.GetAllProducts();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddProductDto product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
