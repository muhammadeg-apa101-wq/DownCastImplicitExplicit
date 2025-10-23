using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownCastImplicitExplicit.Models
{
    public class Celsius
    {
        public double celsius { get; set; }
        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }

        public static implicit operator Fahrenheit(Celsius celsius)
        {

            return new Fahrenheit(celsius.celsius * 9 / 5 + 32);
        }


    }
}
