using System;
using System.Collections.Generic;

namespace Interfaces2
{
    public class Impresora
    {
        private List<Imprimible> ColaDeImpresion;

        public Impresora()
        {
            ColaDeImpresion = new List<Imprimible>();
        }

        public void AgregarImprimible(Imprimible item)
        {
            ColaDeImpresion.Add(item);
        }

        public void ImprimirTodo()
        {
            Console.WriteLine("***** Imprimiendo Todo *****");
            foreach (Imprimible element in ColaDeImpresion)
            {
                element.Imprimir();
            }
        }
    }
}