using System;

namespace Interfaces2
{
    public class Foto : Imprimible
    {
        private string _mensaje;

        public Foto()
        {
            _mensaje = "Soy una selfie pal insta";
        }

        public void Imprimir()
        {
            Console.WriteLine(_mensaje);
        }
    }
}