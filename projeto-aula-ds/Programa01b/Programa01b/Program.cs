using Programa01b;

Console.WriteLine("*****SISTEMA DA LOJA*****");
Console.WriteLine();


//INSTÂNCIA É QUANDO pega o objeto da classe e coloca na memoria, NEW é uma forma de instanciar 

Bike bike = new Bike();

Console.WriteLine("Modelo Bike");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capacidade da Bateria");
bike.Bateria = double.Parse (Console.ReadLine());

Console.WriteLine("Peso do ciclista");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade Estimmada de recarga");
bike.RecargaMes = int.Parse(Console.ReadLine());


///EXIBE NA TELA RESULTADO

Console.WriteLine("/n --- RELATÓRIO DESEMPENHO DE BIKE ---");
Console.WriteLine($"Bike: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada: {bike.CalcularAutonomia():F1}por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal():F2}por Km");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal():N2}por Km");
Console.WriteLine($"A Bike é economica? {bike.BikeEconomia()}");
