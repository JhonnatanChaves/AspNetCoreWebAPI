using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SuperMarket.API.Domain.Services;
using SuperMarket.API.Extensions;
using SuperMarket.API.Models;
using SuperMarket.API.Resource;
using SuperMarket.API.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarket.API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("/api/[controller]")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthenticationController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> VerifyLogin([FromBody] AuthUserResource resource)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrorMessages());

                var user = _mapper.Map<AuthUserResource, User>(resource);
                var result = await _userService.FirstOrDefaultAsync(user.Email, user.Password);

                if (result == null)
                    return BadRequest("Erro ao tentar realizar o login.");

                var token = CryptoFunctions.GenerateToken(_configuration, user);

                return Ok(new
                {
                    error = false,
                    result = new
                    {
                        token,
                        user = new { user.Id, user.Email }
                    }
                });


            }
            catch (Exception )
            {
                var message = "Erro ao tentar realizar o login.";
                return BadRequest(new { error = true, result = new { message } });
            }

        }


    }
}
