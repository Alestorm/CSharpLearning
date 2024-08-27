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
            Console.WriteLine("***Primitives***");
            Primitives();

            Console.WriteLine("***Strings***");
            Strings();

            Console.WriteLine("***Arrays***");
            Arrays();

            Console.WriteLine("***Lists***");
            Lists();
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
            Console.WriteLine();
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

        #region ARRAYS
        public void Arrays()
        {
            string[] names = { "Thrall", "Jaina Proudmoore", "Illidan Stormrage", "Sylvanas Windrunner", "Varian Wrynn" };


            FillArray();
            NameList(names);
            SumPrices();
            GetIndexName(names, "jaina");
            NumberExistsInArray(22);
            OrderNames(names);
            RandomMatrix();
        }
        public void FillArray()
        {
            int[] numbers = new int[10];
            Console.WriteLine(numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        public void NameList(string[] names)
        {

            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($"Last name: {names[names.Length - 1]}");
            Console.WriteLine();
        }
        public void SumPrices()
        {
            double[] preciosProductos = {
                19.99, 24.95, 12.50, 35.99, 9.99,
                15.49, 29.99, 8.99, 22.50, 17.99,
                10.99, 39.99, 21.49, 14.99, 18.99
            };
            double total = 0.0;
            for (int i = 0; i < preciosProductos.Length; i++)
            {
                total += preciosProductos[i];
            }
            Console.WriteLine("Sum prices: " + total);
            Console.WriteLine();
        }
        public void GetIndexName(string[] names, string query)
        {
            int index = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Contains(query.ToLower()))
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"{query} is at position {index} {Environment.NewLine}");
        }
        public void NumberExistsInArray(int findNumber)
        {
            int[] temperatures = { 25, 18, 32, 15, 28,
                        -2, 10, 22, 30, 26,
                        21, 19, 29, 17, 24 };
            Console.WriteLine(temperatures.Any(t => t == findNumber) ? $"{findNumber} is in the array" : $"{findNumber} is not in the array");
            var orderedTemperatures = temperatures.OrderBy(t => t).ToList();
            for (int i = 0; i < orderedTemperatures.Count; i++)
            {
                Console.Write(orderedTemperatures[i] + " ");
            }
            Console.WriteLine();
        }

        public void OrderNames(string[] names)
        {
            names = names.OrderBy(n => n).ToArray<string>();
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + ",");
            }
            Console.WriteLine("\n");
        }

        public void RandomMatrix()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion

        #region LISTS
        public void Lists()
        {
            CreateRandomList();
            MultiplyIntList(2);
            SumListNumbers();
            FindInList(300);
            OrderCountries();
            EliminateDuplicatedElements();
            GetPairsInList();
            MatrixList();
        }
        public void CreateRandomList()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(0, 100));
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine($"\nFirst element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}\n");
        }
        public void MultiplyIntList(int multiplier)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, };
            var newList = list.Select(l => l * multiplier).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public void SumListNumbers()
        {
            int sum = 0;
            List<int> distances = new List<int>() { 100, 250, 50, 120, 180,
                                            300, 450, 60, 150, 210,
                                            350, 500, 70, 160, 220,
                                            360, 550, 80, 170, 230 };
            sum = distances.Sum(d => d);
            Console.WriteLine($"Total distance: {sum}\n");

        }
        public void FindInList(int findNumber)
        {
            List<int> distances = new List<int>() { 100, 250, 50, 120, 180,
                                            300, 450, 60, 150, 210,
                                            350, 500, 70, 160, 220,
                                            360, 550, 80, 170, 230 };
            Console.WriteLine(distances.Any(d => d == findNumber) ? $"{findNumber} present in list\n" : $"{findNumber} not in list\n");
        }
        public void OrderCountries()
        {
            List<string> countries = new List<string> { "Argentina", "Brasil", "México", "España", "Estados Unidos", "Francia", "Alemania", "Italia", "Japón", "China" };
            List<string> desc = countries.OrderByDescending(d => d).ToList();
            List<string> asc = countries.OrderBy(d => d).ToList();

            Console.WriteLine("Descending list");
            for (int i = 0; i < desc.Count; i++)
            {
                Console.Write(desc[i] + " ");
            }

            Console.WriteLine("\nAscending list");
            for (int i = 0; i < asc.Count; i++)
            {
                Console.Write(asc[i] + " ");
            }
            Console.WriteLine();
        }
        public void EliminateDuplicatedElements()
        {
            List<int> duplicates = new List<int> { 1, 2, 3, 2, 4, 5, 5, 6, 7, 8, 9, 10, 10, 11, 12, 13, 14, 15, 15, 16 };
            List<int> unique = duplicates.Distinct().ToList();
            Console.WriteLine("\nDuplicates list: ");
            foreach (int i in duplicates)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nUnique list: ");
            foreach (int i in unique)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void GetPairsInList()
        {
            List<int> prices = new List<int>() { 10, 25, 15, 30, 20, 5, 12, 8, 18, 22, 17, 9, 28, 24, 16, 7, 14, 11, 6, 21 };
            List<int> pairPrices = prices.Where(p => p % 2 == 0).ToList();

            Console.WriteLine("\nPrices list: ");
            foreach (int i in prices)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nHighest price: " + prices.Max(p => p));
            Console.WriteLine("Lowest price: " + prices.Min());
            Console.WriteLine("Average price: " + (double)prices.Sum() / prices.Count);

            Console.WriteLine("\nPair prices list: ");
            foreach (int i in pairPrices)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void MatrixList()
        {
            Random random = new Random();
            List<List<int>> matrix = new List<List<int>>();

            // Add 5 empty inner lists to represent the rows
            for (int i = 0; i < 5; i++)
            {
                matrix.Add(new List<int>());
            }
            // Now you can access elements in the inner loop
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i].Add(random.Next(0, 2));
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Row sum: " + matrix[i].Sum());
            }

            for (int j = 0; j < 5; j++)
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += matrix[i][j];
                }
                Console.WriteLine("Column sum: {1}", j + 1, sum);
            }
            Console.WriteLine("\n");

        }
        #endregion
    }
}