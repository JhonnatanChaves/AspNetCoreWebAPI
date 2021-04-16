﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> FirstOrDefaultAsync(String email, String password);
    }
}
