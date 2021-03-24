using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        
        public List<Product> Users = new List<Product>() {

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
                Id=2,
                Name = "Mini Compressor De Ar Automotivo Portátil 250 Psi - Klatter",
                Description =  "Este Compressor de Ar compacto oferece praticidade e versatilidade para seu dia a dia, sendo ideal para encher pneus de carros, motos e bicicletas.",
                Value = 44.99f,
                



            }

        };

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
