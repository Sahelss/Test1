using System;

namespace test._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vänligen mata in din ålder: ");
            int age = int.Parse(Console.ReadLine());
            ålder(age);
        }

        static void ålder(int age)
        {
            if (age >= 18) 
            {
                Console.WriteLine("Du är myndig och kan rösta i valet!");
            }
            else
            {
                Console.WriteLine($"Du är inte myndig än, vänta tills din 18 års dag");
            }
        }
    }
}