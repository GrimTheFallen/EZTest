using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class Adress
    {
        public int AdressId { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
