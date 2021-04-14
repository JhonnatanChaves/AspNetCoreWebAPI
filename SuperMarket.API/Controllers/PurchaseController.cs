using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.API.Extensions;
using SuperMarket.API.Models;
using SuperMarket.API.Resource;
using SuperMarket.API.Services;

namespace SuperMarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class PurchaseController : Controller
    {
        private readonly IPurchaseService _purchaseService;
        private readonly IMapper _mapper;

        public PurchaseController(IPurchaseService purchaseService, IMapper mapper)
        {
            _purchaseService = purchaseService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PurchaseResource>> ListAsync()
        {
            var purchase = await _purchaseService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Purchase>, IEnumerable<PurchaseResource>>(purchase);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePurchaseResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var purchase = _mapper.Map<SavePurchaseResource, Purchase>(resource);
            var result = await _purchaseService.SaveAsync(purchase);

            if (!result.Sucess)
                return BadRequest(result.Message);

            var companyResource = _mapper.Map<Purchase, PurchaseResource>(result.Purchase);

            return Ok(companyResource);
        }


    }
}
