using System;

namespace Aula15TryCatch
{
    public class User
    {
        public string app = "Whatsapp";
        public bool Confirmar {get;set;}
        public void Autorizar(){

            Console.WriteLine($"O {app} pode acessar sua camera? true = sim | false = não");

            try{

                Confirmar = Boolean.Parse(Console.ReadLine ());
            }catch(Exception){
                
                Console.WriteLine("Tente novamente! Os caracteres inseridos não são válidos");
            }

        }

    }
}