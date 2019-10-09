using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
       
            static void Main(string[] args)
            {
                //Estrategia 1
                GuardarPDF pdf = new GuardarPDF();

                //Estrategia 2
                GuardarHTML html = new GuardarHTML();
                
                EditorDeTexto e = new EditorDeTexto(pdf);

                e.TextoContenido = "Este es el texto a guardar";

                e.GuardarTexto();

                Console.ReadKey();

            }
      
    }
}
