using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creo los nodos
            NodoCompuesto n1 = new NodoCompuesto();
            NodoCompuesto n2 = new NodoCompuesto();
            NodoCompuesto n3 = new NodoCompuesto();
            NodoCompuesto n4 = new NodoCompuesto();

            NodoSimple ns1 = new NodoSimple();
            //Les pongo id y valor que esperan los nodos
            n1.IdNodo = 1;
            n1.ValorBuscado = 99;
            n2.IdNodo = 2;
            n2.ValorBuscado = 98;
            n3.IdNodo = 3;
            n3.ValorBuscado = 97;
            n4.IdNodo = 4;
            n4.ValorBuscado = 96;

            ns1.IdNodo = 1;
            ns1.ValorBuscado = 95;

            //Los encadeno
            n1.Hijo = n2;
            n2.Hijo = n3;
            n3.Hijo = n4;
            //n4.Hijo = ns1;

            //ejecuto la búsqueda sobre el primer nodo de la candena
            n1.BuscarValor(95);
            Console.ReadKey();

            

        }
    }
}
