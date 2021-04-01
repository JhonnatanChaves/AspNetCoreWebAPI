using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.API.Domain.Services;
using SuperMarket.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
       
        
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
            
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _companyService.ListAsync();            
        
        }


    }
}