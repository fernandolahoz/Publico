using System;
using System.Collections.Generic;
using System.Text;

namespace Calendario.Calendarios
{
    public static class Calendario
    {
        public static List<Feriado> ObterListaDeFeriados(int ano, PaisEnum pais, int tipoCalendario)
        {
            switch (pais)
            {
                case PaisEnum.Brazil:
                    return Brazil.Brazil.ObterListaDeFeriados(ano, (Brazil.TiposDeCalendario.TiposEnum)tipoCalendario);
                case PaisEnum.Italy:
                    return Italy.Italy.ObterListaDeFeriados(ano, (Italy.TiposDeCalendario.TiposEnum)tipoCalendario);
                case PaisEnum.UnitedKingdom:
                    return UnitedKingdom.UnitedKingdom.ObterListaDeFeriados(ano, (UnitedKingdom.TiposDeCalendario.TiposEnum)tipoCalendario);
                case PaisEnum.UnitedStates:
                    return UnitedStates.UnitedStates.ObterListaDeFeriados(ano, (UnitedStates.TiposDeCalendario.TiposEnum)tipoCalendario);
                default:
                    return Brazil.Brazil.ObterListaDeFeriados(ano, Brazil.TiposDeCalendario.TiposEnum.ANBIMA);
            }
        }
        
        public static int ObterDia(int ano, int mes, DayOfWeek diaDaSemana, int ocorrencia)
        {
            if (ocorrencia > 0 || ocorrencia <= 5)
            {
                DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);
                var diasNecessarios = (int)diaDaSemana - (int)primeiroDiaDoMes.DayOfWeek;
                if (diasNecessarios < 0) diasNecessarios = diasNecessarios + 7;
                var diaResultante = (diasNecessarios + 1) + (7 * (ocorrencia - 1));
                return diaResultante;
            }
            return 0;
        }

        public static int ObterUltimoDia(int ano, int mes, DayOfWeek diaDaSemana)
        {
            var data = new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes), System.Globalization.CultureInfo.CurrentCulture.Calendar);
            while (data.DayOfWeek != diaDaSemana)
            {
                data = data.AddDays(-1);
            }
            return data.Day;
        }

        public static Feriado ObterFeriadoAjustadoParaFinalDeSemana(int ano, Feriado feriado)
        {
            var diaAnteriorAoFeriado = new DateTime(ano, feriado.Mes, feriado.Dia).AddDays(-1);
            var diaPosteriorAoFeriado = new DateTime(ano, feriado.Mes, feriado.Dia).AddDays(1);

            if (diaAnteriorAoFeriado.DayOfWeek == DayOfWeek.Friday)
                return new Feriado(diaAnteriorAoFeriado.Day, diaAnteriorAoFeriado.Month, feriado.Descricao);
            else if (diaPosteriorAoFeriado.DayOfWeek == DayOfWeek.Friday)
                return new Feriado(diaPosteriorAoFeriado.Day, diaPosteriorAoFeriado.Month, feriado.Descricao);
            else
               return feriado;
        }

        public static Feriado AjustarFeriadoParaProximaSegunda(int ano, Feriado feriado)
        {
            var diaDoFeriado = new DateTime(ano, feriado.Mes, feriado.Dia);
            if (diaDoFeriado.DayOfWeek == DayOfWeek.Saturday)
            {
                DateTime novoFeriado = new DateTime(ano, diaDoFeriado.AddDays(2).Month, diaDoFeriado.AddDays(2).Day);
                return new Feriado(novoFeriado.Day, novoFeriado.Month, feriado.Descricao);
            }
            else if (diaDoFeriado.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime novoFeriado = new DateTime(ano, diaDoFeriado.AddDays(1).Month, diaDoFeriado.AddDays(1).Day);
                return new Feriado(novoFeriado.Day, novoFeriado.Month, feriado.Descricao);
            }
            else
                return null;
        }

        public static Feriado AjustarFeriadoParaProximaTerca(int ano, Feriado feriado)
        {
            var diaDoFeriado = new DateTime(ano, feriado.Mes, feriado.Dia);

            if (diaDoFeriado.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime novoFeriado = new DateTime(ano, diaDoFeriado.AddDays(2).Month, diaDoFeriado.AddDays(2).Day);
                return new Feriado(novoFeriado.Day, novoFeriado.Month, feriado.Descricao);
            }
            return null;
        }
    }
}
