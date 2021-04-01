using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Data;

namespace SuperMarket.API.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly SuperMarketContext _context;

        public BaseRepository(SuperMarketContext context)
        {
            _context = context;
        }
    }
}
