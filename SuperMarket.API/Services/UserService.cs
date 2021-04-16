using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Domain.Services;
using SuperMarket.API.Models;
using SuperMarket.API.Persistence.Repositories;

namespace SuperMarket.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
    

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;     
            
        }

        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _userRepository.FirstOrDefaultAsync(login, password);
        
    }
    }
}
