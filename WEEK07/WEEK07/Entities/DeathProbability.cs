using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace WEEK07.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double DeathP { get; set; }
    }
}
