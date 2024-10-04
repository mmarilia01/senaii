
namespace ConsoleApp2
{
    public class Cao : IServivo
    {
        public void Comer() => Console.WriteLine("O cão está comendo.");
        public void Dormir() => Console.WriteLine("O cão está dormindo.");
        public void Respirar() => Console.WriteLine("O cão está respirando.");
        public void Morrer() => Console.WriteLine("O cão morreu.");
    }
}
