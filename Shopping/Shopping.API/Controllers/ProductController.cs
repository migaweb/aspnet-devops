using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    //private readonly ProductContext _context;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger) //, ProductContext context)
    {
      //_context = context ?? throw new ArgumentNullException(nameof(context));
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {

      return ProductContext.Products.ToList();
                      
    }

  }
}
