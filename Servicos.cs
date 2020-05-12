using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendario
{
    public static class Servicos
    {
        public static bool[] VerificarSeDiaUtilMultidimensional(DateTime data, int[,] paisCalendario)
        {
            bool[] resposta = new bool[paisCalendario.Length/2];

            for (int i = 0; i < paisCalendario.Length/2; i++)
            {
                var ListaDeFeriados = Calendarios.Calendario.ObterListaDeFeriados(data.Year, (Calendarios.PaisEnum)paisCalendario[i,0], paisCalendario[i, 1]);
                
                if (VerificarSeFinalDeSemana(data))
                {
                    resposta[i]=false;
                }
                else
                {
                    foreach (var feriado in ListaDeFeriados)
                    {
                        if (data.Day == feriado.Dia && data.Month == feriado.Mes) { resposta[i] = false; }
                    }
                    resposta[i]=true;
                }
            }
            return resposta;
        }

        public static bool VerificarSeDiaUtil(DateTime data, Calendarios.PaisEnum pais, int tipoCalendario)
        {
            var ListaDeFeriados = Calendarios.Calendario.ObterListaDeFeriados(data.Year, pais, tipoCalendario);

            if (VerificarSeFinalDeSemana(data))
                return false;
            else
            {
                foreach (var feriado in ListaDeFeriados)
                {
                    if (data.Day == feriado.Dia && data.Month == feriado.Mes)  
                        return false;
                }
                return true;
            }
        }

        public static bool VerificarSeFinalDeSemana(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }

        public static int CalcularDiasUteisEntreDatas(DateTime dataInicio, DateTime dataFim, Calendarios.PaisEnum pais, int calendario, bool incluirPrimeiroDia = true, bool incluirUltimoDia=false)
        {
            int numeroDeDiasUteis = 0;
            
            if (dataInicio!= dataFim)
            {
                //Determina a data inicial independentemente da ordem inserida pelo usuário
                DateTime dataInicioAnalise = (dataInicio < dataFim ? dataInicio : dataFim);
                
                //Determina a data final independentemente da ordem inserida pelo usuário
                DateTime dataFimAnalise = (dataInicio < dataFim ? dataFim : dataInicio);

                while (dataInicioAnalise.Date < dataFimAnalise.Date)
                {
                    if (VerificarSeDiaUtil(dataInicioAnalise, pais, calendario))
                        ++numeroDeDiasUteis;
                    
                    dataInicioAnalise = dataInicioAnalise.AddDays(1);
                }
                
                //Verifica se o último dia também é um dia útil
                if(VerificarSeDiaUtil(dataFimAnalise, pais, calendario))
                    ++numeroDeDiasUteis;
                
                //Verifica se o primeiro dia útil deve ser incluído na contagem
                if (VerificarSeDiaUtil(dataInicioAnalise, pais, calendario) && !incluirPrimeiroDia)
                    numeroDeDiasUteis--;
                
                //Verifica se o último dia útil deve ser incluído na contagem
                if (VerificarSeDiaUtil(dataFimAnalise, pais, calendario) && !incluirUltimoDia)
                    numeroDeDiasUteis--;
            }
            else if(incluirPrimeiroDia && incluirUltimoDia && VerificarSeDiaUtil(dataInicio, pais, calendario))
                numeroDeDiasUteis = 1;
            
            return (dataInicio > dataFim ? -numeroDeDiasUteis : numeroDeDiasUteis);
        }

        public static int CalcularDiasUteisEntreDatasNovaProposta(DateTime dataInicio, DateTime dataFim, Calendarios.PaisEnum pais, int tipoCalendario, bool incluirPrimeiroDia = true, bool incluirUltimoDia = false)
        {
            int numeroDeDiasUteis = 0;

            if (dataInicio != dataFim)
            {
                DateTime dataInicioAnalise = (dataInicio < dataFim ? dataInicio : dataFim);
                DateTime dataFimAnalise = (dataInicio < dataFim ? dataFim : dataInicio);

                int diferencaEmAnos = dataFimAnalise.Year - dataInicioAnalise.Year;
                int quantidadeDeFeriadosEmDiasUteis = 0;

                for (int i = 0; i <= diferencaEmAnos; i++)
                {
                    var ListaDeFeriados = Calendarios.Calendario.ObterListaDeFeriados(dataInicioAnalise.Year + i, pais, tipoCalendario);
                    foreach (var feriado in ListaDeFeriados)
                    {
                        var diaDeFeriado = new DateTime(dataInicioAnalise.Year + i, feriado.Mes, feriado.Dia);
                        if(diaDeFeriado.ToOADate()>=dataInicioAnalise.ToOADate() && diaDeFeriado.ToOADate() <= dataFimAnalise.ToOADate())
                        {
                            if (VerificarSeFinalDeSemana(diaDeFeriado) == false)
                            {
                                quantidadeDeFeriadosEmDiasUteis++;
                            }
                        }
                    }
                }
                
                numeroDeDiasUteis = dataFimAnalise.Subtract(dataInicioAnalise).Days - quantidadeDeFeriadosEmDiasUteis - CalcularQuantidadeDeSabadosEDomingosEntreDatas(dataInicioAnalise, dataFimAnalise) + 1;

                //Verifica se o primeiro dia útil deve ser incluído na contagem
                if (VerificarSeDiaUtil(dataInicioAnalise, pais, tipoCalendario) && !incluirPrimeiroDia)
                    numeroDeDiasUteis--;

                //Verifica se o último dia útil deve ser incluído na contagem
                if (VerificarSeDiaUtil(dataFimAnalise, pais, tipoCalendario) && !incluirUltimoDia)
                    numeroDeDiasUteis--;
            }
            else if (incluirPrimeiroDia && incluirUltimoDia && VerificarSeDiaUtil(dataInicio, pais, tipoCalendario))
                numeroDeDiasUteis = 1;

            return (dataInicio > dataFim ? -numeroDeDiasUteis : numeroDeDiasUteis);
        }

        public static int CalcularQuantidadeDeSabadosEDomingosEntreDatas(DateTime dataInicio, DateTime dataFim)
        {
            int quantidadeDeSabados = 0;
            int quantidadeDeDomingos = 0;
            var proximoSabado = dataInicio.AddDays(6 - (int)dataInicio.DayOfWeek);

            if (dataInicio.DayOfWeek == DayOfWeek.Sunday)
                quantidadeDeDomingos++;

            while (proximoSabado.ToOADate()<=dataFim.ToOADate())
            {
                quantidadeDeSabados++;
                proximoSabado = proximoSabado.AddDays(7);
            }

            proximoSabado = proximoSabado.AddDays(-7);

            if (quantidadeDeSabados>=1)
               quantidadeDeDomingos = (dataFim.Subtract(proximoSabado).Days >= 1 ? quantidadeDeDomingos + quantidadeDeSabados : quantidadeDeDomingos + quantidadeDeSabados-1);

            return quantidadeDeSabados + quantidadeDeDomingos;
        }

        public static DateTime CalcularDataComIntervaloFixoDeDiasUteis(DateTime data, int numeroDiasUteis, Calendarios.PaisEnum pais, int tipoCalendario)
        {
            for (int i = 0; i < numeroDiasUteis; i++)
            {
                while(VerificarSeDiaUtil(data, pais, tipoCalendario)!=true)
                    data = data.AddDays(1);
                data = data.AddDays(1);
            }
            return data;
        }
    }
}
