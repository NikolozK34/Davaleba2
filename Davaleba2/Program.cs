using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pirveli ricxvi: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Meore ricxvi: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2;

            if(result > 10)
            {
                Console.WriteLine(result + " > 10 is true");
            }
            else if(result < 10)
                {
                Console.WriteLine(result + " > 10 is false");
            }
            else
            {
                Console.WriteLine(result + " = 10");
            }
            
        }
    }
}
