using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp17
{
    class Podzadacha1
    {
        static void Main(string[] args)
        {
            // 1.Выберите любую папку на своем компьютере, имеющую вложенные директории.
            // Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            string[] dirs = Directory.GetDirectories(@"C:\Users\arsle\000test\");
            string[] files = Directory.GetFiles(@"C:\Users\arsle\000test\", "*.*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();



        }
    }
}
