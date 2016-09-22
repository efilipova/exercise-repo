using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', (2 * n) + 1));
            int dots = n;
            int underline = (2 * n) - 1;
            int total = (4 * n) + 3;

            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",new string('.',dots),new string('_',underline));
                dots--;
                underline += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',(total - 9)/2));
            Console.WriteLine("\\\\{0}//",new string ('_',total-4));

            dots = 1;
            underline = total - 6;
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string ('.',dots), new string('_', underline));
                dots++;
                underline -= 2;
            }
        }
    }
}
