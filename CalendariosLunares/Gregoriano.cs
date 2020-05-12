using System;
using System.Collections.Generic;
using System.Text;


namespace Calendario.CalendariosLunares
{
    public static class Gregoriano
    {
        public static DateTime ObterDomingoDePascoa(int ano)
        {
            //Adaptação do modelo de Gauss
            var a = ano % 19;
            var b = Math.Floor((decimal)ano / 100);
            var c = ano % 100;
            var d = Math.Floor(b / 4);
            var e = b % 4;
            var f = Math.Floor((b + 8) / 25);
            var g = Math.Floor((b - f + 1) / 3);
            var h = (19 * a + b - d - g + 15) % 30;
            var i = Math.Floor((decimal)c / 4);
            var k = c % 4;
            var l = (32 + 2 * e + 2 * i - h - k) % 7;
            var m = Math.Floor((a + 11 * h + 22 * l) / 451);

            var mes = (int)Math.Floor((h + l - 7 * m + 114) / 31);
            var dia = (int)((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(ano, mes, dia);
        }
    }
}