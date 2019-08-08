using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class Institution
    {

        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}
