using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    class pt1
    {
        static void Main(string[] args)
        {
            string num = "";
            string nuevo = "";

            int len = 0;

            Console.WriteLine("Ingresar numero: ");

            num = Console.ReadLine();
           
            len = num.Length - 1;

            while (len >= 0)
            {
                nuevo = nuevo + num[len];
                len--;
            }

            Console.WriteLine("resultado: {0}", nuevo);
            Console.ReadLine();
        }
    }
}
