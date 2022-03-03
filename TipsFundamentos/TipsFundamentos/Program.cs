using System;
using static System.Console;
using System.Diagnostics;

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

        static void Main(string[] args)
        {
            var tiempo = new Stopwatch();

            tiempo.Start();
            for(int i = 0; i<1000000; i++)
            {

            }
            tiempo.Stop();

            WriteLine($"Duracion {tiempo.Elapsed.TotalMilliseconds} ms");

            tiempo.Reset();
            tiempo.Start();
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
            }
            tiempo.Stop();

            Read();
        }


    }
}
