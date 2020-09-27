using System;

namespace ExercisesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
           
            Console.Write("Enter Length of a rectangle: ");
            string userInput = Console.ReadLine();
            double length = double.Parse(userInput);

            Console.Write("Enter width of rectangle: ");
             userInput = Console.ReadLine();
            double width = double.Parse(userInput);

            Console.WriteLine("the area of a rectangle is " + width*length + "unit");

            Console.Write("How far you was driving?  Enter in mile: ");
            userInput = Console.ReadLine();
            double mile = double.Parse(userInput);

            Console.Write("Enter gas consumed (in gallons): ");
            userInput = Console.ReadLine();
            double gas = double.Parse(userInput);

            Console.WriteLine("your gas consumtion is : " + mile / gas +"mile/gallon");


            string advetureGiven = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string adveture = advetureGiven.ToLower(); // chane search word to lowercase
            Console.WriteLine("search a word in first sentence of Alice’s Adventures in Wonderland ");
            string userInputString= Console.ReadLine();
            userInput = userInputString.ToLower();  //change userinput to lower Case
            int i = adveture.IndexOf(userInput);
            if (i != -1)
            {
                Console.WriteLine(userInput + " is found in the sentence.");
                Console.WriteLine("First value Index of  " + " '"+userInput+"'" + " is " + i + " and has length of " + userInput.Length +"\n");

                
                Console.WriteLine("The total length of the string is :"+ adveture.Length);


                string remainWordOne = advetureGiven.Substring(0, i);
                string remainWordTwo = advetureGiven.Substring(i+(userInput.Length),adveture.Length-(i+userInput.Length));
                string remainWords = remainWordOne + remainWordTwo;
                Console.WriteLine("lenthg of string before  "+ userInput + ": "+ remainWordOne.Length);
                Console.WriteLine("length of string after "+ userInput + ": " + remainWordTwo.Length);
                Console.WriteLine("length of string excluding " + userInput + ": " + remainWords.Length + "\n");

                Console.WriteLine(remainWords);
            }
            else { Console.WriteLine("word is not found in first sentence of Alice’s Adventures in Wonderland"); }

        }
    }
}
 