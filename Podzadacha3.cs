using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class Podzadacha3
    {
        static void Main(string[] args)
            /*Вручную подготовьте текстовый файл с фрагментом текста.Напишите программу,
             которая выводит статистику по файлу - количество символов, строк и слов в тексте.
            */
        {
            string path = @"C:\Users\arsle\000test\Толстой.txt";
            string k = "";
            string s = "";
            string h = "";
            int hcount = 0;
            string[] textMass1;
            string[] textMass2;

            using (StreamReader sk = new StreamReader(path, true))
            {
                while (sk.EndOfStream != true)
                {
                    k += sk.ReadToEnd();
                }
                textMass1 = k.Split(new string[] { "\r\n" }, System.StringSplitOptions.None);
                
            }
            Console.WriteLine("Количество абзацев (переноса строк):");
            Console.WriteLine(textMass1.Length);

            using (StreamReader sr = new StreamReader(path, true))
            {
                while (sr.EndOfStream != true)
                {
                    s += sr.ReadToEnd();
                }
                textMass2 = s.Split(' ');
            }
            Console.WriteLine("Количество слов:");
            Console.WriteLine(textMass2.Length);

            using (StreamReader sh = new StreamReader(path, true))
            {
                while (sh.Read() > -1)
                {
                    hcount++;
                }
            }

            Console.WriteLine("Количество символов:{0}", hcount);

            Console.ReadKey();
        }
    }
}
