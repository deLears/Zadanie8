using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp18
{
    class Podzadacha2
    {
        static void Main(string[] args)
        {
            /*Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл,
            рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
            double[] chi = new double[10];
            Random Rand = new Random();
            double Summ = 0;
                for (int i = 0; i < 10; i++)
                {
                chi[i] = Rand.Next();
                }
            string path = @"C:\Users\arsle\000test\001.txt";
            
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(chi[i]);
                }
            }
            
            using (StreamReader sr = new StreamReader(path,true))
            {
                for (int i = 0; i < 10; i++)
                {
                    double t = Convert.ToDouble(sr.ReadLine());
                    Summ +=t ;
                }
            }
            Console.WriteLine(Summ);
            Console.ReadKey();
            
                }


        }
    }

