namespace Aula01_B.Models
{
    public class Carro // ABSTRAÇÃO
    {
         //PROPRIEDADES
         public string Marca { get; set; } //get pega e set salva ENCAPSULAMENTO 
         public string Modelo { get; set; }
        public string Cor { get; set; }

        //MÉTODOS (ações)

        public string Acelerar()
        {
            return $"0 {Modelo} {Marca}  esta acelerando"; //CONCATENAÇÃO 
        }

    }
}
