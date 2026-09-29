namespace LojaDoces
{
    internal class ProducaoDoces
    {
        // ATRIBUTOS

        public string? Confeiteiro { get; set; }
        public double CapacidadeKg { get; set; } // CAPACIDADE MÁXIMA/PESO TOTAL DO LOTE EM KG
        public double PorcentagemPronta { get; set; } // PERCENTUAL DO QUE JÁ FOI PRODUZIDO (0-100)
        public double TaxaProduçãoPorHora { get; set; } // VELOCIDADE DE PRODUÇÃO EM (KG PRODUZIDOS POR HORA)

        // MÉTODOS

        public double CalcularKgFaltantes() // DETERMINA QUANTO KG FALTAM PARA ATINGIR A CAPACIDADE TOTAL DO LOTE
        {
            double KgFaltantes = (100 - CapacidadeKg) / 100;
            return CapacidadeKg * KgFaltantes;
        }

        public double CalcularTempoRestanteHoras() // TEMPO ESTIMADO PARA CONCLUIR A QUANTIDADE RESTANTE, SE BASEANDO NA TAXA DE PRODUÇÃO
        {
            return CalcularKgFaltantes() / TaxaProduçãoPorHora;
        }

        public double CalcularValorFaltante() // VALOR MONETÁRIO EQUIVANTE AOS KG QUE FALTAM, CONSIDERANDO QUE CADA KG TEM O VALOR FICO DE 45,50/KG
        {
            double ValorKg = 45.50;
            return CalcularKgFaltantes() * ValorKg;
        }

        public bool ProducaoExpressa() // DETERMINA SE A VELOCIDADE DE PRODUÇÃO É EFICIENTE. SE FOR ACIMA DE 20KG/H EM 1H, SERÁ
        {
            return (TaxaProduçãoPorHora >= 20) && (CalcularTempoRestanteHoras() < 1);
        }

    }
}
