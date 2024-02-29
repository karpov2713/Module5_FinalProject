using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static string[] GetPetNickNamesFromUser(int number)
        {
            string[] nickNames = new string[number];
            for (int i = 0; i < nickNames.Length; i++)
            {
                Console.Write($"Введите кличку вашего животного {i + 1}: ");
                nickNames[i] = Console.ReadLine();
            }

            return nickNames;
        }

        static string[] GetColorsFromUser(int number)
        {
            string[] favColors = new string[number];
            for (int i = 0; i < favColors.Length; i++)
            {
                Console.Write($"Введите ваш любимый цвет {i + 1}: ");
                favColors[i] = Console.ReadLine();
            }

            return favColors;
        }

        static (string name, string lastName, byte age, bool hasPet ,string[] petNickNames, string[] favColors) dataOfUser()
        {
            (string name, string lastName, byte age, bool hasPet, string[] petNickNames, string[] favColors) UserData;

            string result;
            int amountOfPets = 0;
            int amountOfColors = 0;

            Console.Write("Введите ваше имя: ");
            UserData.name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            UserData.lastName = Console.ReadLine();

            Console.Write("Введите ваш возраст цифрами: ");
            UserData.age = byte.Parse(Console.ReadLine());

            Console.Write("Есть ли у вас животные? Да? или Нет?");
            result = Console.ReadLine();

            if(result == "Да")
            {
                UserData.hasPet = true;

                Console.Write("Сколько у вас животных? ");
                amountOfPets = int.Parse(Console.ReadLine());

                UserData.petNickNames = new string[amountOfPets];
                UserData.petNickNames = GetPetNickNamesFromUser(amountOfPets);
            }
            else
            {
                UserData.hasPet= false;
                amountOfPets= 0;
            }

            Console.WriteLine("Сколько у вас любимых цветов?");
            amountOfColors = int.Parse(Console.ReadLine());

            UserData.favColors = new string[amountOfColors];
            UserData.favColors = GetColorsFromUser(amountOfColors);

        }

        static void Main(string[] args)
        {
            var myApples = 5;
            var herApples = 4;
            var result = myApples == herApples;
            Console.WriteLine(result);

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
