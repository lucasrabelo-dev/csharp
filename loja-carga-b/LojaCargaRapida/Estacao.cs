//POO:
//Abstração, Herança, Poliorfismo e Encapsulamento
using System.Reflection.Metadata.Ecma335;

namespace LojaCargaRapida
{
    class Estacao //molde, é uma Abstração 
    {

        //PROPRIEDADES (ATRIBUTOS)
        public string Motorista { get; set; }

        public double CapacidadeKwh { get; set; }

        public double PorcentagemAtual { get; set; }

        public double PotenciaKw { get; set; }


        //MÉTODOS (AÇÕES)

        public double CalcularKWNecessarios()
        {
            double porcentagemFaltantes = (100.00 - PorcentagemAtual) / 100.00;
            return CapacidadeKwh * porcentagemFaltantes; ;
        }

        //MÉTODO QUE CALCULA O TEMPO NECESSÁRIO

        public double CalcularTempoHoras()
        {
            return CalcularKWNecessarios() / PotenciaKw;
        }

        //MÉTODO PARA SABER O VALOR PARA CARREGAR

        public double CalcularValor()
        {
            const double PRECO_POR_KWH = 2.50;

            return CalcularKWNecessarios() * PRECO_POR_KWH;
        }

        //MÉTODO PARA SABER SE O CARREGAMENTO É RÁPIDO

        public bool CarregamentoRapido() 
        
        {
            return (PotenciaKw >= 50.0) && (CalcularTempoHoras() < 1.0);
        }
    }

}
