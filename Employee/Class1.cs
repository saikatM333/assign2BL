using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
     public class Class1
    {
        public static void attendence() {
            Random random = new Random();
          int attend = random.Next(0, 2);
            if (attend == 0)
            {
                Console.WriteLine("the emplyee is absent ");
            }
            else
            {
                Console.WriteLine("the emplyoee is present");
            }
                }
    }
}
