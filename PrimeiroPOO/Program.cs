using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Automovel HB20 = new Automovel();
            HB20.motor = "V8 turbo";
        
            Console.WriteLine(HB20.modelo);
            
            Console.WriteLine(HB20.motor);
            
            Console.WriteLine(HB20.Andar());
        
            Console.WriteLine(HB20.Frear());
        }
    }
}
