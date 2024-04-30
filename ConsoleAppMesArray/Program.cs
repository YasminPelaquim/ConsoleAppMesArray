using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] mes = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite o número do mês: ");
            int nu = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi " + mes[nu]);



            Console.ReadKey();

            String[] mees = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite o número do mês: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi " + mees[num - 1]);

            Console.ReadKey();
        }
    }
}
 