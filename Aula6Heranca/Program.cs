using System;

namespace Aula6Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
              CPF cpf = new CPF();
            cpf.nome = "Fernando";
            System.Console.WriteLine( cpf.FazerSaudacao());

            cpf.cpf = "010.010.000-1";
            System.Console.WriteLine( cpf.ValidarCPF());
        
        }
    }
}
