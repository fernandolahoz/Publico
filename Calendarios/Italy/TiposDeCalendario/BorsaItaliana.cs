using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Italy.TiposDeCalendario
{
    public static class BorsaItaliana
    {
        //Fonte: http://www.borsaitaliana.it
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var domingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>
            {
                Feriados.NewYearsDay,
                Feriados.GoodFriday(domingoDePascoa),
                Feriados.EasterMonday(domingoDePascoa),
                Feriados.LaborDay,
                Feriados.Assumption,
                Feriados.ChristmasEve,
                Feriados.Christmas,
                Feriados.StStephenDay,
                Feriados.NewYearsEve,
            };
            return ListaDeFeriados;
        }
    }
}
