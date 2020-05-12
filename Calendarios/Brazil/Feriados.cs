using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Brazil
{
    public static class Feriados
    {
        #region Feriados com data fixa
        public static Feriado NewYearsDay { get; set; } = new Feriado(1, 1, "New Year's Day");
        public static Feriado SaoPauloAnniversary { get; set; } = new Feriado(25, 1, "Sao Paulo's Anniversary");
        public static Feriado TiradentesDay { get; set; } = new Feriado(21, 4, "Tiradentes Day");
        public static Feriado LaborDay { get; set; } = new Feriado(1, 5, "Labor Day");
        public static Feriado RevolutionDay { get; set; } = new Feriado(9, 7, "Revolution Day");
        public static Feriado IndependenceDay { get; set; } = new Feriado(7, 9, "Independence Day");
        public static Feriado NossaSraAparecidaDay { get; set; } = new Feriado(12, 10, "Nossa Senhora Aparecida's Day");
        public static Feriado AllSoulsDay { get; set; } = new Feriado(2, 11, "All Souls Day");
        public static Feriado RepublicDay { get; set; } = new Feriado(15, 11, "Republic Day");
        public static Feriado BlackConciousnessDay { get; set; } = new Feriado(20, 11, "Black Conciousness' Day");
        public static Feriado ChristmasEve { get; set; } = new Feriado(24, 12, "Christmas Eve");
        public static Feriado Christmas { get; set; } = new Feriado(25, 12, "Christmas");
        #endregion

        #region Feriados baseados no calendario Lunar
        public static Feriado CarnivalMonday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -48, "Carnival Monday"); }
        public static Feriado CarnivalTuesday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -47, "Carnival Tuesday"); }
        public static Feriado PassionOfChrist(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -2, "Passion of Christ"); }
        public static Feriado CorpusChristi(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, 60, "Corpus Christi"); }
        #endregion
    }
}
