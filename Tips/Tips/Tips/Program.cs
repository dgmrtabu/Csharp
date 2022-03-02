using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

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

        //static void Main(string[] args)
        //{
        //    //MetodoSinRetorno1((5, 8));
        //    var resultado = Operaciones2(5);
        //    var (mult, suma) = Operaciones2(5);
        //    (var mult1, var suma1) = Operaciones2(5);
        //    var(mult2, _) = Operaciones2(5);
        //    Console.WriteLine($"Multiplicacion: {resultado.Multiplicacion}, Suma: {resultado.Suma}");
        //    Console.Read();

        //}

        //static(int Multiplicacion, int Suma) Operaciones2(int numero)
        //{
        //    return (numero * numero, numero + numero);
        //}

        //static (int, int) Operaciones1(int numero)
        //{
        //    return (numero * numero, numero + numero);
        //}

        //static void MetodoSinRetorno1((int, int) parametro) {

        //    Console.WriteLine(parametro.Item1);
        //    Console.WriteLine(parametro.Item2);
        //}

        //static void MetodoSinRetorno2((int Num1, int Nume2) parametro)
        //{

        //    Console.WriteLine(parametro.Item1);
        //    Console.WriteLine(parametro.Item2);
        //}
        //static void Main(string[] args)
        //{
        //    int numRef = 0;
        //    CalculoRef(ref numRef );
        //    int numOut;
        //    CalculoOut(out numOut);
        //    Console.Read();

        //}

        //static void CalculoRef(ref int numero)
        //{
        //    numero++;
        //    numero = 25;
        //}
        //static void CalculoOut(out int numero)
        //{
        //    //numero++;
        //    numero = 25;
        //}

        //static void Main(string[] args)
        //{
        //    ImprimirCuadrado(5);
        //    var num = Cuadrado(10);
        //    Console.WriteLine($"El numero al cuadrado es:{ num }");
        //    Console.Read();
        //}

        //static void ImprimirCuadrado(int numero) => Console.WriteLine($"{numero} al cuadrado es = {numero * numero}");

        //static int Cuadrado(int numero) => numero * numero;

        //static void Main(string[] args)
        //{
        //    WriteLine($"El numero es truncado es { Truncate(4.67m)}");
        //    WriteLine($"El numero redondeado es { Truncate(4.67m)}");
        //    Read();
        //}

        //static void Main(string[] args)
        //{
        //    int? num1 = null;
        //    int? num2 = 2;
        //    int? num3 = null;

        //    var numero1 = num1 ?? num2 ?? num3;
        //    var numero2 = num1 ?? num2 ?? num3 ?? 0;
        //    WriteLine($"{numero1}");
        //    WriteLine($"{numero2}");
        //    Read();
        //}

        //static void Main(string[] args)
        //{
        //    EjemploNullCondicional2();
        //    Read();
        //}

        //static void EjemploNullCondicional1()
        //{
        //    List<int> listaNumeros = null;
        //    //List<int> listaNumeros = new List<int> { 1,2};
        //    if (/*listaNumeros != null && */listaNumeros?.Count > 0)
        //    {
        //        WriteLine("La lista tiene elementos");
        //    }
        //    else
        //    {
        //        WriteLine("La lista tiene 0 elementos");
        //    }

        //    if ((listaNumeros?.Count ?? 0) > 2)
        //    {
        //        WriteLine("La lista tiene elementos");
        //    }
        //    else
        //    {
        //        WriteLine("La lista tiene 2 elementos");
        //    }
        //}

        //static void EjemploNullCondicional2()
        //{
        //    Persona persona = null;
        //    var apellido1 = persona?.Apellido;
        //    var apellido2 = persona?.Apellido ?? string.Empty;

        //    var largoApellidos1 = persona?.Apellido.Length;
        //    //var largoApellidos2 = (persona?.Apellido).Length;

        //    List<Persona> listaPersona = null;
        //    if(listaPersona?.Count > 0)
        //    {
        //        // Acciones
        //    }

        //    var apellidoLinq = listaPersona?.FirsOrDefault()?.Apellido;
        //}


        //class Persona
        //{
        //    public int Id { get; set; }
        //    public string Nombre { get; set; }
        //    public string Apellido { get; set; }
        //}

        static void Main(string[] args)
        {
            MetodoIsAsignacionDirecta();
            Read();
        }

        static void MetodoIs()
        {
            var arrayObjetos = new object[6];
            arrayObjetos[0] = new Prueba();
            arrayObjetos[1] = "Mi String";
            arrayObjetos[2] = 125;
            arrayObjetos[3] = new DateTime(2020,1,1);
            arrayObjetos[4] = "1000";
            arrayObjetos[5] = null;

            for(int i =0; i< arrayObjetos.Length; i++)
            {
                WriteLine();
                if (arrayObjetos[i] is DateTime)
                {
                    WriteLine($"{i}:{arrayObjetos[i]} es un campo fecha");
                }
                else
                {
                    WriteLine($"{i}: No es un  campo fecha");
                }
            }
        }

        static void MetodoAs()
        {
            var arrayObjetos = new object[6];
            arrayObjetos[0] = new Prueba();
            arrayObjetos[1] = "Mi String";
            arrayObjetos[2] = 125;
            arrayObjetos[3] = new DateTime(2020, 1, 1);
            arrayObjetos[4] = "1000";
            arrayObjetos[5] = null;

            for (int i = 0; i < arrayObjetos.Length; i++)
            {
                var info = arrayObjetos[i] as DateTime?;
                WriteLine();
                if (info != null)
                {
                    WriteLine($"{i}:{info.Value.AddDays(15)}");
                }
                else
                {
                    WriteLine($"{i}: No es un  campo fecha");
                }
            }
        }

        static void MetodoIsAsignacionDirecta()
        {
            var arrayObjetos = new object[6];
            arrayObjetos[0] = new Prueba();
            arrayObjetos[1] = "Mi String";
            arrayObjetos[2] = 125;
            arrayObjetos[3] = new DateTime(2020, 1, 1);
            arrayObjetos[4] = "1000";
            arrayObjetos[5] = null;

            for (int i = 0; i < arrayObjetos.Length; i++)
            {
                WriteLine();
                if (arrayObjetos[i] is DateTime fecha)
                {
                    WriteLine($"{i}: esto es una fecha --> {fecha}");
                }
                else if (arrayObjetos[i] is int numero || (arrayObjetos[i] is string strAux && int.TryParse(strAux, out numero)))
                {
                    WriteLine($"{i}: esto es un {(arrayObjetos[i] is int ? "int" : "string/int")}-> {numero}");
                }
                else if (arrayObjetos[i] is string str)
                {
                    WriteLine($"{i}: esto es una cadena --> {str}");
                }
                else
                {
                    WriteLine($"{i}: Es desconocido");
                }

                switch (arrayObjetos[i])
                {
                    case DateTime swFecha:
                        WriteLine($"{i}: esta es una fecha --> {swFecha}");
                        break;
                    case var swNum when(swNum is int numero || (swNum is string strAux && int.TryParse(strAux, out numero))):
                        WriteLine($"{i}: esto es un {(swNum is int ? "int" : "string/int")}-> {numero}");
                        break;
                    case string swStr:
                        WriteLine($"{i}: esta es una cadena --> {swStr}");
                        break;
                    default:
                        WriteLine($"{i}: Es desconocido");
                        break;
                }
            }
        }
    }

    class Prueba { }
}
