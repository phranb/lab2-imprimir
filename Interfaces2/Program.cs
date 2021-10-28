using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato miContrato = new Contrato();
            Documento miDoc = new Documento();
            Foto miFoto = new Foto();

            Impresora impresora = new Impresora();
            
            miContrato.Imprimir();
            miDoc.Imprimir();
            miFoto.Imprimir();
            
            impresora.AgregarImprimible(miContrato);
            impresora.AgregarImprimible(miFoto);
            impresora.AgregarImprimible(miDoc);
            
            impresora.ImprimirTodo();

        }
    }
}