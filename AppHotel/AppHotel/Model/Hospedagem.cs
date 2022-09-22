using System;
using System.Collections.Generic;
using System.Text;
//ok
namespace AppHotel.Model
{

    //Transportando dados
    public class Hospedagem
    {
        int quantidade_adultos;
        Suite _quarto;

        public Suite QuartoEscolhido
        {
            //Pega a informação do quarto escolhido (erro caso não haja uma opção selecionada)
            get => _quarto;
            set
            {
                if (value == null)                
                    throw new Exception("Erro! Informe o quarto escolhido.");

                 _quarto = value;                
            }
        }

        public int QntAdultos
        {
            //Pega a informação da quantidade de adultos (erro caso não haja uma opção selecionada)
            get => quantidade_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Erro! Informe a quantidade de adultos.");

                quantidade_adultos = value;
            }
        }

        //Não necessita de uma mensagem de erro (a seleção de crianças não é obrigatória)
        public int QntCriancas { get; set; }

        //Pega os dados do date picker (Entrada/Saída) e será usado na ESTADIA
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                //Retorna a quantidade de dias no hotel de acordo com os dados do date picker
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }

        //Faz o cálculo de acordo com quarto escolhido, quantidade de pessoas e tempo de estadia
        public double ValorTotal
        {
            get => ((QntAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }

    }
}
