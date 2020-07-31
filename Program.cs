using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
                {
                    new Movie("Hereditary", "horror", "good"),
                    new Movie("It Follows", "horror", "good"),
                    new Movie("Evil Dead", "horror", "good"),
                    new Movie("Ninth Gate", "thriller", "bad"),
                    new Movie("Midsommar", "thriller", "good"),
                    new Movie("Tokyo Godfathers", "animation", "good"),
                    new Movie("Pokemon 2", "animation", "bad"),
                    new Movie("The Producers", "comedy", "ok"),
                    new Movie("Blazing Saddles", "comedy", "good"),

                };

            bool programStart = true;
            while (programStart)
            {
                
                Console.WriteLine("Genre? Horror, thriller, animation, or comedy");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "horror" || answer == "thriller" || answer == "animation" || answer == "comedy")
                {
                    for (int i = 0; i < movieList.Count; i++)
                    {
                        if (movieList[i].Genre == answer)
                        {
                            movieList[i].PrintStuff();
                        }
                            
                     }
                    
                }
                else
                {
                    Console.WriteLine("Ugh man, not a genre in this list.");
                    programStart = true;
                }//genre ask if/else


                Console.WriteLine("Want to see a different genre? Yes/No");
                string cont = Console.ReadLine();
                cont = cont.ToLower();

                if (cont == "yes" || cont == "y")
                {
                    Console.WriteLine("Cool!");
                    programStart = true;
                }
                else if (cont == "no" || cont == "n")
                {
                    Console.WriteLine("Ok, tootles!");
                    programStart = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Yes or no!");
                }
            }
        }

    }
}
