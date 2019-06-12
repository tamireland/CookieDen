using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDen.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string EmailId { get; set; }
    }
}
