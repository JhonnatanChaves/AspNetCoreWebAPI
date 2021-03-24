using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class User
    {
        public User()
        {

        }

        public User(int id, string name, string email, string password, string cpf)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }

        public IEnumerable<Purchase> Purchases { get; set; }


    }

}
