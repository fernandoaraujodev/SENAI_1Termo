using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        private const int V = 100;

        static void Main(string[] args)
        {
            Cartao tarjeta = new Cartao();
            tarjeta.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 2;
            master.ComprarDescontoMastercard(15f);
            master.valorCompra = 187;

        }
    }
}

