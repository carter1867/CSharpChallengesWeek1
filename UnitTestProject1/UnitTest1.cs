using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyNameandge()
        {
            string firstName = "Carter";
            string lastName = "Kaminski";
            int age = 26;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }
        [TestMethod]
        public void ArrayChallenge()
        {
            string[] movies = { "King Arthur", "Batman", "Pokemon", "Taken" };
        }

        [TestMethod]
        public void DateList()
        {
            List<DateTime> DateList = new List<DateTime>();
            DateTime today = DateTime.Now;
            DateList.Add(today);
            DateList.Add(new DateTime(2020,12,25));
            DateList.Add(new DateTime(2020, 12, 14));
            DateList.Add(new DateTime(1995, 5, 5));
        }

        [TestMethod]
        public void HoursSleep()
        {
            Console.WriteLine("How many hours sleep did you get?");
            int hours = 4;
            if (hours >= 10) 
            {
                Console.WriteLine("Wow, that is a lot of sleep");
            }

            else if (hours >= 8)
            {
                Console.WriteLine("You should be well rested");
            }

            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("oh man get some sleep");
            }
        }

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "okay";
            switch (userDay)
            {
                case "great":
                    Console.WriteLine("So happy for you");
                     break;
                case "Good":
                    Console.WriteLine("It is a good dau then");
                    break;
                case "okay":
                    Console.WriteLine("Hopefully it will get better");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow i guess");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter something above");
                    break;
            }
        }

        [TestMethod]
        public void MaryPoppins()
        {
            string name = "Supercalifragilisticexpialidocious";

            foreach (char letter in name)
            {

                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }

                else
                {
                    Console.WriteLine("Not An I");
                }
            }
            Console.ReadLine();
        }
    }
}

