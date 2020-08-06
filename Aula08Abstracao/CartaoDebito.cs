using System;
namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        //Atributos
        public float saldo;

        //Métodos
        public string Transferir(float valor){
            return "Transferência efetuada com sucesso!";
        }
        public string PagarTitulo(){
            return "Titulo pago com sucesso!";
        }  

        public void ConsultarSaldo (bool consulta){
            if(consulta == true){
            }
        }


    }
}