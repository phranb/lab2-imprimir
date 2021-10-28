using System;

namespace Interfaces2
{
    public class Documento : Imprimible
    {
        private string _mensaje;

        public Documento()
        {
            _mensaje = "Soy un documento de word";
        }
 
        public void Imprimir()
        {
            Console.WriteLine(_mensaje);
        }
    }
}