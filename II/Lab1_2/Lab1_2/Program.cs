using System;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Calclue calcule = new Calclue(a, b);
            calcule.afisare();
            Console.WriteLine();
        }
    }

    class Calclue
    {
        private float x, y;
        public Calclue(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float aduna()
        {
            return x + y;
        }
        public float scade()
        {
            return x - y;
        }
        public float inmultire()
        {
            return x * y;
        }
        public float impartire()
        {
            return x / y;
        }
        public void afisare()
        {
            Console.WriteLine("Adunare: {0} \n Scadere: {1} \n Inmultire: {2} \n Impartire: {3}", aduna(), scade(), inmultire(), impartire());
        }
    }
}
