using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassApp
{
    class Humancs
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Haircolor { get; set; }
        public double Weight { get; set; } 

        public string Fullname {
            
            get{ return FirstName + " " + Lastname; }

        }
    }
}
