using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedKingdom.TiposDeCalendario
{
    public static class LondonStockExchange
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var domingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>();

            ListaDeFeriados.Add(Feriados.NewYearsDay);
            if (Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.NewYearsDay) != null)
                ListaDeFeriados.Add(Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.NewYearsDay));

            ListaDeFeriados.Add(Feriados.GoodFriday(domingoDePascoa));
            ListaDeFeriados.Add(Feriados.EasterMonday(domingoDePascoa));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterDia(ano, 5, DayOfWeek.Monday, 1), Feriados.EarlyMayBankHoliday.Mes, Feriados.EarlyMayBankHoliday.Descricao));
            if (ano != 2002) ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 5, DayOfWeek.Monday), Feriados.SpringBankHoliday.Mes, Feriados.SpringBankHoliday.Descricao));
            ListaDeFeriados.Add(new Feriado(Calendario.ObterUltimoDia(ano, 8, DayOfWeek.Monday), Feriados.SummerBankHoliday.Mes, Feriados.SummerBankHoliday.Descricao));

            ListaDeFeriados.Add(Feriados.Christmas);
            if (Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.Christmas) != null)
                ListaDeFeriados.Add(Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.Christmas));
            if (Calendario.AjustarFeriadoParaProximaTerca(ano, Feriados.Christmas) != null)
                ListaDeFeriados.Add(Calendario.AjustarFeriadoParaProximaTerca(ano, Feriados.Christmas));

            ListaDeFeriados.Add(Feriados.BoxingDay);
            if (Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.BoxingDay) != null)
                ListaDeFeriados.Add(Calendario.AjustarFeriadoParaProximaSegunda(ano, Feriados.BoxingDay));
            if (Calendario.AjustarFeriadoParaProximaTerca(ano, Feriados.BoxingDay) != null)
                ListaDeFeriados.Add(Calendario.AjustarFeriadoParaProximaTerca(ano, Feriados.BoxingDay));

            #region Feriados Especiais
            if (ano == 2002) ListaDeFeriados.Add(Feriados.GoldenJubilee);
            if (ano == 2002) ListaDeFeriados.Add(Feriados.SpecialSpringBankHoliday);
            if (ano == 1999) ListaDeFeriados.Add(Feriados.LastDayOfTheYear);
            #endregion

            return ListaDeFeriados;
        }
    }
}
