using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDen.Models
{
    public interface IRepository
    {
        IEnumerable<Cookie> GetCookies();
        Cookie GetCookie(int id);        
    }
}
