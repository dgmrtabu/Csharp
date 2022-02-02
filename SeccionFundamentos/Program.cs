using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            FundamentosString6();
            Console.Read();
        }

        static void FundamentosString1()
        {
            var mayusculas = "bienvenidos al curso".ToUpper();
            var minusculas = "BIENVENIDOS AL CURSO".ToLower();

            var usoTrim1 = "!!!#####bienvenidos al curso#####!!!".Trim('#', '!');
            var usoTrimStrart1 = "!!!#####bienvenidos al curso#####".TrimStart('#', '!');
            var usoTrimEnd1 = "#####bienvenidos al curso#####!!!".TrimEnd('#', '!');

        }

        static void FundamentosString2()
        {
            var animal1 = "Elefante";
            var animal2 = "Tigre";

            if (animal1.StartsWith("E"))
            {
                Console.WriteLine(animal1);
            }

            if (animal2.StartsWith("E"))
            {
                Console.WriteLine(animal2);
            }

            if (animal1.EndsWith("E", StringComparison.InvariantCultureIgnoreCase) && animal2.EndsWith("E", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Ambos terminan con la letra E");
            }

            if (animal1.EndsWith("A") && animal2.EndsWith("A"))
            {
                Console.WriteLine("Ambos terminan con la letra A");
            }
        }

        static void FundamentosString3()
        {
            var numero1 = 10;
            Console.WriteLine(numero1.ToString().PadLeft(7, '0'));

            var numero2 = 10;
            Console.WriteLine(numero2.ToString().PadRight(7, '0'));
        }

        static void FundamentosString4()
        {
            var oracion = "Bienvenidos al curso de C#";
            var contiene1 = oracion.Contains("Z");
            var contiene2 = oracion.Contains("C#");
            var espacio = oracion.IndexOf(' ');
            var subCadena = oracion.Substring(0, espacio);
            var oracionReplace = oracion.Replace("e", "3");
        }

        static void FundamentosString5()
        {
            var animales = "TIGRE/ELEFANTE-LEON-MUCIELAGO-/-TORTUGA";

            var arreglo1 = animales.Split('-','/');
            var arreglo2 = animales.Split(new char[] { '-', '/' }, StringSplitOptions.RemoveEmptyEntries);

            var animalesSeparadosPorComa = string.Join("\n", arreglo2);
        }

        static void FundamentosString6()
        {
            var nombre = "Sergio";
            var pais = "Chile";
            var anio = 2000;
            var frase1 = string.Format("{0} Nacido el año {1} en el pais {2}", nombre, anio, pais);
            var frase2 = $"{nombre} nacido el año {anio} en el pais {pais}";

        }
    }
}
