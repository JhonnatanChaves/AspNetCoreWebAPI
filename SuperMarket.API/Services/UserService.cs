using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Domain.Services;
using SuperMarket.API.Models;

namespace SuperMarket.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        //private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }


        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
        }


    }
}
