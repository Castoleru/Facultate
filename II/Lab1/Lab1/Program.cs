using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrElemente = int.Parse(Console.ReadLine());
            int[] fibo = new int[100];
            fibo[0] = 1;
            fibo[1] = 1;
            Console.WriteLine("{0},{1}",fibo[0],fibo[1]);
            int i = 2;
            for(i=2;i<=nrElemente;i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                Console.Write(",{0}",fibo[i]);
            }
 
            Console.ReadLine();
        }
    }
}
