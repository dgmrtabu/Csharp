using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SeccionMetodosExtencion.ExtensionMethod
{
    public static class Extensiones
    {
        //public static int Ext_CalcularEdad(this DateTime valor)
        //{
        //    return DateTime.Now.AddTicks(-valor.Ticks).Year - 1;
        //}

        //public static string Ext_MesNombre(this DateTime valor)
        //{
        //    DateTimeFormatInfo info = new CultureInfo("en-us", false).DateTimeFormat;
        //    return info.GetMonthName(valor.Month);
        //}

        //public static DateTime Ext_ObtenerMesInicio(this DateTime valor)
        //{
        //    return new DateTime(valor.Year, valor.Month, 1);
        //}
        //public static DateTime Ext_ObtenerMesTermino(this DateTime valor)
        //{
        //    return new DateTime(valor.Year, valor.Month, DateTime.DaysInMonth(valor.Year, valor.Month));
        //}

        //public static DateTime Ext_ObtenerSemanaInicio(this DateTime valor)
        //{
        //    var fecha = valor;
        //    var dias = 1 - (fecha.DayOfWeek != DayOfWeek.Sunday ? (double)fecha.DayOfWeek : 7d);
        //    return fecha.AddDays(dias);
            
        //}
        //public static DateTime Ext_ObtenerSemanaTermino(this DateTime valor)
        //{
        //    var fecha = valor;
        //    var dias = 7 - (fecha.DayOfWeek != DayOfWeek.Sunday ? (double)fecha.DayOfWeek : 7d);
        //    return fecha.AddDays(dias);
        //}

        //public static (DateTime, DateTime) Ext_ObtenerMesInicioTermino(this DateTime valor)
        //{
        //    return (valor.Ext_ObtenerMesInicio(), valor.Ext_ObtenerMesTermino());
        //}

        //public static (DateTime, DateTime) Ext_ObtenerSemanaInicioTermino(this DateTime valor)
        //{
        //    return (valor.Ext_ObtenerSemanaInicio(), valor.Ext_ObtenerSemanaTermino());
        //}

        public static bool Ext_EsNumeroEnteroValido(this string valor)
        {
            Regex re = new Regex(@"^[0-9]+$");
            return re.IsMatch(valor);
        }

        public static bool Ext_EsPorcentajeValido(this string valor)
        {
            Regex re = new Regex(@"^[0-9]{1,2}([\,][0-9]{1,3})?$");
            return re.IsMatch(valor);
        }

        public static bool Ext_EsFechaValida(this string valor)
        {
            var esFechaValida = false;

            try
            {
                string[] formatos = { "dd-MM-yyyy", "yyyy-MM-dd" };
                esFechaValida = DateTime.TryParseExact(valor, formatos, new CultureInfo("es-cl"), DateTimeStyles.None, out var fecha);
            }
            catch (Exception) {
                esFechaValida = false;
            }
            return esFechaValida;
        }

        public static DateTime Ext_ToFecha(this string valor)
        {
            string[] formatos = { "dd-MM-yyyy", "yyyy-MM-dd" };
            DateTime.TryParseExact(valor, formatos, new CultureInfo("es-cl"), DateTimeStyles.None, out var fecha);
            return fecha;
        }
    }
}