using System;

namespace Lab1_3
{
    class Program
    {
        static float conversieCF(float cels)
        {
            return cels * 9 / 5 + 32;
        }
        static float conversieFC(float far)
        {
            return (far-32)*5/9;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu valoarea in celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            Console.WriteLine("Introdu valoarea in far: ");
            float far = float.Parse(Console.ReadLine());
            Console.WriteLine("Din celsius in far: {0} \nDin far in celsius: {1}",conversieCF(celsius),conversieFC(far));
            Console.ReadLine();
        }
    }
}
