using System;

namespace ConsoleNameReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string fullName;
            string reversedName;
            string charCount;

            Console.WriteLine("What is your first name?\n");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?\n");
            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;
            charCount = fullName.Length.ToString();
            reversedName = NameReverse(fullName);

            Console.WriteLine("Your reversed name is " + reversedName + "\n");
            Console.WriteLine("Your name is " + charCount + "characters long.\n");

        }
        private static string NameReverse(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
