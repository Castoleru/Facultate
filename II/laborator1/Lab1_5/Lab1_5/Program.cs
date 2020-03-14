using System;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float mediag, mediaa, suma, produs,nr;
            suma = 0;
            produs = 1;

            Console.WriteLine("Introdu numere");
            string citire = Console.ReadLine();
            string[] numereStr = citire.Split(' ');
            foreach(string i in numereStr)
            {
                nr = Convert.ToInt32(i);
                suma += nr;
                produs *= nr;

            }
            mediaa = suma / numereStr.Length;
            mediag = (float)Math.pow(produs,1.0/numereStr.Length);
            Console.WriteLine("Media arit {0} \nMedia geom {1}", mediaa, mediag);

        }
    }
}
