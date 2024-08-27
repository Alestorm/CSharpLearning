using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.types
{
    public class Basics
    {
        public void BasicsMain()
        {
            Primitives();
            Strings();
        }
        #region PRIMITIVES
        public void Primitives()
        {
            int age = 30;
            long population = 7800000000;
            short temperature = -5;
            byte qualification = 100;
            float height = 1.75f;
            double price = 19.99;
            decimal balance = 1500.50m;
            char initial = 'A';
            bool isStudent = true;

            Console.WriteLine("PRIMITIVES");
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Population: " + population);
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Qualification: " + qualification);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Is student? " + isStudent);
            Console.WriteLine();
        }

        #endregion

        #region STRINGS
        public void Strings()
        {
            string phrase = "Working with strings";
            ReversePhrase(phrase);
            CountVowels(phrase);
            CountWords(phrase);
            ReplaceSubstring(phrase, "ing", "ed");
            OrderByAlphabet(phrase);
            CaesarCipher(phrase, 3);
        }

        public void ReversePhrase(string phrase)
        {
            string reversed = "";
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                reversed += phrase[i];
            }
            Console.WriteLine(reversed);
        }

        public void CountVowels(string phrase)
        {
            int c = 0;
            phrase = phrase.Trim().ToLower();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
                {
                    c++;
                }
            }
            Console.WriteLine($"{phrase} has {c} vowels");
        }

        public void CountWords(string phrase)
        {
            int c = phrase.Split(' ').Length;
            Console.WriteLine($"{phrase} has {c} words");
        }

        public void ReplaceSubstring(string phrase, string oldSub, string newSub)
        {
            phrase = phrase.Replace(oldSub, newSub);
            Console.WriteLine(phrase);
        }

        public void OrderByAlphabet(string phrase)
        {
            string[] words = phrase.Split(" ");
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();

        }
        public void CaesarCipher(string phrase, int positions)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string caesarStr = "";


            positions = positions % alphabet.Length;

            for (int i = 0; i < phrase.Length; i++)
            {
                char currentChar = phrase[i];
                if (char.IsLetter(currentChar))
                {
                    bool isUpper = char.IsUpper(currentChar);

                    int index = alphabet.IndexOf(char.ToLower(currentChar));

                    int newIndex = (index + positions) % alphabet.Length;

                    char newChar = alphabet[newIndex];
                    caesarStr += isUpper ? char.ToUpper(newChar) : newChar;
                }
                else
                {
                    caesarStr += currentChar;
                }
            }

            Console.WriteLine(caesarStr);
        }

        #endregion
    }
}
