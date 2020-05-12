using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.Italy
{
    public static class Feriados
    {
        #region Feriados com data fixa
        public static Feriado NewYearsDay { get; set; } = new Feriado(1, 1, "New Year's Day");
        public static Feriado Epiphany { get; set; } = new Feriado(6, 1, "Epiphany");
        public static Feriado LiberationDay { get; set; } = new Feriado(25, 4, "Liberation Day");
        public static Feriado LaborDay { get; set; } = new Feriado(1, 5, "Labor Day");
        public static Feriado RepublicDay { get; set; } = new Feriado(2, 6, "Republic Day");
        public static Feriado Assumption { get; set; } = new Feriado(15, 8, "Assumption");
        public static Feriado AllSaintsDay { get; set; } = new Feriado(1, 11, "All Saints' Day");
        public static Feriado ImmaculateConception { get; set; } = new Feriado(8, 12, "Immaculate Conception");
        public static Feriado ChristmasEve { get; set; } = new Feriado(24, 12, "Christmas Eve");
        public static Feriado Christmas { get; set; } = new Feriado(25, 12, "Christmas");
        public static Feriado StStephenDay { get; set; } = new Feriado(26, 12, "Saint Stephen's Day");
        public static Feriado NewYearsEve { get; set; } = new Feriado(31, 12, "New Year's Eve");
        #endregion

        #region Feriados baseados no calendario Lunar
        public static Feriado GoodFriday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -2, "Good Friday"); }
        public static Feriado EasterMonday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, 1, "Easter Monday"); }
        #endregion
    }
}
