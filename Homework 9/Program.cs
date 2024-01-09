using System;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod

            DateTime birthDate = new DateTime(2007, 8, 26);
            var age = (DateTime.Now.Year-birthDate.Year);

            Console.WriteLine(age);
        }
    }
}
