using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public  class perDayWagePartime
    {
        public static void uc3()
        {
            int part_time = Convert.ToInt32(Console.ReadLine());
            int wage_per_hour = 14;
            Console.WriteLine($"{ wage_per_hour* part_time}");
        }
    }
}
