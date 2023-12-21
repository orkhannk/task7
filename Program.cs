using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("d ededini daxil edin ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e ededini daxil edin ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("f ededini daxil edin ");
            int f = Convert.ToInt32(Console.ReadLine());

            if (d >= e && d >= f)
            {
                Console.WriteLine($"{d} ededi en boyukdur");

            }
            else if (e >= d && e >= f)
            {
                Console.WriteLine($"{e} ededi en boyukdur");

            }
            else
            {
                Console.WriteLine($"{f} ededi en boyukdur");

            }
            Console.ReadLine();



            Console.WriteLine("bir ededi daxil edin ");
            int eded;
            do
            {
                eded = Convert.ToInt32(Console.ReadLine());

            } while (eded <= 0 || eded % 2 != 0);
            int p = eded * eded;
            Console.WriteLine("ededin kvadrati:" + p);


            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"arrayda yerlesen {i + 1} ci ededi daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            Console.WriteLine("arrayda yerlesen ededlerin cemi :" + sum);
            Console.ReadLine();



            Console.WriteLine("bir yazi daxil edin");
            string yazi = Console.ReadLine();
            bool aVarmi = false;
            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == 'A' || yazi[i] == 'a')
                {
                    aVarmi = true;
                    break;
                }
            }
            if (aVarmi)
            {
                Console.WriteLine("yazin icerisinde 'A' herifi var");

            }
            else
            {
                Console.WriteLine("yazinin icerisinde 'A' herifi yoxdur");
            }

            Console.WriteLine("bir metin  daxil edin: ");
            string metin  = Console.ReadLine();
            int aSayi = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'A' || metin[i] == 'a')
                {
                    aSayi++;

                }
            }
            Console.WriteLine($"Metin icerisinde {aSayi} ədəd 'A' hərfi var.");


        }   
    }
}
