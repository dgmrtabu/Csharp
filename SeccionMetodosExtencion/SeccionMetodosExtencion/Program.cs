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
            //var fecha1 = new DateTime(2000, 1, 1);
            //var fecha2 = new DateTime(2000, 12, 31);
            //Console.WriteLine($"La fecha es {fecha1.ToString("dd-MM-yyyy")} la edad {fecha1.Ext_CalcularEdad()}");
            //Console.WriteLine($"La fecha es {fecha2.ToString("dd-MM-yyyy")} la edad {fecha2.Ext_CalcularEdad()}");
            //Console.WriteLine($"El mes de la fecha 1 es: {fecha1.Ext_MesNombre()} --- El mes de la fecha 2 es: {fecha2.Ext_MesNombre()}");

            //var fecha3 = new DateTime(2020, 1, 3);
            //Console.WriteLine($"Inicio de mes: {fecha3.Ext_ObtenerMesInicio().ToString("dd-MM-yyyy")} --- Termino de mes: {fecha3.Ext_ObtenerMesTermino().ToString("dd-MM-yyyy")}");
            //Console.WriteLine($"Inicio de semana: {fecha3.Ext_ObtenerSemanaInicio().ToString("dd-MM-yyyy")} --- Termino de semana: {fecha3.Ext_ObtenerSemanaTermino().ToString("dd-MM-yyyy")}");

            //var (mesInicio, mesTermino) = fecha3.Ext_ObtenerMesInicioTermino();
            //var (semanaInicio, semanaTermino) = fecha3.Ext_ObtenerSemanaInicioTermino();
            //Console.WriteLine($"Inicio de semana: {semanaInicio.ToString("dd-MM-yyyy")} --- Termino de semana: {semanaTermino.ToString("dd-MM-yyyy")}");

            //var semana = fecha3.Ext_ObtenerSemanaInicioTermino();
            //Console.WriteLine($"Inicio de semana: {semana.Item1.ToString("dd-MM-yyyy")} --- Termino de semana: {semana.Item2.ToString("dd-MM-yyyy")}");

            var numero1 = "1000";
            var numero2 = "1000,25";
            var numero3 = "17,25";
            var numero4 = "david";

            Console.WriteLine($"{numero1}: es entero: {numero1.Ext_EsNumeroEnteroValido()}, es porcentaje {numero1.Ext_EsPorcentajeValido()}");
            Console.WriteLine($"{numero2}: es entero: {numero2.Ext_EsNumeroEnteroValido()}, es porcentaje {numero2.Ext_EsPorcentajeValido()}");
            Console.WriteLine($"{numero3}: es entero: {numero3.Ext_EsNumeroEnteroValido()}, es porcentaje {numero3.Ext_EsPorcentajeValido()}");
            Console.WriteLine($"{numero4}: es entero: {numero4.Ext_EsNumeroEnteroValido()}, es porcentaje {numero4.Ext_EsPorcentajeValido()}");

            var fecha1 = "32-01-2020";
            var fecha2 = "texto";
            var fecha3 = "31-01-2020";
            var fecha4 = "2020-01-03";

            Console.WriteLine($"{fecha1}: es entero: {fecha1.Ext_EsFechaValida()} --> {(fecha1.Ext_EsFechaValida() ? fecha1.Ext_ToFecha().ToString():"")}");
            Console.WriteLine($"{fecha2}: es entero: {fecha2.Ext_EsFechaValida()} --> {(fecha2.Ext_EsFechaValida() ? fecha1.Ext_ToFecha().ToString():"")}");
            Console.WriteLine($"{fecha3}: es entero: {fecha3.Ext_EsFechaValida()} --> {(fecha3.Ext_EsFechaValida() ? fecha1.Ext_ToFecha().ToString():"")}");
            Console.WriteLine($"{fecha4}: es entero: {fecha4.Ext_EsFechaValida()} --> {(fecha4.Ext_EsFechaValida() ? fecha1.Ext_ToFecha().ToString():"")}");
            
        }
    }
}
