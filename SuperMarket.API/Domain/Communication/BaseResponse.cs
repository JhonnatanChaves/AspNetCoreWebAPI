using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Domain.Communication
{
    public abstract class BaseResponse
    {
        public bool Sucess { get; protected set; }

        public string Message { get; protected set; }

        public BaseResponse(bool success, string message)
        {
            Sucess = success;
            Message = message;
        }
    }
}
