
namespace ConsoleApp2
{
    public class Fantasma : IPairador
    {
        public void Decolar() => Console.WriteLine("O fantasma decolou.");
        public void Planar() => Console.WriteLine("O fantasma está planando.");
        public void Pousar() => Console.WriteLine("O fantasma pousou.");
        public void Cair() => Console.WriteLine("O fantasma caiu.");
        public void Pairar() => Console.WriteLine("O fantasma está pairando.");
    }
}
