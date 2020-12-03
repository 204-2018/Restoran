using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
    }
}
