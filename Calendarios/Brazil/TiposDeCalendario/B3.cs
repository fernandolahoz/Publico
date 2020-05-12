using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Brazil.TiposDeCalendario
{
    public static class B3 
    {
        public static List<Feriado> ObterListaDeFeriados(int ano)
        {
            var DomingoDePascoa = CalendariosLunares.Gregoriano.ObterDomingoDePascoa(ano);
            var ListaDeFeriados = new List<Feriado>
            {
                Feriados.NewYearsDay,
                Feriados.SaoPauloAnniversary,
                Feriados.CarnivalMonday(DomingoDePascoa),
                Feriados.CarnivalTuesday(DomingoDePascoa),
                Feriados.PassionOfChrist(DomingoDePascoa),
                Feriados.TiradentesDay,
                Feriados.LaborDay,
                Feriados.RevolutionDay,
                Feriados.CorpusChristi(DomingoDePascoa),
                Feriados.IndependenceDay,
                Feriados.NossaSraAparecidaDay,
                Feriados.AllSoulsDay,
                Feriados.RepublicDay,
                Feriados.BlackConciousnessDay,
                Feriados.ChristmasEve,
                Feriados.Christmas
            };

            //Regra de Expediente da B3
            if (new DateTime(ano, 12, 31).DayOfWeek != DayOfWeek.Saturday || new DateTime(ano, 12, 31).DayOfWeek != DayOfWeek.Sunday)
            {
                ListaDeFeriados.Add(new Feriado(31, 12, "Expediente interno B3"));
            }

            return ListaDeFeriados;
        }
    }
}
