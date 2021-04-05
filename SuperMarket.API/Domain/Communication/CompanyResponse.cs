using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Communication
{
    public class CompanyResponse : BaseResponse
    {
        public Company Company { get; private set; }
        private CompanyResponse(bool sucess, string message, Company company) : base(sucess, message)
        {
            Company = company;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="company">Saved company.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(Company company) : this(true,string.Empty,company)  { }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="message">Error message. </param>
        /// <returns>Response.</returns>
        public CompanyResponse(string message) : this(false, message, null) { }
    }
}
