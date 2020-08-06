using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Messi messi = new Messi();
            messi.Correr(); messi.FazerGols(); messi.DriblarAdversários(); messi.Lesionar();
            
            Neymar neymar = new Neymar();
            neymar.Correr(); neymar.FazerGols(); neymar.DriblarAdversários(); neymar.Lesionar();
            
            CristianoRonaldo cristianoRonaldo = new CristianoRonaldo();
            cristianoRonaldo.Correr(); cristianoRonaldo.FazerGols(); cristianoRonaldo.DriblarAdversários(); cristianoRonaldo.Lesionar();

        }
    }
}
