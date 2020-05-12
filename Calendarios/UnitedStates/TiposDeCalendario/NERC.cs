using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedStates.TiposDeCalendario
{
    public static class NERC
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var ListaDeFeriados = new List<Feriado>();

            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.NewYearsDay));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 5, DayOfWeek.Monday), Feriados.MemorialDay.Mes, Feriados.MemorialDay.Descricao));
            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.IndependenceDay));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 9, DayOfWeek.Monday, 1), Feriados.LaborDay.Mes, Feriados.LaborDay.Descricao));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 11, DayOfWeek.Thursday, 4), Feriados.ThanksgivingDay.Dia, Feriados.ThanksgivingDay.Descricao));
            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.Christmas));

            return ListaDeFeriados;
        }
    }
}
