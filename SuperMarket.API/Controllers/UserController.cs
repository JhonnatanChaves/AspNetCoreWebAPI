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
    public class UserController : ControllerBase
    {
        public List<User> Users = new List<User>() {
        
            new User()
            {
                Id=1,
                Name = "Jhonnatan",
                Email = "JowMan@outmail.tmj.br",
                Cpf = "45123812374"
            },
             new User()
            {
                Id=2,
                Name = "Hebrom",
                Email = "hebrom_marcos@outmail.tmj.br"
            },
              new User()
            {
                Id=3,
                Name = "Raabe",
                Email = "raabe@outmail.tmj.br"
            }

        };
        // GET: api/<UserController>
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Users);
        }

        [HttpGet("byId")]
        public IActionResult GetById(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return BadRequest("O Usuário não foi encontrado");
            }
            return Ok(user);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var user = Users.FirstOrDefault(u => u.Name.Contains(name));
            if (user == null)
            {
                return BadRequest("O Usuário não foi encontrado");
            }
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post(User user)
        {
            return Ok(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, User user)
        {
            return Ok(user);
        }

        // PATCH api/<UserController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, User user)
        {
            return Ok(user);
        }


        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
