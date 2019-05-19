using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt3
{
    class pt3
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double resultado;
            Console.WriteLine("Ingrese numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor absoluto: {0}",Math.Abs(num1));
            Console.WriteLine("Cuadrado: {0}", Math.Pow(num1,2));
            Console.WriteLine("Raiz cuadrada: {0}", Math.Sqrt(num1));
            Console.WriteLine("Seno: {0}", Math.Sin(num1));
            Console.WriteLine("Coseno: {0}", Math.Cos(num1));
            Console.WriteLine("Valor absoluto: {0}", Math.Abs(num1));

            Console.Write("\nIngrese Num Decimal:");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("\nParte Entera:" + Math.Truncate(num1));
            Console.Write("\nIngrese Num1:");

            num1 = double.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.Write("\nIngrese Num2:");

            num2 = double.Parse(Console.ReadLine());
            resultado = Math.Max(num1, num2);

            Console.Write("\nMayor:" + resultado);
            resultado = Math.Min(num1, num2);

            Console.Write("\nMenor:" + resultado);
            Console.ReadLine();
    
        }
    }
}
