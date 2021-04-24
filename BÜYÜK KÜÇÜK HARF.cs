using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            char harf;
              devam:
            Console.Write("klavyeden harf giriniz: ");
            i = Console.Read();
            if (i >= 65 && i <= 90) 
            {
                i = i + 32;
                harf = Convert.ToChar(i);
                Console.WriteLine("küçük harf: {0}", harf);
            }

            else if (i >= 97 && i <= 122) 
            {
                i = i - 32;
                harf = Convert.ToChar(i);
                Console.WriteLine("büyük harf: {0}", harf);


            }
            else if (i>=231 && i<=252)
            {
                i = i - 32;
                harf = Convert.ToChar(i);
                Console.WriteLine("küçük harf: {0}", harf);
            }
            else if (i>=199 && i<=220)
            {
                i = i + 32;
                harf = Convert.ToChar(i);
                Console.WriteLine("küçük harf: {0}", harf);

            }
            else
            {
                Console.WriteLine("lütfen harf giriniz...");

            }
            Console.ReadLine();
            goto devam;
        }
    }
}
