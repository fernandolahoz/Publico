using System;

namespace Calendario
{
    public class Feriado
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public string Descricao { get; set; }

        public Feriado(int dia, int mes, string descricao)
        {
            Dia = dia;
            Mes = mes;
            Descricao = descricao;
        }
        public static Feriado ObterFeriadoComIntervaloFixo(DateTime segundaDePascoa, int intervalo, string descricao)
        {
            return new Feriado(segundaDePascoa.AddDays(intervalo).Day, segundaDePascoa.AddDays(intervalo).Month, descricao);
        }
    }
}
