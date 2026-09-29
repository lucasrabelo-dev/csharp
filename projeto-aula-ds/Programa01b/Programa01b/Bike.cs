namespace Programa01b
{
    internal class Bike
    {
        public string? Modelo { get; set; }
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }

        // METODOS = ação,  

        // OBJETO É TUDO AQUILO QUE POSSUI CARACTERISTICAS, se é unico, é nso um objeto

        // CLASSE: a partir do momento que ele vira um molde, ou exemplo para outros objetos, ele vira uma CLASSE

        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool peso = PesoCiclista > 90.0;
            // se o peso for acima de 90kt, reduz para 15% a autonomia
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;
        }

        public double CalcularConsumoMensal()
        {
            double cargaPorKm = Bateria / 1000.0;
            return cargaPorKm = RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double preço = 0.80;
            return CalcularConsumoMensal() * preço;
        }

        public bool BikeEconomia()
        {
            return (CalcularCustoMensal() < 15.0) || (CalcularAutonomia() > 40.0);
        }

    }
}
