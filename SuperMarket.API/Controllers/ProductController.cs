using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.API.Domain.Services;
using SuperMarket.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        

        public List<Product> Product = new List<Product>() {

            new Product()
            {
                Id=1,
                Name = "Parafusadeira Furadeira 12v C/ Impacto Pfv012i + Kit Maleta",
                Description = "Furadeira Parafusadeira Vonder PFV012I 127V 220V Bivolt Com Impacto Bateria Lítio 18 Níveis de Torque com Maleta",
                Value = 123.50f,
            },
             new Product()
            {
                Id=2,
                Name = "Controle Longa Distancia Stetsom Sx2 Light Completo Colorido",
                Description =  "Controle Longa Distância Stetsom SX Universal 200 Metros Alcance Control Com Modelo Aprender",
                Value = 27.95f,
            },
              new Product()
            {
                Id=3,
                Name = "Mini Compressor De Ar Automotivo Portátil 250 Psi - Klatter",
                Description =  "Este Compressor de Ar compacto oferece praticidade e versatilidade para seu dia a dia, sendo ideal para encher pneus de carros, motos e bicicletas.",
                Value = 44.99f,
                



            }

        };

        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _productService.ListAsync();
            return Product;
        }
        /*

                [HttpGet("byId")]
                public IActionResult GetById(int id)
                {
                    var product = Product.FirstOrDefault(p => p.Id == id);
                    if (product == null)
                    {
                        return BadRequest("O produto não foi encontrado");
                    }
                    return Ok(product);
                }

                [HttpGet("{name}")]
                public IActionResult GetByName(string name)
                {
                    var product = Product.FirstOrDefault(p => p.Name.Contains(name));
                    if (product == null)
                    {
                        return BadRequest("O produto não foi encontrado");
                    }
                    return Ok(product);
                }
         */

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Ok(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            return Ok(product);
        }

        // PATCH api/<UserController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Product produc)
        {
            return Ok(produc);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
