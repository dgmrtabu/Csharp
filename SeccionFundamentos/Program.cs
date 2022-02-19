using System;
using System.Collections;
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
            var numeroMayor = obtenerMayor(5, 10,12,25,5,3);
            Console.Write($"El numero mayor es: { numeroMayor }");
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

        static void FundamentosFecha4() {

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
            var tubla2 = Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, "");
            var tubla3 = Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, Tuple.Create(1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, ""));

        }

        static void FundamentosValueTuble()
        {
            ValueTuple<int, int> tupla1 = (1, 2);
            (int, int) tupla2 = (1, 2);
            var tupla3 = (1, 2);
            var tupla4 = (1, 2, true, false, new DateTime(), new DateTime(2022, 1, 1), string.Empty, "", 1, 2, 3, 4, 5, 6, 7);
            var personaje = (1, "Hari", "Seldon", new DateTime(2500, 1, 1));

            (int Id, string Nombre, string Apellido, DateTime FechaNacimiento) datosPersona1 = (1, "Isaac", "Asimov", new DateTime(1920, 1, 2));

            var datosPersona2 = (Id: 1, Nombre: "Dan", Apellido: "Simons", FechaNacimiento: new DateTime(1920, 1, 2));

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

        static void ArraryListAgregar()

        {
            var arrayList1 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };

            var arrayList2 = new ArrayList();

            arrayList2.Add(1);
            arrayList2.Add("Mi Cadena");
            arrayList2.Add(new DateTime(2020, 1, 1));
            arrayList2.Add(125.45m);
            arrayList2.Add(Guid.NewGuid());

            var arrayList3 = new ArrayList() { "A", "B", "C" };
            arrayList3.AddRange(arrayList2);

            var arrayList4 = new ArrayList() { "A", "B", "C" };
            arrayList4.Insert(1, 1);

            var arrayList5 = new ArrayList() { "A", "B", "C" };
            arrayList5.InsertRange(1, arrayList2);
        }

        static void ArraryListEliminar() {
            var arrayList1 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };
            arrayList1.Remove("Mi Cadena");

            var arrayList2 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };
            arrayList2.RemoveAt(2);

            var arrayList3 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };
            arrayList3.RemoveRange(1, 3);
            arrayList3.Clear();

        }

        static void ArraryListAcceder()
        {
            var arrayList1 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };

            var primerElemento = (int)arrayList1[0];
            var segundoElemento = (string)arrayList1[1];
            var tercerElemento = (DateTime)arrayList1[2];
            var tercerElemento2 = arrayList1[2];

        }

        static void ArraryListInteraccion() {

            var arrayList1 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }

        }

        static void ArraryListOtros()
        {
            var arrayList1 = new ArrayList() { 1, "Mi Cadena", new DateTime(2020, 1, 1), 125.45m, Guid.NewGuid() };

            Console.WriteLine($"Contiene un 1: { arrayList1.Contains(1)}");
            Console.WriteLine($"Contiene un 100: { arrayList1.Contains(100)}");
            Console.WriteLine($"Contiene fecha '2020-01-01': { arrayList1.Contains(new DateTime(2020, 1, 1))}");
            Console.WriteLine($"Contiene fecha '2020-01-02': { arrayList1.Contains(new DateTime(2020, 1, 2))}");
            Console.WriteLine();
            Console.WriteLine();

            arrayList1.Reverse();

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            var arrayList2 = new ArrayList() { "Z", "X", "C", "B", "A" };

            arrayList2.Sort();

            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
        }

        static void SortedListAgregar()
        {
            var sortedList1 = new SortedList() { { 2, "Dos" }, { 1, "Uno" }, { 3, "Tres" } };

            var sortedList2 = new SortedList();
            sortedList2.Add(500, new DateTime(2022, 1, 1));
            sortedList2.Add(15, new DateTime(2022, 1, 2));
            sortedList2.Add(5, new DateTime(2022, 1, 2));
            sortedList2.Add(25, new DateTime(2022, 1, 2));
            sortedList2.Add(50, new DateTime(2022, 1, 2));
            sortedList2.Add(10, new DateTime(2022, 1, 3));
            //sortedList2.Add(10, new DateTime(2022, 1, 3));
            //sortedList2.Add("100", new DateTime(2022, 1, 3));

            var sortedList3 = new SortedList();
            sortedList3.Add("Patricio", 1);
            sortedList3.Add("Jorge", Guid.NewGuid());
            sortedList3.Add("Alex", new DateTime(2022, 1, 2));

            var sortedList4 = new SortedList()
            {
                { 2, 1500 },
                { 4, 1500 },
                { 1, 1500 },
                { 3, 1500 },
            };

            var sortedList5 = new SortedList()
            {
                {"1",1 },
                {"2",Guid.NewGuid() },
                {"tres","Mi cadena" },
                {"cuatro",new DateTime(2022,1,1) },
            };


        }

        static void SortedListEliminacion()
        {
            var sortedList1 = new SortedList()
            {
                { 2, 150 },
                { 4, 1500 },
                { 1, 250 },
                { 3, 300 },
                { 7, 400 },
                { 8, 1000 },
                { 10, 90 },
            };

            sortedList1.Remove(4);

            var sortedList2 = new SortedList()
            {
                { 2, 150 },
                { 4, 1500 },
                { 1, 250 },
                { 3, 300 },
                { 7, 1000 },
                { 8, 90 },
                { 10, 400 },
            };

            sortedList2.RemoveAt(4);
        }

        static void SortedListAcceso()


        {
            var sortedList1 = new SortedList()
            {
                {2, new DateTime(1920,1,1) },
                {4, new DateTime(1940,1,1) },
                {1, new DateTime(1910,1,1) },
                {3, new DateTime(1930,1,1) },
                {7, new DateTime(1970,1,1) },
                {8, new DateTime(1980,1,1) },
                {10, new DateTime(2000,1,1) },
            };

            var fecha1 = (DateTime)sortedList1[10]; //Obtener valor por llave
            var fecha2 = sortedList1.GetByIndex(0); //Obtener valor por indice
            var key = sortedList1.GetKey(0); //Obtener llave por indice
        }

        static void SortedListComprobar()
        {
            var sortedList1 = new SortedList()
            {
                {2, new DateTime(1920,1,1) },
                {4, new DateTime(1940,1,1) },
                {1, new DateTime(1910,1,1) },
                {3, new DateTime(1930,1,1) },
                {7, new DateTime(1970,1,1) },
                {8, new DateTime(1980,1,1) },
                {10, new DateTime(2000,1,1) },
            };

            var contiene_2 = sortedList1.Contains(2); //Existe
            var contiene_6 = sortedList1.Contains(6); //No Existe

            var contieneKey_4 = sortedList1.ContainsKey(2); //Existe
            var contieneKey_6 = sortedList1.ContainsKey(6); //No Existe

            var contieneValor_Fecha = sortedList1.ContainsValue(new DateTime(1920, 1, 1)); //Existe
            var contieneValor_Otro = sortedList1.ContainsValue("Otro"); //No Existe
        }

        static void SortedListCiclos()
        {
            var sortedList1 = new SortedList()
            {
                {2, new DateTime(1920,1,1) },
                {4, new DateTime(1940,1,1) },
                {1, new DateTime(1910,1,1) },
                {3, new DateTime(1930,1,1) },
                {7, new DateTime(1970,1,1) },
                {8, new DateTime(1980,1,1) },
                {10, new DateTime(2000,1,1) },
            };

            Console.WriteLine($"---------- For1 ----------");
            for (int i = 0; i < sortedList1.Count; i++)
            {
                Console.WriteLine($"Key: {sortedList1.GetKey(i)}, valor: {sortedList1.GetByIndex(i)}");
            }
            Console.WriteLine();
            Console.WriteLine($"---------- For2 ----------");
            for (int i = 0; i < sortedList1.Count; i++)
            {
                Console.WriteLine($"Key: {sortedList1.GetKey(i)}, valor: {sortedList1[sortedList1.GetKey(i)]}");
            }
            Console.WriteLine();
            Console.WriteLine($"---------- ForEach ----------");
            foreach (DictionaryEntry item in sortedList1)
            {
                Console.WriteLine($"key:{ item.Key}, valor: {item.Value}");
            }

            var listaKey = sortedList1.GetKeyList();
            Console.WriteLine();
            Console.WriteLine($"Lista key");
            foreach (var item in listaKey)
            {
                Console.WriteLine($"Key:{ item }");
            }

            var listaValores = sortedList1.GetValueList();
            Console.WriteLine();
            Console.WriteLine($"Lista Valores");
            foreach (var item in listaValores)
            {
                Console.WriteLine($"Valores:{ item}");
            }

        }

        static void SortedListGenerico()
        {
            var lista = new System.Collections.Generic.SortedList<int, string>();
            lista.Add(80, "Mi cadena ochenta");
            lista.Add(20, "Mi cadena veinte");
            lista.Add(30, "Mi cadena treinta");

            var miStr = lista[20];
            lista.Remove(50);

            var listaKeys = lista.Keys;
            var listaValores = lista.Keys;

            foreach (var item in lista)
            {
                Console.WriteLine($"key:{item.Key}, valor{item.Value}");
            }
        }

        static void HashtableAgregar()
        {
            var hashTable1 = new Hashtable() { { 2, "Dos" }, { 1, "Uno" }, { 3, "Tres" } };

            var hasTable2 = new Hashtable();
            hasTable2.Add(500, new DateTime(2022, 1, 1));
            hasTable2.Add("15", new DateTime(2022, 1, 2));
            hasTable2.Add(15, new DateTime(2022, 1, 2));
            hasTable2.Add("1", "Uno");

            var hasTable3 = new Hashtable();
            hasTable3.Add(DateTime.Today, 1);
            hasTable3.Add("Jorge", Guid.NewGuid());
            hasTable3.Add("Alex", new DateTime(2022, 1, 2));

            var hasTable4 = new Hashtable()
            {
                {1,1},
                {2,Guid.NewGuid()},
                {"tres", "Mi cadena"},
                {"cuatro", new DateTime(2022,1,1)},
            };

        }

        static void HashtableEliminacion() {

            var hasTable1 = new Hashtable()
            {
                { "2", 150 },
                { 2, new DateTime(2022, 1, 1)},
                {"tres", "Mi cadena"},
                {1, Guid.NewGuid()},
                {125m, 12.5m},
                {"Nombre", null},
            };

            hasTable1.Remove(4);
            hasTable1.Remove(1);
            hasTable1.Remove("tres");
            hasTable1.Clear();

        }

        static void HashTableAcceso() {

            var hashTable1 = new Hashtable()
            {
                { "2", 150 },
                { 2, new DateTime(2022, 1, 1)},
                {"tres", "Mi cadena"},
                {1, Guid.NewGuid()},
                {125m, 12.5m},
                {"Nombre", null},
            };

            var num1 = (int)hashTable1["2"];
            var fecha = (DateTime)hashTable1[2];
            var decimal1 = (decimal)hashTable1[125m];
        }

        static void HashTableComprobar()
        {
            var hashTable1 = new Hashtable()
            {
                { "2", 150 },
                { 2, new DateTime(2022, 1, 1)},
                {"tres", "Mi cadena"},
                {1, Guid.NewGuid()},
                {125m, 12.5m},
                {"Nombre", null},
            };

            var contiene_2 = hashTable1.Contains(2); //Retorna true
            var contiene_6 = hashTable1.Contains(6); //Retorna false

            var contieneKey_2 = hashTable1.ContainsKey(2); //Retorna true
            var contieneKey_6 = hashTable1.ContainsKey(6); //Retorna false

            var contieneValor_Fecha = hashTable1.ContainsValue(new DateTime(2022, 1, 1)); //Retorna true
            var contieneValor_Otro = hashTable1.ContainsValue("Otro"); //Retorna false

        }
        static void HashTableCiclos() {
            var hastTable1 = new Hashtable()
            {
                { "2", 150 },
                { 2, new DateTime(2022, 1, 1)},
                {"tres", "Mi cadena"},
                {1, Guid.NewGuid()},
                {125m, 12.5m},
                {"Nombre", null},
            };

            Console.WriteLine();
            Console.WriteLine($"---------- ForEach ----------");
            foreach (DictionaryEntry item in hastTable1)
            {
                Console.WriteLine($"key: {item.Key }, valor: {item.Value}");
            }

            var listaKey = hastTable1.Keys;
            Console.WriteLine();
            Console.WriteLine($"Lista Key");
            foreach (var item in listaKey)
            {
                Console.WriteLine($"key: {item}");
            }

            var listaValores = hastTable1.Values;
            Console.WriteLine();
            Console.WriteLine($"Lista Valores");
            foreach (var item in listaValores)
            {
                Console.WriteLine($"Valores: {item}");
            }
        }

        static void StackAgregar()
        {
            var stack1 = new Stack();

            stack1.Push("Mi Cadena");
            stack1.Push(1);
            stack1.Push(Guid.NewGuid());
            stack1.Push(new DateTime(2022, 1, 1));
            stack1.Push(125m);
        }

        static void StackEliminar()
        {
            var stack1 = new Stack();

            stack1.Push("Mi Cadena");
            stack1.Push(1);
            stack1.Push(Guid.NewGuid());
            stack1.Push(new DateTime(2022, 1, 1));
            stack1.Push(125m);

            var eliminar1 = stack1.Pop();
            var eliminar2 = stack1.Pop();
            var eliminar3 = stack1.Pop();

            stack1.Push(new DateTime(1990, 1, 1));

            var eliminar4 = stack1.Pop();

            stack1.Clear();
        }

        static void StackComprobar()
        {
            var stack1 = new Stack();

            stack1.Push("Mi Cadena");
            stack1.Push(1);
            stack1.Push(Guid.NewGuid());
            stack1.Push(new DateTime(2022, 1, 1));
            stack1.Push(125m);

            var primeroPila = stack1.Peek();

            stack1.Pop();
            primeroPila = stack1.Peek();

            var contiene_1 = stack1.Contains(1);
            var contiene_10 = stack1.Contains(10);
            var cantidad = stack1.Count;

        }

        static void StackCiclos()
        {
            var stack1 = new Stack();

            stack1.Push("Mi Cadena");
            stack1.Push(1);
            stack1.Push(Guid.NewGuid());
            stack1.Push(new DateTime(2022, 1, 1));
            stack1.Push(125m);

            var stackArray = stack1.ToArray();
            Console.WriteLine("---------- For ----------");
            for (int i = 0; i < stackArray.Count(); i++)
            {
                Console.WriteLine(stackArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("---------- Foreach ----------");
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------- While ----------");
            while (stack1.Count > 0)
            {
                Console.WriteLine(stack1.Pop());
            }
        }

        static void StackGenerico()
        {
            var stack1 = new System.Collections.Generic.Stack<int>();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
            stack1.Pop();
            var primeroPila = stack1.Peek();
        }
        static void QueueAgregar()
        {
            var queue1 = new Queue();

            queue1.Enqueue("Mi cadena");
            queue1.Enqueue(1);
            queue1.Enqueue(Guid.NewGuid());
            queue1.Enqueue(new DateTime(2022, 1, 1));
            queue1.Enqueue(125m);

        }
        static void QueueEliminar()
        {
            var queue1 = new Queue();

            queue1.Enqueue("Mi cadena");
            queue1.Enqueue(1);
            queue1.Enqueue(Guid.NewGuid());
            queue1.Enqueue(new DateTime(2022, 1, 1));
            queue1.Enqueue(125m);

            var eliminar1 = queue1.Dequeue();
            var eliminar2 = queue1.Dequeue();
            var eliminar3 = queue1.Dequeue();

            queue1.Enqueue(new DateTime(1990, 1, 1));
            var eliminar4 = queue1.Dequeue();

            queue1.Clear();
        }
        static void QueueComprobar() {
            var queue1 = new Queue();

            queue1.Enqueue("Mi cadena");
            queue1.Enqueue(1);
            queue1.Enqueue(Guid.NewGuid());
            queue1.Enqueue(new DateTime(2022, 1, 1));
            queue1.Enqueue(125m);

            var primeroCola = queue1.Peek();
            queue1.Dequeue();
            primeroCola = queue1.Peek();

            var contiene_1 = queue1.Contains(1);
            var contiene_10 = queue1.Contains(10);
            var cantidad = queue1.Count;
        }
        static void QueueCiclos() {

            var queue1 = new Queue();

            queue1.Enqueue("Mi cadena");
            queue1.Enqueue(1);
            queue1.Enqueue(Guid.NewGuid());
            queue1.Enqueue(new DateTime(2022, 1, 1));
            queue1.Enqueue(125m);

            var queuekArray = queue1.ToArray();
            Console.WriteLine("---------- For ----------");
            for (int i = 0; i < queuekArray.Count(); i++)
            {
                Console.WriteLine(queuekArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("---------- Foreach ----------");
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------- While ----------");
            while (queue1.Count > 0)
            {
                Console.WriteLine(queue1.Dequeue());
            }
        }
        static void QueueGenerico() {

            var queue1 = new System.Collections.Generic.Queue<int>();

            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            queue1.Enqueue(5);
            queue1.Dequeue();
            var primeroPila = queue1.Peek();
        }

        static void DiccionarioAgregar()
        {
            var dicionario1 = new Dictionary<int, string>()
            {

                { 2,"Dos"},
                { 1,"Uno"},
                { 3,"Tres"},

            };

            var dicionario2 = new Dictionary<int, string>()
            {

                [2] = "Dos",
                [1] = "Uno",
                [3] = "Tres",

            };

            var diccionario3 = new Dictionary<int, DateTime>();
            diccionario3.Add(1920, new DateTime(1920, 5, 1));
            diccionario3.Add(1950, new DateTime(1950, 5, 1));
            diccionario3.Add(1980, new DateTime(1980, 5, 1));
            diccionario3.Add(2010, new DateTime(2010, 5, 1));
            //diccionario3.Add(2010, new DateTime(1, 1, 1));
        }

        static void DiccionarioEliminacion()
        {
            var diccionario1 = new Dictionary<string, int>()
            {
                ["Dos"] = 2,
                ["Uno"] = 1,
                ["Tres"] = 3,
                ["Numero"] = 5,
            };

            var elimnacion1 = diccionario1.Remove("Cuatro");
            var elimnacion2 = diccionario1.Remove("Uno");

            diccionario1.Clear();
        }
        static void DiccionarioAcceso()
        {
            var diccionario1 = new Dictionary<string, int>()
            {
                ["Dos"] = 2,
                ["Uno"] = 1,
                ["Tres"] = 3,
                ["Numero"] = 5,
            };

            var num1 = diccionario1["Dos"];
            var num2 = diccionario1["Numero"];
        }

        static void DiccionarioComprobar()
        {
            var diccionario1 = new Dictionary<string, int>()
            {
                ["Dos"] = 2,
                ["Uno"] = 1,
                ["Tres"] = 3,
                ["Numero"] = 5,
            };

            var contiene_1 = diccionario1.Contains(new KeyValuePair<string, int>("Dos", 2)); //Devuelve true
            var contiene_2 = diccionario1.Contains(new KeyValuePair<string, int>("Numero", 4)); //Devuelve false

            var contieneKey_2 = diccionario1.ContainsKey("Dos");
            var contieneKey_4 = diccionario1.ContainsKey("Cuatro");

            var contieneValor_5 = diccionario1.ContainsValue(5);
            var contieneValor_4 = diccionario1.ContainsValue(4);

        }

        static void DiccionarioCiclos()
        {
            var diccionario1 = new Dictionary<string, int>()
            {
                ["Dos"] = 2,
                ["Uno"] = 1,
                ["Tres"] = 3,
                ["Numero"] = 5,
            };

            Console.WriteLine();
            Console.WriteLine("---------- Foreach ----------");
            foreach (var item in diccionario1)
            {
                Console.WriteLine($"Key: {item.Key}, valor: {item.Value}");
            }

            var listaKey = diccionario1.Keys;
            Console.WriteLine();
            Console.WriteLine($"Lista Key");
            foreach (var item in listaKey)
            {
                Console.WriteLine($"Key: {item}");
            }

            var listaValores = diccionario1.Values;
            Console.WriteLine();
            Console.WriteLine($"Lista Valores");
            foreach (var item in listaValores)
            {
                Console.WriteLine($"Valores: {item}");
            }
        }

        static void DiccionarioOrdenando()
        {
            var diccionario1 = new Dictionary<string, int>()
            {
                ["Dos"] = 2,
                ["Uno"] = 1,
                ["Tres"] = 3,
                ["Numero"] = 5,
            };

            diccionario1.Add("Diez", 10);

            var valor = diccionario1["numero"];
            var contiene_1 = diccionario1.Contains(new KeyValuePair<string, int>("Dos", 2));
            var contieneKey_2 = diccionario1.ContainsKey("Dos");
            var contieneValor_4 = diccionario1.ContainsValue(4);
        }
        static void ListaAgregar()
        {
            var lista1 = new List<int>() { 1, 2, 3, 4, 5 };

            var lista2 = new List<string>() { "Unos", "Dos", "Tres" };

            var lista3 = new List<int>();
            lista3.Add(25);
            lista3.Add(50);
            lista3.Add(100);
            lista3.AddRange(lista1);

            var lista4 = new List<int>();
            lista4.Add(10);
            lista4.Add(1000);
            lista4.Insert(1, 100);

            var lista5 = new List<int>();
            lista5.Add(10);
            lista5.Add(1000);
            lista5.InsertRange(1, lista1);
        }
        static void ListaEliminacion() {
            var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
            var eliminacion1 = lista1.Remove(3);

            var lista2 = new List<int>() { 1, 2, 3, 4, 5 };
            lista2.RemoveAt(4);

            var lista3 = new List<int>() { 1, 2, 3, 4, 5 };
            lista3.RemoveRange(1, 2);

            var lista4 = new List<int>() { 1, 2, 3, 4, 5 };
            lista4.Clear();
        }
        static void ListaAcceso()
        {
            var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
            var num1 = lista1[2];
            var totalElementos = lista1.Count;
        }
        static void ListaComprobar()
        {
            var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
            var contiene_1 = lista1.Contains(3); // Devuelve true
            var contiene_2 = lista1.Contains(10); // Devuelve false
        }
        static void ListaCiclos()
        {
            var lista1 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine($"---------- For ----------");
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"---------- Foreach ----------");
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------- ListaForEach ----------");
            lista1.ForEach(item =>
            {
                Console.WriteLine($"{item}");
            });
        }

        static int obtenerMayor(/*int num1, int num2*/params int[] numeros)
        {
            var numMayor = 0;

            foreach (var item in numeros)
            {
                if(numMayor < item)
                {
                    numMayor = item;
                }
            }
            //return num1 > num2 ? num1 : num2;
            return numMayor;
        }

    }

}