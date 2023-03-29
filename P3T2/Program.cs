using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3T2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int WindS;
            Console.Write("Enter the wind speed :");
            WindS = Convert.ToInt32(Console.ReadLine());
            if (WindS >= 119 && WindS <= 153)
                Console.WriteLine("A wind of {0} Km/h  is a  Catergory 1 hurricane", WindS);
            else if (WindS >= 154 && WindS <= 177)
                Console.WriteLine("A wind of {0} Km/h  is a  Catergory 2 hurricane", WindS);
            else if (WindS >= 178 && WindS <= 208)
                Console.WriteLine("A wind of {0} Km/h  is a  Catergory 3 hurricane ", WindS);
            else if (WindS >= 209 && WindS <= 251)
                Console.WriteLine("A wind of {0} Km/h is a  Catergory 4  hurricane", WindS);
            else if (WindS >= 252 )
                Console.WriteLine("A wind of {0} Km/h  is a  Catergory 5 hurricane ", WindS);
            else if (WindS < 119)
                Console.WriteLine("A wind of {0} Km/h is not a hurricane", WindS);

            Console.ReadLine();
        }
    }
}
