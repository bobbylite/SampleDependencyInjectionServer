using DependencyInjectionApp.Common;
using System.Collections;
using System.Linq;

namespace DependencyInjectionApp.Services
{
    public class PalindromeFinderService : IAutoStart
    {
        public void Start()
        {
            var testSet = new string [] {"racecar", "mike", "kayak", "milk"};
            ConsoleTester(testSet);
        }

        public void Stop()
        {
            
        }

        private bool StartPalindromeTest(string word)
        {
            var charList = word.ToCharArray().ToList();
            charList.Reverse();
            string stringWord = string.Join("", charList);

            return word == stringWord;
        }

        private void ConsoleTester(IEnumerable stringCollection) 
        {
            foreach (string test in stringCollection)
            {
                System.Console.WriteLine($"is '{test}' a palindrome: {StartPalindromeTest(test)}");
            }
        }
    }
}