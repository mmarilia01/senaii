﻿namespace ConsoleApp2
{
    public class Trem : IMaquina
    {
        public void Ligar() => Console.WriteLine("O trem está ligado.");
        public void Desligar() => Console.WriteLine("O trem está desligado.");
        public void Abastecer() => Console.WriteLine("O trem está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do trem acionado.");
    }
}
