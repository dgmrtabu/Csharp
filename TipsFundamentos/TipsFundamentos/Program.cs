using System;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;

namespace TipsFundamentos
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var num1 = 10;
        //    var num2 = 20;
        //    var factor = 100;
        //    var resultadoSuma = Suma(num1, num2);
        //    WriteLine($"La suma es: {resultadoSuma}");

        //    var resultadoOperacion = Operaciones(num1, num2, false);
        //    WriteLine($"La suma es: {resultadoOperacion.Suma}, la multiplicaciones> {resultadoOperacion.Multiplicacion}");

        //    var resultadoOperacion2 = Operaciones(num1, num2, true);
        //    WriteLine($"La suma es: {resultadoOperacion2.Suma}, la multiplicaciones> {resultadoOperacion2.Multiplicacion}");

        //    (int Suma, int Multiplicacion) Operaciones(int x, int y, bool utilizarFactor)
        //    {
        //        return (x + y +(utilizarFactor ? factor : 0), x *y * (utilizarFactor ? factor : 1));
        //    }

        //    int Suma(int x, int y)
        //    {
        //        return x + y;
        //    }

        //    Read();
        //}

        //static void Main(string[] args)
        //{
        //    var tiempo = new Stopwatch();

        //    tiempo.Start();
        //    for(int i = 0; i<1000000; i++)
        //    {

        //    }
        //    tiempo.Stop();

        //    WriteLine($"Duracion {tiempo.Elapsed.TotalMilliseconds} ms");

        //    tiempo.Reset();
        //    tiempo.Start();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        System.Threading.Thread.Sleep(500);
        //    }
        //    tiempo.Stop();

        //    Read();
        //}

        //static void Main(string[] args)
        //{
        //    Ejemplo3();
        //    Read();
        //}

        //static void Ejemplo1()
        //{
        //    var numero = int.MaxValue;

        //    try
        //    {
        //        var suma = checked(numero + 1);
        //    }
        //    catch(Exception ex)
        //    {
        //        WriteLine(ex.Message);
        //    }
        //}
        //static void Ejemplo2()
        //{
        //    var numero = 100_000;
        //    var cuadrado = 0;

        //    try
        //    {
        //        cuadrado = checked(numero * numero);
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteLine(ex.Message);
        //    }
        //}
        //static void Ejemplo3()
        //{
        //    var numero = 100_000;
        //    var numero2 = int.MaxValue;
        //    var cuadrado = 0;

        //    try
        //    {
        //        checked
        //        {
        //            var suma = numero2 - 1;
        //            cuadrado = checked(numero * numero);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteLine(ex.Message);
        //    }
        //}

        static void Main(string[] args)
        {
            var lista = new List<long> { 1000, 3_000_000, 700_000, 9_000_000_000};

            foreach(var item in lista)
            {
                WriteLine(item);
            }
            Read();
        }
    }
}
