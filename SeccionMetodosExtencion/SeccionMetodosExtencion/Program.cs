using SeccionMetodosExtencion.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionMetodosExtencion
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtencionesFecha();
            Console.Read();
        }

        static void ExtencionesFecha()
        {
            var fecha1 = new DateTime(2000, 1, 1);
            var fecha2 = new DateTime(2000, 12, 31);
            Console.WriteLine($"La fecha es {fecha1.ToString("dd-MM-yyyy")} la edad {fecha1.Ext_CalcularEdad()}");
            Console.WriteLine($"La fecha es {fecha2.ToString("dd-MM-yyyy")} la edad {fecha2.Ext_CalcularEdad()}");
            Console.WriteLine($"El mes de la fecha 1 es: {fecha1.Ext_MesNombre()} --- El mes de la fecha 2 es: {fecha2.Ext_MesNombre()}");

            var fecha3 = new DateTime(2020, 1, 3);
            Console.WriteLine($"Inicio de mes: {fecha3.Ext_ObtenerMesInicio().ToString("dd-MM-yyyy")} --- Termino de mes: {fecha3.Ext_ObtenerMesTermino().ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Inicio de semana: {fecha3.Ext_ObtenerSemanaInicio().ToString("dd-MM-yyyy")} --- Termino de semana: {fecha3.Ext_ObtenerSemanaTermino().ToString("dd-MM-yyyy")}");
        }
    }
}
