using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class UserProfile
    {
        private static string name;
        private static string surname;
        private static int age;
        private static int height;
        private static int weight;
        
        static void Main()
        {
            name = AskUserAbout("Ваше имя: ");
            surname = AskUserAbout("Ваша фамилия: ");
            age = int.Parse(AskUserAbout("Ваш возраст: "));
            height = int.Parse(AskUserAbout("Ваш рост: "));
            weight = int.Parse(AskUserAbout("Ваш вес: "));

            Console.WriteLine("Ваши данные:");
            Console.WriteLine("Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age +
                ", Рост: " + height + ", Вес: " + weight);
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name,surname,age,
                height,weight);
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}," +
                $" Вес: {weight}");

            Console.ReadLine();
        }

        static string AskUserAbout(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        
    }
}
