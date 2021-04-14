using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.API.Models;
using SuperMarket.API.Resource;


namespace SuperMarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCompanyResource, Company>();
            CreateMap<SaveProductResource, Product>();
            CreateMap<SaveUserResource, User>();
            CreateMap<SavePurchaseResource, Purchase>();


        }
    }
}
