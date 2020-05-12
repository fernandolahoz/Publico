using System.Collections.Generic;

namespace Calendario.Calendarios.Brazil
{
    public static class Brazil  
    {
        public static List<Feriado> ObterListaDeFeriados(int ano, TiposDeCalendario.TiposEnum tipoDeCalendario)
        {
            if (tipoDeCalendario == TiposDeCalendario.TiposEnum.B3)
            {
                return TiposDeCalendario.B3.ObterListaDeFeriados(ano);
            }
            else
            {
                return TiposDeCalendario.ANBIMA.ObterListaDeFeriados(ano);
            }
        }
    }
}
