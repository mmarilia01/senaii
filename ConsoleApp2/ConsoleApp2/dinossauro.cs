namespace ConsoleApp2
{
    public class Dinossauro : IServivo
    {
        public void Comer() => Console.WriteLine("O dinossauro está comendo.");
        public void Dormir() => Console.WriteLine("O dinossauro está dormindo.");
        public void Respirar() => Console.WriteLine("O dinossauro está respirando.");
        public void Morrer() => Console.WriteLine("O dinossauro morreu.");
    }

}
