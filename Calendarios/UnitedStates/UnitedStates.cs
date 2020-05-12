using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedStates
{
    public static class UnitedStates
    {
        public static List<Feriado> ObterListaDeFeriados(int ano, TiposDeCalendario.TiposEnum tipoDeCalendario)
        {
            switch (tipoDeCalendario)
            {
                case TiposDeCalendario.TiposEnum.Settlement:
                    return TiposDeCalendario.Settlement.ObterListaDeFeriados(ano);
                case TiposDeCalendario.TiposEnum.NYSE:
                    return TiposDeCalendario.NYSE.ObterListaDeFeriados(ano);
                case TiposDeCalendario.TiposEnum.NERC:
                    return TiposDeCalendario.NERC.ObterListaDeFeriados(ano);
                case TiposDeCalendario.TiposEnum.GovernmentBond:
                    return TiposDeCalendario.GovernmentBond.ObterListaDeFeriados(ano);
                default:
                    return TiposDeCalendario.Settlement.ObterListaDeFeriados(ano);
            }
        }
    }
}
