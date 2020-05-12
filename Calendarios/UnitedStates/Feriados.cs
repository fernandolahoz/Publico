using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios.UnitedStates
{
    public static class Feriados
    {
        #region Feriados com data fixa
        public static Feriado NewYearsDay { get; set; } = new Feriado(1, 1, "New Year's Day");
        public static Feriado MartinLutherKingsBirthday { get; set; } = new Feriado(0, 1, "Martin Luther King's Birthday");
        public static Feriado WashingtonsBirthday { get; set; } = new Feriado(0, 2, "Washington's Birthday");
        public static Feriado MemorialDay { get; set; } = new Feriado(0, 5, "Memorial Day");
        public static Feriado IndependenceDay { get; set; } = new Feriado(4, 7, "Independence Day");
        public static Feriado LaborDay { get; set; } = new Feriado(0, 9, "Labor Day");
        public static Feriado ColumbusDay { get; set; } = new Feriado(0, 10, "Columbus Day");
        public static Feriado VeteransDay { get; set; } = new Feriado(0, 11, "Veteran's Day");
        public static Feriado PresidentialElectionDay { get; set; } = new Feriado(0, 11, "Presidential Election Day");
        public static Feriado ThanksgivingDay { get; set; } = new Feriado(0, 11, "Thanksgiving Day");
        public static Feriado ChristmasEve { get; set; } = new Feriado(24, 12, "Christmas Eve");
        public static Feriado Christmas { get; set; } = new Feriado(25, 12, "Christmas");
        #endregion

        #region Feriados baseados no calendario Lunar
        public static Feriado GoodFriday(DateTime domingoDePascoa) { return Feriado.ObterFeriadoComIntervaloFixo(domingoDePascoa, -2, "Good Friday"); }
        #endregion

        #region Feriados Especiais
        public static Feriado HurricaneSandy { get; set; } = new Feriado(0, 10, "Hurricane Sandy");
        public static Feriado PresidentFordsFuneral { get; set; } = new Feriado(2, 1, "President Ford's Funeral");
        public static Feriado PresidentRaegansFuneral { get; set; } = new Feriado(11, 6, "President Raegan's Funeral");
        public static Feriado PresidentBushFuneral { get; set; } = new Feriado(5, 12, "President Bush's Funeral");
        public static Feriado PresidentNixonsFuneral { get; set; } = new Feriado(27, 4, "President Nixon's Funeral");
        public static Feriado HurricaneGloria { get; set; } = new Feriado(27, 9, "Hurricane Gloria");
        public static Feriado Blackout { get; set; } = new Feriado(14, 7, "1977 Blackout");
        public static Feriado PresidentJohnsonsFuneral { get; set; } = new Feriado(25, 1, "President Johnson's Funeral");
        public static Feriado PresidentTrumansFuneral { get; set; } = new Feriado(28, 12, "President Truman's Funeral");
        public static Feriado PresidentEisenhowersFuneral { get; set; } = new Feriado(31, 3, "President Eisenhower's Funeral");
        public static Feriado HeavySnow { get; set; } = new Feriado(10, 2, "HEavy Snow in 1969");
        public static Feriado PresidentKennedysFuneral { get; set; } = new Feriado(25, 11, "President Kennedy's Funeral");
        public static Feriado NationalDayLunarExploration { get; set; } = new Feriado(21, 7, "National Day for the Lunar exploration");
        public static Feriado DayAfterIndependenceDay { get; set; } = new Feriado(5, 7, "Day after independence day");
        public static Feriado MartingLutherKingMourning { get; set; } = new Feriado(9, 4, "Day of mourning for Martin Luther King Jr.");
        public static Feriado DayBeforeDecorationDay { get; set; } = new Feriado(29, 5, "Day before Decoration Day");
        public static Feriado DayAfterChristmas { get; set; } = new Feriado(26, 12, "Day after Christmas");
        public static Feriado SeptemberEleven { get; set; } = new Feriado(11, 9, "September 11th");
        public static Feriado SeptemberTwelve { get; set; } = new Feriado(12, 9, "September 12th");
        public static Feriado SeptemberThirteenth { get; set; } = new Feriado(13, 9, "September 13th");
        public static Feriado SeptemberFourteenth { get; set; } = new Feriado(14, 9, "September 14th");
        public static Feriado PaperWorkCrisis { get; set; } = new Feriado(0, 0, "1968's Paperwork Crisis");
        #endregion
    }
}
