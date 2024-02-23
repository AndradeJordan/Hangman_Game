using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_du_pendu
{
    public static class my_tools
    {
        public static void display_word(string word, List<char> Letters)
        {
            int word_size = word.Length;
           

            for(int i=0; i<word_size; i++)
            {
                char letter = word[i];
                if (Letters.Contains(letter))
                {
                    Console.Write(letter+" ");
                }
                else
                {
                    Console.Write("_ ");
                }
                
            }
            Console.WriteLine();
        }

        public static char ask_letter()
        {
            while (true)
            {
                Console.WriteLine("Enter a letter : ");
                string letter = Console.ReadLine();
                if (letter.Length == 1)
                {
                    letter = letter.ToUpper();
                    return letter[0];
                }
                Console.WriteLine("ERROR ; you need to enter one letter please !");
            }
        }

        public static bool check_win_lost(string word, List<char> letters)
        {
            foreach( var letter in letters)
            {
                word = word.Replace(letter.ToString(), "");
            }
            if (word == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool doublons_check(char letter, List<char> letters)
        {
            if (letters.Contains(letter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Guess_word(string mot)
        {
            int NB_LIFES = 6;
            int NB_LIFES_REMAINING = NB_LIFES;
            List<char> list_letters = new List<char>();
            List<char> list_letters_lost = new List<char>();
            while (NB_LIFES_REMAINING > 0)
            {
                Console.WriteLine("Remaining numbers lifes : " + NB_LIFES_REMAINING);
                Console.WriteLine();

                Console.WriteLine(Ascii.PENDU[NB_LIFES - NB_LIFES_REMAINING]);
                display_word(mot,list_letters);
                Console.WriteLine();

                var letter = ask_letter();
                while (true)
                {
                    
                    bool condi = doublons_check(letter, list_letters_lost);
                    if (condi)
                    {
                        Console.WriteLine("You already enter this letter !");
                        letter = ask_letter();
                    }
                    else
                    {
                        break;
                    }
                }
                

                Console.Clear();

                

                if (mot.Contains(letter))
                {
                    Console.WriteLine("the letter "+letter+" is in the word !");
                    list_letters.Add(letter);
                    if(check_win_lost(mot, list_letters))
                    {
                        break;
                    }
                }
                else
                {

                    list_letters_lost.Add(letter);
                    NB_LIFES_REMAINING--;
                }
                if (list_letters_lost.Count > 0 )
                {
                    Console.WriteLine();
                    Console.WriteLine("The word doesn't contains the letters :" + String.Join(", ", list_letters_lost));
                    Console.WriteLine();
                }
                

            }
            Console.WriteLine(Ascii.PENDU[NB_LIFES - NB_LIFES_REMAINING]);

            if (NB_LIFES_REMAINING > 0)
            {
                display_word(mot, list_letters);
                Console.WriteLine();

                Console.WriteLine("WIN");
            }
            else
            {
                Console.WriteLine("LOST");
                Console.WriteLine("The Word was "+mot);
            }
        }
        static public string[] Load_The_Files( string file_name)
        {
            try
            {
                return File.ReadAllLines(file_name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on file's load : " + file_name +" ( " + ex.Message + ")");
            }

            return null;
        }

        static public string Take_random_word(string[] words_list)
        {
            Random random = new Random();
            int index = random.Next(0, words_list.Length);
            return words_list[index].Trim().ToUpper();
        }

        static public bool Ask_Replay()
        {
            Console.WriteLine("Do you want replay ? (o/n)");
            char res = ask_letter();
            if ( ( res == 'o' ) || ( res == 'O'))
            {
                return true;
            }
            else if ((res == 'n') || (res == 'N'))
            {
                return false;
            }
            else
            {
                Console.WriteLine(" You need to enter o or n");
                return Ask_Replay();
            }
        }
    }
}
