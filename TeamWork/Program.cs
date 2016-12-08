using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Increment;

            Console.WriteLine("Enter the number:");
            Increment = int.Parse(Console.ReadLine());

            for (int Inc = 0; Inc < 28; Inc++)
            {
                Console.WriteLine(DayRollOver(EnumDay.Thursday, Inc));
            }

        }
        enum EnumDay : int
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        static EnumDay DayRollOver(EnumDay day, int userinput)
        {
            int x = ((userinput + (int)day) % 7);
            return (EnumDay)x;
        }

    }

}

