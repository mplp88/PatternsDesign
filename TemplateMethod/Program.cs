using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VacacionesLiq v = new VacacionesLiq();
            v.LiquidarTemplateMethod();
            Console.ReadLine();

            Console.Clear();

            AguinaldoLiq a = new AguinaldoLiq();
            a.LiquidarTemplateMethod();

            Console.ReadKey();
        }
    }
}
