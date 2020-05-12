using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Italy.TiposDeCalendario
{
    public static class Settlement
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var domingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>
            {
                Feriados.NewYearsDay,
                Feriados.Epiphany,
                Feriados.EasterMonday(domingoDePascoa),
                Feriados.LiberationDay,
                Feriados.LaborDay,
                Feriados.Assumption,
                Feriados.AllSaintsDay,
                Feriados.ImmaculateConception,
                Feriados.Christmas,
                Feriados.StStephenDay
            };

            if (ano >= 2000) 
                ListaDeFeriados.Add(Feriados.RepublicDay);
            if (ano == 1999)
                ListaDeFeriados.Add(Feriados.NewYearsEve);

            return ListaDeFeriados;
        }
    }
}
