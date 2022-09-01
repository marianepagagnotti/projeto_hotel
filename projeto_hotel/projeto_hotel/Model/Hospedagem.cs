using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_hotel.Model
{
    public class Hospedagem
    {
        int qnt_adultos;
        Suite quarto_escolhido;

        public Suite QuartoEscolhido
        {
            get => quarto_escolhido;
            set
            {
                if (value == null)
                    throw new Exception("Selecione a acomodação de sua preferência");

                quarto_escolhido = value;
            }
        }
        public int QntAdultos
        {
            get => qnt_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Selecione a quantidade de adultos");

                qnt_adultos = value;
            }
        }



        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        
        public double ValorTotal
        {
            get => ((QntAdultos * QuartoEscolhido.DiariaDoAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaDaCrianca)) * Estadia;
        }

    }
}

