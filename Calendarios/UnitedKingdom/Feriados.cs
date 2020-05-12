using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedKingdom
{
    public static class Feriados
    {
        #region Feriados com data fixa
        public static Feriado NewYearsDay { get; set; } = new Feriado(1, 1, "New Year's Day");
        public static Feriado EarlyMayBankHoliday { get; set; } = new Feriado(0, 5, "Early May Bank Holiday - First Monday of May");
        public static Feriado SpringBankHoliday { get; set; } = new Feriado(0, 5, "Spring Bank Holiday - Last Monday of May");
        public static Feriado SummerBankHoliday { get; set; } = new Feriado(0, 8, "Summer Bank Holiday - Last Monday of August");
        public static Feriado Christmas { get; set; } = new Feriado(25, 12, "Christmas");
        public static Feriado BoxingDay { get; set; } = new Feriado(26, 12, "Boxing Day");
        #endregion

        #region Feriados baseados no calendario Lunar
        public static Feriado GoodFriday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -2, "Good Friday"); }
        public static Feriado EasterMonday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, 1, "Easter Monday"); }
        #endregion

        #region Feriados Especiais
        public static Feriado LastDayOfTheYear { get; set; } = new Feriado(31, 12, "December 31st - 1999 only");
        public static Feriado GoldenJubilee { get; set; } = new Feriado(3, 6, "Golden Jubilee Bank Holiday - 2002 only");
        public static Feriado SpecialSpringBankHoliday { get; set; } = new Feriado(4, 6, "Special Spring Bank Holiday - 2002 only");
        #endregion
    }
}
