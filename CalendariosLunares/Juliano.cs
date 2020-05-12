using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.CalendariosLunares
{
    public static class Juliano
    {
        public static DateTime ObterDomingoDePascoa(int ano)
        {
            //Modelo de Meeus
            var a = ano % 4;
            var b = ano% 7;
            var c = ano % 19;
            var d = (19 * c + 15) % 30;
            var e = (2 * a + 4 * b - d + 34) % 7;
            
            var mes = (int)Math.Floor(((decimal)d + e + 114) / 31);
            var dia = (int)((d + e + 114) % 31) + 1;

            return new DateTime(ano, mes, dia);
        }
    }
}
