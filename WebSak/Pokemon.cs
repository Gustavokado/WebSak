using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSak
{
    public class Pokemon
    {
        private string name;
        private int streangth;

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }   
        }

        public int Strength { get; set; }
    }
}
