
namespace ConsoleApp2
{
    public class Carro : IMaquina
    {
        public void Ligar() => Console.WriteLine("O carro está ligado.");
        public void Desligar() => Console.WriteLine("O carro está desligado.");
        public void Abastecer() => Console.WriteLine("O carro está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do carro acionado.");
    }
}
