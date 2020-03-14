using System;

namespace Lab1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inaltimea: ");
            int inaltime = int.Parse(Console.ReadLine());
            Console.WriteLine("Varsta: ");
            int varsta= int.Parse(Console.ReadLine());
            Console.WriteLine("Sex");
            string sex = Console.ReadLine();
            Greutate greutate = new Greutate(inaltime, varsta, sex);
            greutate.afisare();
            Console.ReadLine();

        }
    }
    class Greutate
    {
        private int inaltime, varsta;
        private string sex;
        public Greutate(int inaltime, int varsta, string sex)
        {
            this.inaltime = inaltime;
            this.varsta = varsta;
            this.sex = sex;
        }
        public float GreutateM()
        {
            return (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
        }
        public float GreutateF()
        {
            return (inaltime - 100 - ((inaltime - 150) / (float)(2.5))) + ((varsta - 20) / 6);
        }
        public void afisare()
        {
            if(sex=="Masculin")
            {
                Console.WriteLine("Greutatea ideala{0} ", GreutateM());
            }
            else
            {
                Console.WriteLine("Greutatea ideala{0} ", GreutateF());
                Console.WriteLine("Greutatea ideala{0} ", GreutateF());
            }
        }
    }

}
