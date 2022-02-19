using System;

namespace Tips
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var numeroMayor = ObtenerMayor(5, 10, 12, 25, 5, 3);

        //    Console.WriteLine($"El numero mayor es: {numeroMayor}");
        //    Console.WriteLine($"El numero mayor es: { ObtenerMayor(5, 10, 12, 25, 5, 3)}");
        //}

        //static int ObtenerMayor(/*int num1, int num2*/params int[] numeros)
        //{
        //    var numMayor = 0;

        //    foreach (var item in numeros)
        //    {
        //        if (numMayor < item)
        //        {
        //            numMayor = item;
        //        }
        //    }
        //    //return num1 > num2 ? num1 : num2;
        //    return numMayor;
        //}

        //static void Main(string[] args)
        //{

        //    Console.WriteLine(ObtenerString("Hari", "Seldon", 57));
        //    Console.WriteLine(ObtenerString("Hari", "Seldon"));
        //    Console.Read();
        //    //Console.WriteLine($"El numero mayor es: { ObtenerMayor(5, 10, 12, 25, 5, 3)}");
        //}

        //static string ObtenerString(string nombre, string apellido, int? edad = null)
        //{
        //    if(edad.HasValue){
        //        return $"La persona{nombre} {apellido} tiene {edad} anios.";
        //    }
        //    else
        //    {
        //        return $"La persona{nombre} {apellido} no tiene edad informada.";
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    var x = 10;
        //    var y = 15;

        //    Console.WriteLine($"X: {x}, Y:{y}");

        //    //var tmp = x;
        //    //x = y;
        //    //y = tmp;

        //    (x, y) = (y, x);

        //    Console.WriteLine($"X: {x}, Y:{y}");
        //    Console.Read();

        //}

        static void Main(string[] args)
        {
            //MetodoSinRetorno1((5, 8));
            var resultado = Operaciones2(5);
            var (mult, suma) = Operaciones2(5);
            (var mult1, var suma1) = Operaciones2(5);
            var(mult2, _) = Operaciones2(5);
            Console.WriteLine($"Multiplicacion: {resultado.Multiplicacion}, Suma: {resultado.Suma}");
            Console.Read();

        }

        static(int Multiplicacion, int Suma) Operaciones2(int numero)
        {
            return (numero * numero, numero + numero);
        }

        static (int, int) Operaciones1(int numero)
        {
            return (numero * numero, numero + numero);
        }

        static void MetodoSinRetorno1((int, int) parametro) {

            Console.WriteLine(parametro.Item1);
            Console.WriteLine(parametro.Item2);
        }

        static void MetodoSinRetorno2((int Num1, int Nume2) parametro)
        {

            Console.WriteLine(parametro.Item1);
            Console.WriteLine(parametro.Item2);
        }
    }

}
