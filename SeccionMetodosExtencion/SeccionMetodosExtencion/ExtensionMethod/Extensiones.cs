using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionMetodosExtencion.ExtensionMethod
{
    public static class Extensiones
    {
        public static int Ext_CalcularEdad(this DateTime valor)
        {
            return DateTime.Now.AddTicks(-valor.Ticks).Year - 1;
        }

        public static string Ext_MesNombre(this DateTime valor)
        {
            DateTimeFormatInfo info = new CultureInfo("en-us", false).DateTimeFormat;
            return info.GetMonthName(valor.Month);
        }

        public static DateTime Ext_ObtenerMesInicio(this DateTime valor)
        {
            return new DateTime(valor.Year, valor.Month, 1);
        }
        public static DateTime Ext_ObtenerMesTermino(this DateTime valor)
        {
            return new DateTime(valor.Year, valor.Month, DateTime.DaysInMonth(valor.Year, valor.Month));
        }

        public static DateTime Ext_ObtenerSemanaInicio(this DateTime valor)
        {
            var fecha = valor;
            var dias = 1 - (fecha.DayOfWeek != DayOfWeek.Sunday ? (double)fecha.DayOfWeek : 7d);
            return fecha.AddDays(dias);
            
        }
        public static DateTime Ext_ObtenerSemanaTermino(this DateTime valor)
        {
            var fecha = valor;
            var dias = 7 - (fecha.DayOfWeek != DayOfWeek.Sunday ? (double)fecha.DayOfWeek : 7d);
            return fecha.AddDays(dias);
        }
    }
}
