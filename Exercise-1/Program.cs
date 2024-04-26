using System;
using static System.Console;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Alim Almatovich Zhainakov";
            string email = "zhainakov.alim@mail.ru";

            int age = 18;
            double itScore = 78.5;
            double mathScore = 65.8;
            double physicsScore = 98.6;
            int totalClasses = 3;



            string pattern = "fullName: {0} \nage: {1} \nemail: {2} \nitScore: {3} \nmathScore {4} \nphysicsScore {5}";
            WriteLine(pattern,
                 fullName,
                 age,
                 email,
                 itScore,
                 mathScore,
                 physicsScore);

            double sum = itScore + mathScore + physicsScore;

            double average = sum / totalClasses;

            WriteLine($"Avarage: {average}");

            ReadLine();

        }
    }
}
