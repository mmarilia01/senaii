namespace ConsoleApp2
{
    namespace ConsoleApp3
    {
        public class BeijaFlor : IMaquina
        {
            public void Ligar() => Console.WriteLine(" o Beija-flor voou.");
            public void Desligar() => Console.WriteLine(" o Beija-flor pousou.");
            public void Abastecer() => Console.WriteLine(" o Beija-flor esta comendo.");
            public void Alerta() => Console.WriteLine("o beija-flor fez barulho.");
        }
    }
}
