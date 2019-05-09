using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "";
            int activityChoice = 0;
            string youShouldGo = "";
            int numberOfPeople = 0;
            string travelResult = "";

            Console.WriteLine("Hello what is your name?");

            name = Console.ReadLine();

            Console.WriteLine(
                "Hello {0} What are you in the mood for? Here are you options 1. Action 2. Chill Times 3. Danger 4. Good Food ",
                name);
            activityChoice = int.Parse(Console.ReadLine());
            if (activityChoice == 1)
            {
                youShouldGo = "Stock Car Racing";
            }
            else if (activityChoice == 2)
            {
                youShouldGo = "Hiking";
            }
            else if (activityChoice == 3)
            {
                youShouldGo = "SkyDiving";
            }
            else if (activityChoice == 4)
            {
                youShouldGo = "Taco Bell";
            }
            else
            {
                Console.WriteLine("Incorrect response");
                return;
            }

            Console.WriteLine("How many people are you bringing?");
            numberOfPeople = int.Parse(Console.ReadLine());
            if (numberOfPeople == 0)
            {
                travelResult = "sneakers";
            }
            else if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                travelResult = "sedan";
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 10)
            {
                travelResult = "Volkswagen bus";
            }
            else if (numberOfPeople <= 11)
            {
                travelResult= "airplane";
            }
            else
            {
                Console.WriteLine("You have entered the wrong input, Please try again");
            }
            Console.WriteLine("Okay if you’re in the mood for {0}, then you should travel in a {1}!",youShouldGo, travelResult);
            Console.WriteLine("Goodbye,{0}",name);
        }
    }
}
           

