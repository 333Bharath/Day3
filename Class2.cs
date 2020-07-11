using Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Class2
    {
        private int n1=1;
        public int n2 = 2;
        protected int n3 = 3;
        internal int n4 = 4;


    }
}

namespace Dayy3
{
    class some : Class2
    {
        public void Some()
        {
            Day3.Class2 c1 = new Day3.Class2();
            Console.WriteLine(c1.n4);
            Console.WriteLine(n4);
            
            Console.ReadKey();
        }



    }
}
