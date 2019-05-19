using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt2
{
    class pt2
    {
        public static void calculadora()
        {
            int num1, num2;
            String op;

            Console.WriteLine("Ingrese primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese operacion (S o +: suma, R o -: Resta, M o *: multiplicacion, D o /: division): ");
            op = Console.ReadLine();
            Console.WriteLine("Ingrese segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: ");
            switch (op)
            {
                case "s":
                case "S":
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "r":
                case "R":
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "m":
                case "*":
                case "M":
                    Console.WriteLine(num1 * num2);
                    break;
                case "d":
                case "/":
                case "D":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("error");
                    Console.ReadLine();
                    break;
            }
            reset();
           
        }
        public static void reset()
        {
            Console.WriteLine("Quiere hacer otra operacion? S/N");
            string input = Console.ReadLine();
            if(input == "s" || input == "S")
            {
                calculadora();
            }
            else
            {
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            calculadora();
        }
     
    }
}
