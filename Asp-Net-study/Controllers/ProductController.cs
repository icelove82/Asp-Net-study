using Asp_Net_study.Models;
using Asp_Net_study.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public JsonFileProductService ProductService { get; }

        public ProductController(JsonFileProductService jsonFileProductService)
        {
            this.ProductService = jsonFileProductService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
