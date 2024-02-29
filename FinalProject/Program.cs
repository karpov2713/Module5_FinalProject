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

        static (string name, string lastName, byte age, bool hasPet, string[] petNickNames, bool hasFavColors, string[] favColors) DataOfUser()
        {
            (string name, string lastName, byte age, bool hasPet, string[] petNickNames, bool hasFavColors, string[] favColors) UserData;

            string petResult;
            int amountOfPets;
            string colorResult;
            int amountOfColors;

            Console.Write("Введите ваше имя: ");
            UserData.name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            UserData.lastName = Console.ReadLine();

            Console.Write("Введите ваш возраст цифрами: ");
            UserData.age = byte.Parse(Console.ReadLine());

            Console.Write("Есть ли у вас животные? Да / Нет? ");
            petResult = Console.ReadLine();

            if (petResult == "Да")
            {
                UserData.hasPet = true;

                Console.Write("Сколько у вас животных? ");
                amountOfPets = int.Parse(Console.ReadLine());

                UserData.petNickNames = new string[amountOfPets];
                UserData.petNickNames = GetPetNickNamesFromUser(amountOfPets);
            }
            else
            {
                UserData.hasPet = false;
                UserData.petNickNames = null;
            }

            Console.Write("У вас есть любимые цвета? Да / Нет? ");
            colorResult = Console.ReadLine();

            if (colorResult == "Да")
            {
                UserData.hasFavColors = true;

                Console.WriteLine("Сколько у вас любимых цветов?");
                amountOfColors = int.Parse(Console.ReadLine());

                UserData.favColors = new string[amountOfColors];
                UserData.favColors = GetColorsFromUser(amountOfColors);
            }
            else
            {
                UserData.hasFavColors = false;
                UserData.favColors = null;
            }

            return UserData;
        }

        static void ShowUserData((string name, string lastName, byte age, bool hasPet, string[] petNickNames, bool hasFavColors, string[] favColors) User)
        {
            Console.WriteLine($"Имя: {User.name}");
            Console.WriteLine($"Фамилия: {User.lastName}");
            Console.WriteLine($"Возраст: {User.age}");

            if (User.hasPet == true)
            {
                Console.WriteLine($"Животных всего - {User.petNickNames.Length}:");
                for (int i = 0; i < User.petNickNames.Length; i++)
                {
                    Console.WriteLine(User.petNickNames[i]);
                }
            }
            else
            {
                Console.WriteLine("Животных нет.");
            }

            if (User.hasFavColors == true)
            {
                Console.WriteLine($"Любимых цветов - {User.favColors.Length}:");
                for (int i = 0; i < User.favColors.Length; i++)
                {
                    Console.WriteLine(User.favColors[i]);
                }
            }
            else
            {
                Console.WriteLine("Любимых цветов нет.");
            }
        }

        static void Main(string[] args)
        {
            (string name, string lastName, byte age, bool hasPet, string[] petNickNames, bool hasFavColors, string[] favColors) UserData;

            UserData = DataOfUser();

            ShowUserData(UserData);
        }
    }
}
