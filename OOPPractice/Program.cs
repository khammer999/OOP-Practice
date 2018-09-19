using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)

        {
            


            SuperHero superFreak = new SuperHero(100.0, true, "Leap Tall Buildings", "Kryptonite");

            superFreak.GetHealth(100);

            

        }
    }
}
