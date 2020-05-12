using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedKingdom
{
    public static class UnitedKingdom
    {
        public static List<Feriado> ObterListaDeFeriados(int ano, TiposDeCalendario.TiposEnum tipoDeCalendario)
        {
            if (tipoDeCalendario == TiposDeCalendario.TiposEnum.LondonMetalsExchange)
                return TiposDeCalendario.LondonMetalsExchange.ObterListaDeFeriados(ano);
            
            else if (tipoDeCalendario == TiposDeCalendario.TiposEnum.LondonStockExchange)
                return TiposDeCalendario.LondonStockExchange.ObterListaDeFeriados(ano);
            
            else
                return TiposDeCalendario.Settlement.ObterListaDeFeriados(ano);
        }
    }
}
