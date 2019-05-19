using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Por referencia.
\
Al poner @ al inicio del string se toma el literal y no se agregan barras
*/

namespace pt4
{
    class pt4
    {
        static void Main(string[] args)
        {
            string cad1, cad2, cad3;
            Console.Write("Ingrese la primera cadena:");
            cad1 = Console.ReadLine();
            Console.Write("Ingrese la segunda cadena:");
            cad2 = Console.ReadLine();
            //Concateno
            Console.WriteLine("{0}", String.Concat(cad1, cad2));
            Console.ReadKey();
            //Mayus minus
            Console.WriteLine("{0}", cad1.ToUpper());
            Console.WriteLine("{0}", cad2.ToLower());
            Console.ReadKey();
            //Comparo 2 cadenas
            if (String.Compare(cad1, cad2) == 0)
            {
                Console.WriteLine("Las cadenas son iguales.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas.");
                Console.ReadKey();
            }
            //Recorro cadenas con foreach
            foreach (char letra in cad1)
            {
                Console.WriteLine("{0}", letra);
            }
            foreach (char letra in cad2)
            {
                Console.WriteLine("{0}", letra);
            }
            Console.ReadKey();
            //Spliting
            cad3 = "Me gusta comer rico";
            string[] split = cad3.Split(new Char[] { ' ' });
            foreach (string palabra in split)
            {
                if (palabra.Trim() != " ")
                {
                    Console.WriteLine(palabra);
                }
            }
            Console.ReadKey();
            //Busqueda de palabra por indice
            int valor = cad3.IndexOf("rico");
            if (valor > 0)
            {
                Console.WriteLine("Se encontro la palabra en la cadena.");
            }
            else if (valor < 0)
            {
                Console.WriteLine("No se encontro la palabra en la cadena.");
            }
            else
            {
                Console.WriteLine("La cadena está vacía.");
            }
            Console.ReadKey();
            //Obtengo la longitud de la cadena
            int count = 0;
            foreach (char caracter in cad3)
            {
                count++;
            }
            Console.WriteLine("La cadena tiene {0} caracteres de largo.", count);
            Console.ReadKey();
        }
    }
}
