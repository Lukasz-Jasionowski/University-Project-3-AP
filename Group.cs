using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3
{
    internal class Group
    {
        public string Name { get; set; }
        public IEnumerable<NumberOfPeople> NumberOfPeople { get; set; }
        public Subject Subject{ get; set; }
    }
}