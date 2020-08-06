using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo();
            System.Console.WriteLine();
            System.Console.WriteLine( carro.CalcularPotencia (3000) );
            System.Console.WriteLine( carro.CalcularPotencia(3000, 490) );
            System.Console.WriteLine( carro.CalcularPotencia("HB20", "Hyundai") );
        }
    }
}
