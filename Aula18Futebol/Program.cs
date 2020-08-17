using System;

namespace Aula18Futebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador ribamar = new Jogador();

            System.Console.WriteLine("Qual o nome do jogador?");
            ribamar.Nome = Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine("Qual a nacionalidade?");
            ribamar.Nacionalidade = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine($"Qual o peso do {ribamar.Nome} atual?");
            ribamar.Peso = float.Parse(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine($"Qual a altura do {ribamar.Nome}?");
            ribamar.Altura = float.Parse(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine($"Qual a data de nascimento do {ribamar.Nome} (dia/mês/ano)?");
            ribamar.DataDeNascimento = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            
            System.Console.WriteLine($"Em qual posição o {ribamar.Nome} joga (escolha somente uma)?\nATA = atacante | MC = meio-campista | DEF = defensor");
            ribamar.Posicao = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine(ribamar.CalcularIdade());
            System.Console.WriteLine(ribamar.VerificarAposentadoria(ribamar.Posicao, ribamar.Nome));
        }
    }
}
