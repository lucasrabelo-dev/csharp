namespace pertsCity
{
    class petsCity
    {
        public string NomePet { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadesBanho { get; set; }
        public int IdadeAnimal { get; set; }


        // METODOS
        public double calcularDesconto()
        {
            double ValotTotal = PrecoUnitario * QuantidadesBanho;

            if (QuantidadesBanho >= 10)
            {
                return ValotTotal * 0.10; //10%

            }
            return 0.0;

        }
        //MERTODO CALCULAR VALOR FINAL COM DESCONTO APLICADO
        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoUnitario * QuantidadesBanho;
            double Desconto = calcularDesconto();
            return valorTotalBruto - Desconto;
        }
        public double Calcularparcela()
        {
            return CalcularValorFinal() / 3.0;
        }
        public bool ValidaBrinde()
        {
            return (IdadeAnimal >= 12 && QuantidadesBanho >= 6) || (CalcularValorFinal() > 100.0);


        }

    }



}