using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLTest.Models;
using SQLTest.Services;

namespace SQLTest.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;

        private readonly IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}