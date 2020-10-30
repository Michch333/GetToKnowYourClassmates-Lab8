using System;
using System.Collections.Generic;

namespace CampbellLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> classMates = new List<string>()
            {
                "Mike",
                "Jason",
                "Theresa",
                "Clay",
                "John",
                "Ted",
                "Frank",
                "Cindy",
                "Kathy",
                "Glenn",
                "Paul",
                "Koko",
                "Andy",
                "Adam",
                "Tyler",
                "Matt",
                "Chris",
                "Jacob",
                "Rueben",
                "Marc",
                "Po"
            };
            List<string> favoriteFoods = new List<string>()
            {
                "Tacos",
                "Salad",
                "Pizza",
                "Spaghetti and meatballs",
                "Porkchops and Fried noodles",
                "Ramen",
                "Steak and potaoes",
                "Caviar, of course",
                "a Banana split",
                "orange chicken and fried rice",
                "Taco bell",
                "Hushpuppies",
                "Ravioli",
                "Chips and Salsa",
                "Diet coke, and a large number 5",
                "Peanut Butter and Jelly Sandwhich",
                "Jello pudding",
                "Hamburgers and wootbear",
                "Chilidogs",
                "whatever is right in front of them."
            };
            List<string> homeTowns = new List<string>()
            {
                "Detroit",
                "Denver",
                "Baltimore",
                "Kansas",
                "Tampa Bay",
                "Ireland",
                "Sweden",
                "Iraq",
                "Livonia",
                "New Zeeland",
                "China",
                "Windsor",
                "Toronto",
                "Quebec",
                "San Fran",
                "Clevland",
                "Columbus",
                "Rochester Hills",
                "Monroe",
                "Southfield",
            };

            
            Console.WriteLine("Welcome to our C# class! Press Enter to proceed!");
            bool shouldContinue = true;
            Console.ReadLine();
            while (shouldContinue)
            {
                Console.Clear();
                Console.WriteLine("Which student would you like to learn more about? 1-20");
                if (int.TryParse(Console.ReadLine(), out int userInput) && userInput < 21)
                {
                    int userIndex = userInput - 1;
                    string classmate = FindStudentAtIndex(userIndex, classMates);
                    Console.WriteLine($"Student {userIndex + 1} is {classmate}");
                    Console.WriteLine("Would you like to know:");
                    Console.WriteLine(@"[1]: Favorite Food");
                    Console.WriteLine(@"[2]: Home Town");
                    if (uint.TryParse(Console.ReadLine(), out uint userSelectedInfo) && userSelectedInfo < 3)
                    {
                        if (userSelectedInfo == 1)
                        {
                            string classmatesFavoriteFood = FindFavoriteFood(userIndex, favoriteFoods);
                            Console.WriteLine($"{classmate}\'s favorite food is {classmatesFavoriteFood}");
                        }
                        else 
                        {
                            string classmatesHomeTown = FindHometown(userIndex, homeTowns);
                            Console.WriteLine($"{classmate} is from {classmatesHomeTown}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is an invalid selection. Try again");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid classmate number. Please try again.");
                }
                Console.WriteLine("Would you like to learn about another student? y/n");
                if (Console.ReadLine().ToLower() != "y")
                {
                    shouldContinue = false;
                }
            }
            
        }

        private static string FindHometown(int userIndex, List<string> homeTowns) => homeTowns[userIndex];

        private static string FindFavoriteFood(int _index, List<string> _favoriteFoods) => _favoriteFoods[_index];

        private static string FindStudentAtIndex(int _index, List<string> _class) => _class[_index];
    }
}
