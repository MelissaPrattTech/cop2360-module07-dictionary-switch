using System;
using System.Collections.Generic;

namespace Module07DictionarySwitch //Project Namespace - Katie
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseDictionary = new Dictionary<string, List<string>>();
            bool running = true;

            while (running)//Displays menu options. - Katie 
            {
                Console.WriteLine("\n--- Dictionary Menu ---");
                Console.WriteLine("1. Populate Dictionary");
                Console.WriteLine("2. Display Contents");
                Console.WriteLine("3. Remove a Key");
                Console.WriteLine("4. Add a New Key and Value");
                Console.WriteLine("5. Add Value to an Existing Key");
                Console.WriteLine("6. Sort Keys");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PopulateDictionary(courseDictionary);
                        break;
                    case "2":
                        DisplayDictionary(courseDictionary);
                        break;
                    case "3":
                        RemoveKey(courseDictionary);
                        break;
                    case "4":
                        AddKeyValue(courseDictionary);
                        break;
                    case "5":
                        AddValueToKey(courseDictionary);
                        break;
                    case "6":
                        SortKeys(courseDictionary);
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
//Adds a new key and first value - Katie
        static void PopulateDictionary(Dictionary<string, List<string>> dict)
        {
            dict["Math"] = new List<string> { "Algebra", "Geometry" };
            dict["Science"] = new List<string> { "Biology", "Chemistry" };
            dict["Technology"] = new List<string> { "C#", "Python" };
            Console.WriteLine("Dictionary populated.");
        }

        static void DisplayDictionary(Dictionary<string, List<string>> dict)
        {
            foreach (var key in dict.Keys)
            {
                Console.WriteLine($"{key}: {string.Join(", ", dict[key])}");
            }
        }

        static void RemoveKey(Dictionary<string, List<string>> dict)//Removes key from from dictionary. -Katie
        {
            Console.Write("Enter key to remove: ");
            string key = Console.ReadLine();
            if (dict.Remove(key))
                Console.WriteLine($"{key} removed.");
            else
                Console.WriteLine("Key not found.");
        }

        static void AddKeyValue(Dictionary<string, List<string>> dict)
        {
            Console.Write("Enter new key: ");
            string key = Console.ReadLine();
            Console.Write("Enter value: ");
            string value = Console.ReadLine();
            dict[key] = new List<string> { value };
            Console.WriteLine($"Added {key} with value {value}.");
        }

        static void AddValueToKey(Dictionary<string, List<string>> dict)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            if (dict.ContainsKey(key))
            {
                Console.Write("Enter value to add: ");
                string value = Console.ReadLine();
                dict[key].Add(value);
                Console.WriteLine($"Added {value} to {key}.");
            }
            else
                Console.WriteLine("Key not found.");
        }
//This is the method that displays dictionary keys in order. - Katie
        static void SortKeys(Dictionary<string, List<string>> dict)
        {
            foreach (var key in new SortedDictionary<string, List<string>>(dict))
            {
                Console.WriteLine($"{key.Key}: {string.Join(", ", key.Value)}");
            }
        }
    }
}
