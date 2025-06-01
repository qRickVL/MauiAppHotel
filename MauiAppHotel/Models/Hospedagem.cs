using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {

        public Suite SuiteSelecionada {  get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn {  get; set; }
        public DateTime DataCheckOut { get; set; }


        public int Estadia
        {

            get => DataCheckOut.Subtract(DataCheckIn).Days;

        }

        public double ValorTotal
        {

            get
            {

                double ValorAdultos = QntAdultos * SuiteSelecionada.ValorAdulto;

                double ValorCriancas = QntCriancas * SuiteSelecionada.ValorCrianca;

                double Total = (ValorAdultos + ValorCriancas) * Estadia;

                return Total;

            }

        }

    }
}
