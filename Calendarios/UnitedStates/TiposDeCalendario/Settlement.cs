using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedStates.TiposDeCalendario
{
    public static class Settlement
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var ListaDeFeriados = new List<Feriado>();

            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.NewYearsDay));

            if (ano >= 1983)
                ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 1, DayOfWeek.Monday, 3), Feriados.MartinLutherKingsBirthday.Mes, Feriados.MartinLutherKingsBirthday.Descricao));

            ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 5, DayOfWeek.Monday), Feriados.MemorialDay.Mes, Feriados.MemorialDay.Descricao));

            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.IndependenceDay));
            
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 9, DayOfWeek.Monday, 1), Feriados.LaborDay.Mes, Feriados.LaborDay.Descricao));

            if (ano>=1971)
                ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 10, DayOfWeek.Monday, 2), Feriados.ColumbusDay.Mes, Feriados.ColumbusDay.Descricao));

            if (ano <=1970 || ano >= 1978)
            {
                ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.VeteransDay));
            }
            else
            {
                ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 10, DayOfWeek.Monday, 4), Feriados.VeteransDay.Mes, Feriados.VeteransDay.Descricao));
            }

            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 11, DayOfWeek.Thursday, 4), Feriados.ThanksgivingDay.Mes, Feriados.ThanksgivingDay.Descricao));

            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.Christmas));

            return ListaDeFeriados;

        }
    }
}
