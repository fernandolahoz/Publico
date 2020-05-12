using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Italy
{
    public static class Italy
    {
        public static List<Feriado> ObterListaDeFeriados(int ano, TiposDeCalendario.TiposEnum tipoDeCalendario)
        {
            if (tipoDeCalendario == TiposDeCalendario.TiposEnum.BorsaItaliana)
            {
                return TiposDeCalendario.BorsaItaliana.ObterListaDeFeriados(ano);
            }
            else
            {
                return TiposDeCalendario.Settlement.ObterListaDeFeriados(ano);
            }
        }
    }
}
