using System;
using System.Collections.Generic;

namespace Lab_11_Movie_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMovie;
            string userContinue;
            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine("There are 10 movies in this list");
            

            do
            {
                Console.WriteLine("What category are you interested in?");
                userMovie = Console.ReadLine();
                Console.WriteLine(string.Empty);

                if (userMovie.Equals("scifi", StringComparison.InvariantCultureIgnoreCase))
                {
                    var scifi = new Movie();
                    scifi.GetSciFi();
                }

                else if (userMovie.Equals("horror", StringComparison.InvariantCultureIgnoreCase))
                {
                    var horror = new Movie();
                    horror.GetHorror();
                }

                else if (userMovie.Equals("drama", StringComparison.InvariantCultureIgnoreCase))
                {
                    var drama = new Movie();
                    drama.GetDrama();
                }

                else if (userMovie.Equals("animated", StringComparison.InvariantCultureIgnoreCase))
                {
                    var animated = new Movie();
                    animated.GetAnimated();
                }
                Console.WriteLine(string.Empty);
                Console.WriteLine("Would you like to continue (y/n)? ");
                userContinue = Console.ReadLine();

            } while (userContinue == "y");
            Console.WriteLine("Goodbye!");

            
            
            




        }
    }
}
