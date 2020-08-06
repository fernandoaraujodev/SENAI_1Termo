using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {
        
        public int parcelas { get; set; }

        public int valorCompra { get; set; }

        public void ComprarDescontoMastercard(float desconto){
            Console.WriteLine($"Compra realizada no valor de R${valorCompra} com {parcelas} parcelas e R$ {desconto} de desconto ");

        }

    }
}