using System;

namespace ZenginVeKitSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int tpl = 0;
            for (int i = 21; i <= 1000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        tpl += j;
                    }

                }
                if (i > tpl)
                {
                    Console.WriteLine("{0} sayısı kıttır", i);
                }
                else if (i < tpl)
                {
                    Console.WriteLine("{0} sayısı zengindir", i);
                }
                tpl = 0;
            }
        }
    }
}
