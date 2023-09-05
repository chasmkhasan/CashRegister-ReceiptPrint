using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class Pet
    {
        private string? name;
        private int age;
        private string? gender;
        private bool isFemale;

        public void Start()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome To Kid's Fair!");
            Console.WriteLine("***************************");
            ReadAndSavePetData();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            DisplayPetInfo();
            ReadDateTime();
        }

        private void ReadAndSavePetData()
        {
            ReadName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadAge();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadGender();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        private void ReadName()
        {
            Console.WriteLine();
            Console.WriteLine("What is the name of your Pet?");
            name = Console.ReadLine().ToUpper();
            Console.WriteLine();
        }

        private void ReadAge()
        {
            Console.WriteLine();
            Console.WriteLine("What is " + name + "'s Age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        private void ReadGender()
        {
            Console.WriteLine();
            Console.Write("Is your " + name + " a Female? y/n ");
            string gender = Console.ReadLine();
            char reply = gender[0];

            if ((reply == 'f') || (reply == 'm'))

            {
                isFemale = true;
            }

            else
            {
                isFemale &= false;
            }

            Console.WriteLine();
        }

        private void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome To Kid's Fair!");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.Write("Name: " + name + "'s Age is: " + age);
            Console.WriteLine();
            Console.Write("" + name + " is a Good Girl.");
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine();
        }
        private void ReadDateTime()
        {
            Console.WriteLine();
            DateTime now = DateTime.Now;
            Console.WriteLine("Receipt has been print on: " + now);
        }
    }
}
