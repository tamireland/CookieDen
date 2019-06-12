using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDen.Models
{
    public class Repository:IRepository
    {
        private readonly DatabaseContext _dbContext;
        public Repository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public Cookie GetCookie(int id)
        {
            return _dbContext.Cookies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Cookie> GetCookies()
        {
            return _dbContext.Cookies;
        }
    }
}
