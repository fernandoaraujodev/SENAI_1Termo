using System;

namespace Aula13ProjetoUberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Passageiro pessoa = new Passageiro();

            System.Console.WriteLine("\nDigite seu email:");
            string login = Console.ReadLine();

            System.Console.WriteLine("\nDigite sua senha:");
            string senha = Console.ReadLine();

            pessoa.Login(login, senha);

            if ( pessoa.TokenLogin != "" && pessoa.TokenLogin != null){

                System.Console.WriteLine("\nEntrada autorizada!");
                //System.Console.WriteLine(pessoa.TokenLogin);

                System.Console.WriteLine("\ninsira o numero correpondente a ação que você deseja fazer: \n1 - Adicionar cartão \n2 - Excluir cartão \n3 - Solicitar motorista");
                string escolher = Console.ReadLine();

                switch (escolher){

                    case "1":
                    pessoa.CadastrarCartao();
                    break;

                    case "2":
                    pessoa.ExcluirCartao();
                    break;

                    case "3": 
                    pessoa.SolicitarMotorista();
                    break;

                }


            }else{
                System.Console.WriteLine("\nEmail ou senha estão errados! Tente novamente");
            }

            


        }
    }
}
