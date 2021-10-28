using System;

namespace Interfaces2
{
    public class Contrato : Imprimible
    {
        private string _mensaje;

        public Contrato()
        {
            _mensaje = "Soy un contrato muy legal";
        }

        public void Imprimir()
        {
            Console.WriteLine(_mensaje);
        }
        
        
        
    }
}