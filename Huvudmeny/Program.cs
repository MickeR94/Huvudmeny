using System.Xml.Schema;

namespace Huvudmeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("--- Main Menu ---");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Youth or retiree ");
            Console.WriteLine("2. Calculate price for a group ");
            Console.WriteLine("3. Type in a random word for a surprise (or just see it 10x) ");
            Console.WriteLine("4. Type a  random sentence, three words minimum ");
            Console.WriteLine("Choose an option (numeric values only): ");
            string result = Console.ReadLine();
            int numericResult = int.Parse(result);


            switch (numericResult)
            {
                case 0:
                    Console.Clear();
                    return false; //false closes the program

                case 1:
                    perPersonPrice(numericResult);
                    return true; // Since false closes the program, I can't use that. But break; doesn't work because I have to return a value. And true
                                    // is perpetually showing the main menu


                case 2:
                    Console.WriteLine("How many are in the group? ");
                    string people = Console.ReadLine();
                    int numPeople = int.Parse(people);
                    groupPrice(numPeople);
                    return true;


                case 3:
                    // Would be useful with some error handling, or at least if-statements to check if a word is entered and not numbers or sentences
                    Console.WriteLine("Enter your chosen word: ");
                    string word = Console.ReadLine();
                    for(int i = 0; i < 10; i++)
                    {
                        Console.Write($" {i+1}. {word}, ");
                    }
                    return true;


                case 4:
                    // Would be useful with some error handling, or at least if-statements to check if a +3 word sentence is written
                    Console.WriteLine("Enter your sentence: ");
                    var sentence = Console.ReadLine();

                    string[] wordArray = sentence.Split(" ");

                    string thirdWord = wordArray[2]; // The third word of the string is on index 2

                    Console.WriteLine(thirdWord);

                    return true;


                default:
                    Console.WriteLine("Enter a numeric value between 0 - 4 only...");
                    return true;
                    
            }

        }

        private static void perPersonPrice(int age)
        {
          
            if(age < 20)
            {
                Console.WriteLine("Youth price: 80kr");
            } else if(age > 64)
            {
                Console.WriteLine("Retiree price: 90kr");
            } else
            {
                Console.WriteLine("Standard price: 120kr");
            }
        }

        private static void groupPrice(int numPeople)
        {
            int total = 0;
            for(int i = 0; i < numPeople; i++)
            {
                Console.WriteLine($"Age of person num. {i+1} : ");
                string personAge = Console.ReadLine();
                int personAgeNum = int.Parse(personAge);
                if(personAgeNum < 20)
                {
                    total += 80;
                } 
                else if(personAgeNum > 64)
                {
                    total += 90;
                }
                else
                {
                    total += 120;
                }
            }

            Console.WriteLine($"Number of people in your group: {numPeople}\t Total price: {total} kr");
        }

    }
}
