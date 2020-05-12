using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Brazil.TiposDeCalendario
{
    public static class ANBIMA
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var DomingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>
            {
                Feriados.NewYearsDay,
                Feriados.CarnivalMonday(DomingoDePascoa),
                Feriados.CarnivalTuesday(DomingoDePascoa),
                Feriados.PassionOfChrist(DomingoDePascoa),
                Feriados.TiradentesDay,
                Feriados.LaborDay,
                Feriados.CorpusChristi(DomingoDePascoa),
                Feriados.IndependenceDay,
                Feriados.NossaSraAparecidaDay,
                Feriados.AllSoulsDay,
                Feriados.RepublicDay,
                Feriados.Christmas
            };

            return ListaDeFeriados;
        }
    }
}
