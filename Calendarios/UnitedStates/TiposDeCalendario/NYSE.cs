using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedStates.TiposDeCalendario
{
    public static class NYSE
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var domingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>();

            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.NewYearsDay));
            if (ano >= 1998)
                ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 1, DayOfWeek.Monday, 3), Feriados.MartinLutherKingsBirthday.Mes, Feriados.MartinLutherKingsBirthday.Descricao));
            
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 2, DayOfWeek.Monday, 3), Feriados.WashingtonsBirthday.Mes, Feriados.WashingtonsBirthday.Descricao));
            ListaDeFeriados.Add(Feriados.GoodFriday(domingoDePascoa));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 5, DayOfWeek.Monday), Feriados.MemorialDay.Mes, Feriados.MemorialDay.Descricao));
            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.IndependenceDay));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 9, DayOfWeek.Monday, 1), Feriados.LaborDay.Mes, Feriados.LaborDay.Descricao));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 11, DayOfWeek.Thursday, 4), Feriados.ThanksgivingDay.Dia, Feriados.ThanksgivingDay.Descricao));
            ListaDeFeriados.Add(Calendario.ObterFeriadoAjustadoParaFinalDeSemana(ano, Feriados.Christmas));

            #region Feriados Especiais
            if (ano == 2018) ListaDeFeriados.Add(Feriados.PresidentBushFuneral);
            if (ano == 2012) ListaDeFeriados.Add(Feriados.HurricaneSandy);
            if (ano == 2007) ListaDeFeriados.Add(Feriados.PresidentFordsFuneral);
            if (ano == 2004) ListaDeFeriados.Add(Feriados.PresidentRaegansFuneral);
            if (ano == 2001) ListaDeFeriados.Add(Feriados.SeptemberEleven);
            if (ano == 2001) ListaDeFeriados.Add(Feriados.SeptemberTwelve);
            if (ano == 2001) ListaDeFeriados.Add(Feriados.SeptemberThirteenth);
            if (ano == 2001) ListaDeFeriados.Add(Feriados.SeptemberFourteenth);
            if (ano == 1994) ListaDeFeriados.Add(Feriados.PresidentNixonsFuneral);
            if (ano == 1985) ListaDeFeriados.Add(Feriados.HurricaneGloria);
            if (ano == 1977) ListaDeFeriados.Add(Feriados.Blackout);
            if (ano == 1973) ListaDeFeriados.Add(Feriados.PresidentJohnsonsFuneral);
            if (ano == 1972) ListaDeFeriados.Add(Feriados.PresidentTrumansFuneral);
            if (ano == 1969) ListaDeFeriados.Add(Feriados.NationalDayLunarExploration);
            if (ano == 1969) ListaDeFeriados.Add(Feriados.PresidentEisenhowersFuneral);
            if (ano == 1969) ListaDeFeriados.Add(Feriados.HeavySnow);
            if (ano == 1968) ListaDeFeriados.Add(Feriados.DayAfterIndependenceDay);
            if (ano == 1968) ListaDeFeriados.Add(Feriados.MartingLutherKingMourning);
            if (ano == 1963) ListaDeFeriados.Add(Feriados.PresidentKennedysFuneral);
            if (ano == 1961) ListaDeFeriados.Add(Feriados.DayBeforeDecorationDay);
            if (ano == 1958) ListaDeFeriados.Add(Feriados.DayAfterChristmas);
            if (ano == 1954 || ano == 1956 || ano == 1965)
                ListaDeFeriados.Add(Feriados.ChristmasEve);
            
            if (ano <= 1968 || ano <= 1980 && ano % 4 == 0)
                ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 11, DayOfWeek.Tuesday), Feriados.PresidentialElectionDay.Mes, Feriados.PresidentialElectionDay.Descricao));
            
            if (ano == 1968)
            {
                var feriadoCriseDoPapel = new DateTime(ano, 6, 12);
                for (int i = 0; i <= 28; i++)
                {
                    ListaDeFeriados.Add(new Feriado(feriadoCriseDoPapel.AddDays(7*i).Day,
                                                    feriadoCriseDoPapel.AddDays(7*i).Month,
                                                    Feriados.PaperWorkCrisis.Descricao));
                }
            }
            #endregion

            return ListaDeFeriados;

        }
    }
}
