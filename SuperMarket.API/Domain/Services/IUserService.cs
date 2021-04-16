using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Services
{
    public interface IUserService
    {
        Task<User> FirstOrDefaultAsync(String email, String password);
    }
}
