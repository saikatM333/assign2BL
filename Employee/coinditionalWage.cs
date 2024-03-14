using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class coinditionalWage
    {
        private int limit;
        private int pay;
        private int noOfDayWork;
        public coinditionalWage( int limit , int pay , int noOfDayWork ) { 
         this.limit = limit;
            this .pay = pay;
            this .noOfDayWork = noOfDayWork;    
        }

        public void decide_pay()
        {
         if ( limit > noOfDayWork)
            {
                Console.WriteLine("pls work for some more day");
            }
         else
            {
                Console.WriteLine($"amount of salary {( noOfDayWork- noOfDayWork)*pay}");
            }
        }
        }
}
