using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Communication
{
    public class UserResponse : BaseResponse
    {
        public User User { get; private set; }
        private UserResponse(bool sucess, string message, User user) : base(sucess, message)
        {
            User = user;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="user">Saved company.</param>
        /// <returns>Response.</returns>
        public UserResponse(User user) : this(true, string.Empty, user) { }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="message">Error message. </param>
        /// <returns>Response.</returns>
        public UserResponse(string message) : this(false, message, null) { }
    }
}
