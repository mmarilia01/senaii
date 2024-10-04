
namespace ConsoleApp2
{
    public class Gato : IServivo
    {
        public void Comer() => Console.WriteLine("O gato está comendo.");
        public void Dormir() => Console.WriteLine("O gato está dormindo.");
        public void Respirar() => Console.WriteLine("O gato está respirando.");
        public void Morrer() => Console.WriteLine("O gato morreu.");
    }
}
