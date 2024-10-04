
namespace ConsoleApp2
{
  public class Superman : IVoador, IPairador, IServivo
{
    public void Decolar() => Console.WriteLine("Superman decolou.");
    public void Planar() => Console.WriteLine("Superman está planando.");
    public void Pousar() => Console.WriteLine("Superman pousou.");
    public void Cair() => Console.WriteLine("Superman caiu.");
    public void Pairar() => Console.WriteLine("Superman está pairando.");

    public void Comer() => Console.WriteLine("o superman esta cochilando.");
    public void Dormir() => Console.WriteLine("o superman esta se alimentado.");
    public void Respirar() => Console.WriteLine("o superman esta a respirar.");
        public void Morrer() => Console.WriteLine("o superman e imortal.");
    }
}
