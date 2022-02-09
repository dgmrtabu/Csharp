using System;
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
        public static object DataTime { get; private set; }

        static void Main(string[] args)
        {
            FundamentosTiposAnonimos();
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

            var arreglo1 = animales.Split('-', '/');
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

            foreach (var item in oracion)
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

        static void FundamentosFecha1()
        {
            var fechaHoraHoy = DateTime.Now;
            var fechaHoy = DateTime.Today;
            var fechaMinima = DateTime.MinValue;
            var fechaMaxima = DateTime.MaxValue;
            var diaAnio = fechaHoy.DayOfYear;
            var diaSemana = fechaHoraHoy.DayOfWeek;
            var fecha1 = new DateTime(2020, 1, 1);

            var fechaTicMinima = DateTime.MinValue.Ticks;
            var fechaTicMaxima = DateTime.MaxValue.Ticks;

            var calcularTick = (10000000l * 60 * 60 * 24 * 365 * 1999) + (10000000l * 60 * 60 * 24 * (499 - 19 + 4));
            var fechaTicks = new DateTime(calcularTick);

        }

        static void FundamentosFecha2()
        {

            var fechaHoy = DateTime.Now;
            var fechaAddDay = fechaHoy.AddDays(1);
            var fechaAddMes = fechaHoy.AddMonths(1);
            var fechaAddAnios = fechaHoy.AddYears(1);

            var dias = DateTime.DaysInMonth(2022, 2);

            var finDeMes = new DateTime(2022, 2, DateTime.DaysInMonth(2022, 2));

            Console.WriteLine(finDeMes.ToString("dd-MM-yyyy"));
            Console.WriteLine(finDeMes.ToString("dddd, dd MMMM yyyy", new CultureInfo("es-cl")));
            Console.WriteLine(finDeMes.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-us")));
        }

        static void FundamentosFecha3()
        {
            var fecha1 = new DateTime(2022, 1, 1);

            var time = new TimeSpan(30, 20, 15);

            var fechaResultado = fecha1.Add(time);

            Console.WriteLine(fechaResultado);

            var fechaDif1 = new DateTime(2022, 1, 1);
            var fechaDif2 = new DateTime(2022, 1, 7, 12, 30, 0);

            var diferencia = fechaDif2.Subtract(fechaDif1);

            fechaDif1 += diferencia;

        }

        static void FundamentosFecha4(){

            var strFecha = "31-12-2000";
            var strFecha2 = "2000-01-01";

            string[] formatos = { "dd-MM-yyyy", "yyyy-MM-dd" };
            var esValido = DateTime.TryParseExact(strFecha2, formatos, new CultureInfo("es-cl"), DateTimeStyles.None, out var fecha);
            if (esValido)
            {
                Console.WriteLine(fecha);
            }
            else
            {
                Console.WriteLine("La transformacion no se p[udo realizar!!!");
            }
        }

        static void FundamentosGuid()
        {
            var variable1 = new Guid();
            var variable2 = Guid.NewGuid();
            var variable3 = new Guid("973e8457-6a1e-427f-87cf-b6f46a969d56");
        }

        static void FundamentosVariablesNulas()
        {
            //string cadena;
            //int num;
            //DateTime fecha;
            //Guid id;

            //Nullable<int> num;
            //Nullable<DateTime> fecha;
            //Nullable<Guid> id;

            int? num = null;
            DateTime? fecha = null;
            Guid? id = null;

            Console.WriteLine($"{num.HasValue}-- >{num.GetValueOrDefault()}");
            Console.WriteLine($"{fecha.HasValue}-- >{fecha.GetValueOrDefault()}");
            Console.WriteLine($"{id.HasValue}-- >{id.GetValueOrDefault()}");

            if (num.HasValue)
            {
                // Realiza accciones
            }

        }

        static void FundamentosTuble()
        {
            var tubla1 = Tuple.Create(1, "Esto es una cadena");
            var tubla2 = Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022,1,1), string.Empty, "");
            var tubla3 = Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022,1,1), string.Empty, Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, ""));

        }

        static void FundamentosValueTuble()
        {
            ValueTuple<int, int> tupla1 = (1, 2);
            (int, int) tupla2 = (1, 2);
            var tupla3 = (1, 2);
            var tupla4 = (1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, "",1,2,3,4,5,6,7);
            var personaje = (1, "Hari", "Seldon", new DateTime(2500, 1, 1));

            (int Id, string Nombre, string Apellido, DateTime FechaNacimiento) datosPersona1 = (1, "Isaac", "Asimov", new DateTime(1920, 1, 2));
            
            var datosPersona2  = (Id: 1, Nombre: "Dan", Apellido: "Simons", FechaNacimiento: new DateTime(1920, 1, 2));

            var lista = new List<(int Identificador, string Nombre, string ApellidoPaterno, DateTime Fecha)> { datosPersona1, datosPersona2, personaje };

            var apellidoP1 = lista[0].ApellidoPaterno;
            var apellidoP2 = lista[1].ApellidoPaterno;
            var apellidoP3 = lista[2].ApellidoPaterno;


        }

        static void FundamentosTiposAnonimos()
        {
            var tipoAnonimo = new { Id = 1, Nombre = "Isaac", Apellido = "Paterno", FechaNacimiento = new DateTime(1920, 1, 2) };

            var listaTipoAnonimo = new[]
            {
                new { Id = 1, Nombre = "Isaac", Apellido = "Paterno", FechaNacimiento = new DateTime(1920, 1, 2) }
            }.ToList();


        }
    }

}