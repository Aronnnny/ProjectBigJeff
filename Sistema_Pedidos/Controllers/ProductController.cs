using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_Pedidos.Models;

namespace Sistema_Pedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult<List<ProductModel>>searchproducts(){
            return Ok();
        }
    }
}