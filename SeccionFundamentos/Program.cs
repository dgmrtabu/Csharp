﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            FundamentosNumeros5();
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

        static void FundamentosString7()
        {
            var str1 = "";
            var str2 = string.Empty;

            string str3 = null;
            var str4 = "    ";

            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));
            Console.WriteLine(string.IsNullOrEmpty(str3));
            Console.WriteLine(string.IsNullOrEmpty(str4));
            Console.WriteLine(string.IsNullOrWhiteSpace(str4));
        }

        static void FundamentosStringBuilder()
        {

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("mi frase");
            stringBuilder.AppendLine("Mi nueva linea");
            stringBuilder.AppendFormat("{0}, {1}, {2}", "Elefante", "Tigre", "Leon");
            stringBuilder.Insert(8, "\n");
            stringBuilder[0] = 'M';

            var stringFinal = stringBuilder.ToString();

            Console.Read();

            var tiempo = new Stopwatch();
            var str = string.Empty;
            var strSB = new StringBuilder();

            tiempo.Start();
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            tiempo.Stop();
            Console.WriteLine($"Tiempo {tiempo.Elapsed.TotalMilliseconds} ms");

            tiempo.Reset();

            tiempo.Start();
            for (int i = 0; i < 100000; i++)
            {
                strSB.Append(i.ToString());
            }
            tiempo.Stop();
            Console.WriteLine($"Tiempo {tiempo.Elapsed.TotalMilliseconds} ms");

        
        }
        static void FundamentosChar()
        {
            var caracter = "D";

            char.IsLetterOrDigit(' ');
            char.IsLetter(' ');
            char.IsDigit(' ');
            char.IsWhiteSpace(' ');
            char.IsPunctuation(' ');

            var oracion = "Esta es$$ una (98) prueba";
            var oracionSB = new StringBuilder();

            foreach(var item in oracion)
            {
                if (char.IsLetter(item) || char.IsWhiteSpace(item)) {

                    oracionSB.Append(item);
                }
            }

            var oracionLimpia = oracionSB.ToString();
        }

        static void FundamentosNumeros1()
        {
            var numero = 0;
            //Console.WriteLine(++numero);
            //Console.WriteLine(numero++);

            var num = ++numero;
            //var num = ++numero;

            Console.WriteLine(num);
        }

        static void FundamentosNumeros2()
        {
            var num1 = 1234.56789m;

            Console.WriteLine(num1.ToString("N0"));
            Console.WriteLine(num1.ToString("N1"));
            Console.WriteLine(num1.ToString("N2"));
            Console.WriteLine(num1.ToString("N3"));

            var num2 = 125000;

            Console.WriteLine(num2.ToString("N0"));


        }

        static void FundamentosNumeros3()
        {
            var num1 = int.Parse("123.456", NumberStyles.AllowThousands, new CultureInfo("es-cl"));
            var num2 = int.Parse("$123.456", NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol, new CultureInfo("es-cl"));
            var num3 = int.Parse("123,456", NumberStyles.AllowThousands, new CultureInfo("en-us"));

            //var num4 = 0;
            var pudoTransformar = int.TryParse("123.456", NumberStyles.AllowThousands, new CultureInfo("es-cl"), out var num4);
        }

        static void FundamentosNumeros4()
        {
            var num1 = 125.6475;

            Console.WriteLine(Math.Round(num1));
            Console.WriteLine(Math.Round(num1, 1));
            Console.WriteLine();
            Console.WriteLine(Math.Truncate(num1));
            Console.WriteLine(Math.Floor(num1));
            Console.WriteLine();
            Console.WriteLine(Math.Truncate(-4.0001m));
            Console.WriteLine(Math.Floor(-4.0001m));
            Console.WriteLine();
            Console.WriteLine(Math.Ceiling(num1));

        }

        static void FundamentosNumeros5()
        {
            var numDouble = 0.1d;
            var resultMultiplicacionDouble = numDouble * 10;
            var resultSumaDouble = numDouble + numDouble + numDouble + numDouble + numDouble + numDouble + numDouble + numDouble + numDouble + numDouble;

            var numDecimal = 0.1m;
            var resultMultiplicacionDecimal = numDecimal * 10;
            var resultSumaDecimal = numDecimal + numDecimal + numDecimal + numDecimal + numDecimal + numDecimal + numDecimal + numDecimal + numDecimal + numDecimal;
        }
    }
}