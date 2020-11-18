using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpChallenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
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
