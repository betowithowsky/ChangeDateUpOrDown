using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteVagaFrontEnd.Models
{
    public class DateExtensions
    {
        private Dictionary<int, int> months = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
        };

        public string ChangeDate(string date, char op, long value)
        {
            string[] piecesTextDate = date.Split('/', ' ', ':');

            int minutos = Convert.ToInt32(piecesTextDate[4]);
            int horas = Convert.ToInt32(piecesTextDate[3]);
            int ano = Convert.ToInt32(piecesTextDate[2]);
            int mes = Convert.ToInt32(piecesTextDate[1]);
            int dias = Convert.ToInt32(piecesTextDate[0]);

            long convertValue = Math.Abs(value);

            if(op != '+' || op != '-')
            {
                Console.WriteLine("Erro! insira um operador valido. + ou - ");
            }

            

            if(op == '+')
            {
                while (convertValue > 0)
                {
                    convertValue--;
                    minutos++;

                    if (minutos >= 60)
                    {
                        minutos = 00;
                        horas++;
                    }
                    if (horas > 23)
                    {
                        horas = 00;
                        dias++;
                    }
                    if (dias > months[mes])
                    {
                        dias = 01;
                        mes++;
                    }
                    if (mes > 12)
                    {
                        mes = 01;
                        ano++;
                    }
                }
            }

            if (op == '-')
            {
                while (convertValue > 0)
                {
                    convertValue--;
                    minutos--;

                    if (minutos < 00)
                    {
                        minutos = 59;
                        horas--;
                    }
                    if (horas < 00)
                    {
                        horas = 23;
                        dias--;
                    }
                    if (dias < 01)
                    {
                        if (mes == 1)
                        {
                            dias = months[12];
                            mes--;
                        }
                        else {
                            dias = months[mes - 1];
                            mes--;
                        }
                    }
                    if (mes < 01)
                    {
                        mes = 12;
                        ano--;
                    }
                }
            }
            
            return dias.ToString("D2") + "/" + mes.ToString("D2") + "/" + ano.ToString("D2") + " " + horas.ToString("D2") + ":" + minutos.ToString("D2");
        }
    }
}