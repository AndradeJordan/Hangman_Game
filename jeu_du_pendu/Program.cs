using System;

namespace jeu_du_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            //char let = my_tools.ask_letter();
            //my_tools.display_word(word, new List<char> { let });
            
            var words = my_tools.Load_The_Files("mots.txt");
             
            if (( words.Length == 0  ) || ( words == null )) {
                Console.WriteLine("The words list is empty !");
            }
            else
            {
                while (true)
                {
                    string word = my_tools.Take_random_word(words);
                    my_tools.Guess_word(word);

                    Console.WriteLine();
                    bool res = my_tools.Ask_Replay();

                    if ( res )
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to a new party play ! ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for your Time ! ");
                        break;
                    }
                }
                
            }
            
            
        }
    }
}
