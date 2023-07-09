using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1)	Word Frequency Analysis
//2)	Sentence Maker
//3)	Longest and Shortest Word Finder
//4)	Word Search
//5)	Palindrome Detector
//6)	Vowel / Consonant Counter

namespace weekend1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                Please Enter a Sentence              ");
            Console.WriteLine("*****************************************************");
            string sentence = Console.ReadLine();
            int num_words = count_words(sentence);
            string[] arr_words = split_to_words(sentence, num_words);
            freq_determine(arr_words);
            Console.WriteLine("*****************************************************");
            Console.WriteLine("    How many random sentences you want to generate   ");
            Console.WriteLine("*****************************************************");
            int num_rand_sentences = Convert.ToInt32(Console.ReadLine());
            sentence_maker(arr_words, num_rand_sentences);
            Console.WriteLine("Do you want to find longest and shortest word in the string: y[yes] or n[no]?");
            string user_input1 = Console.ReadLine();
            Console.WriteLine("\n");
            if (user_input1 == "no" || user_input1 == "n")
            {
                Console.WriteLine("Do you want to search any word: y[yes] or n[no]?");
                string user_input2 = Console.ReadLine();
                Console.WriteLine("\n");
                if (user_input2 == "no" || user_input2 == "n")
                {
                    Console.WriteLine("Do you want to find how many palindromic words are there in the string: y[yes] or n[no]");
                    string user_input3 = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (user_input3 == "no" || user_input3 == "n")
                    {
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                    else if (user_input3 == "yes" || user_input3 == "y")
                    {
                        palindrome_detector(arr_words);
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                }
                else if (user_input2 == "yes" || user_input2 == "y")
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("        Enter a word which you want to search        ");
                    Console.WriteLine("*****************************************************");
                    string search_word = Console.ReadLine();
                    word_search(arr_words, search_word);
                    Console.WriteLine("Do you want to find how many palindromic words are there in the string: y[yes] or n[no]");
                    string user_input3 = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (user_input3 == "no" || user_input3 == "n")
                    {
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                    else if (user_input3 == "yes" || user_input3 == "y")
                    {
                        palindrome_detector(arr_words);
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                }
            }
            else if (user_input1 == "yes" || user_input1 == "y")
            {
                longest_shortest_find(arr_words);
                Console.WriteLine("Do you want to search any word: y[yes] or n[no]?");
                string user_input2 = Console.ReadLine();
                Console.WriteLine("\n");
                if (user_input2 == "no" || user_input2 == "n")
                {
                    Console.WriteLine("Do you want to find how many palindromic words are there in the string: y[yes] or n[no]");
                    string user_input3 = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (user_input3 == "no" || user_input3 == "n")
                    {
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                    else if (user_input3 == "yes" || user_input3 == "y")
                    {
                        palindrome_detector(arr_words);
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                }
                else if (user_input2 == "yes" || user_input2 == "y")
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("        Enter a word which you want to search        ");
                    Console.WriteLine("*****************************************************");
                    string search_word = Console.ReadLine();
                    word_search(arr_words, search_word);
                    Console.WriteLine("Do you want to find how many palindromic words are there in the string: y[yes] or n[no]");
                    string user_input3 = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (user_input3 == "no" || user_input3 == "n")
                    {
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                    else if (user_input3 == "yes" || user_input3 == "y")
                    {
                        palindrome_detector(arr_words);
                        Console.WriteLine("Do you want to find how many consonants and vowels are there in each word of the string: y[yes] or n[no]");
                        string user_input4 = Console.ReadLine();
                        if (user_input4 == "no" || user_input4 == "n")
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                        else if (user_input4 == "yes" || user_input4 == "y")
                        {
                            vowel_consonant_counter(arr_words);
                            Console.WriteLine("\n");
                            Console.WriteLine("Program Terminated! Thank you for using it");
                            Console.ReadLine();
                        }
                    }
                }
            }


        }

        static int count_words(string sentence)
        {
            Console.WriteLine("\n");
            int word_count = 0;
            bool inside_word = false;

            foreach (char c in sentence)
            {
                if (c == ' ' || c == '.' || c == ',' || c == '?')
                {
                    if (inside_word)
                    {
                        inside_word = false;
                    }
                }
                else
                {
                    if (!inside_word)
                    {
                        word_count++;
                        inside_word = true;
                    }
                }
            }

            return word_count;
        }

        static string[] split_to_words(string sentence, int num_words)
        {
            string[] words = new string[num_words];
            int i = 0;
            string single_word = "";

            foreach (char c in sentence)
            {
                if (c == ' ' || c == '.' || c == ',' || c == '?')
                {
                    if (!string.IsNullOrEmpty(single_word))
                    {
                        words[i] = single_word;
                        single_word = "";
                        i++;
                    }
                }
                else
                {
                    single_word = single_word + c;
                }
            }

            if (!string.IsNullOrEmpty(single_word))
            {
                words[i] = single_word;
            }

            return words;
        }
    
        static void freq_determine(string[] arr_words)
        {
            int inc_j = 1;
            int freq = 1;
            Console.WriteLine(".....................................................");
            Console.WriteLine("                   Word Frequency                    ");
            Console.WriteLine(".....................................................");
            string[] arr_words_copy = new string[arr_words.Length];
            Array.Copy(arr_words, arr_words_copy, arr_words.Length);


            if (arr_words_copy.Length == 0)
            {
                Console.WriteLine("No words to Analyze. Given String is Empty");
                Console.WriteLine("\n");
                Console.WriteLine("     (-_-) ____________ (._. )    ");
                Console.WriteLine("\n");
                Console.WriteLine("Terminating program in 5 sec");
                Thread.Sleep(10000);
                Environment.Exit(0);

            }
            else
            {
                for (int i = 0; i < (arr_words_copy.Length); i++)
                {
                    for (int j = inc_j; j < arr_words_copy.Length; j++)
                    {
                        if (string.Equals(arr_words_copy[i], arr_words_copy[j], StringComparison.OrdinalIgnoreCase))
                            {
                                freq = freq + 1;
                                arr_words_copy[j] = null;
                        }

                    }
                    if (arr_words_copy[i] != null)
                    {
                        Console.WriteLine(" \"{0}\": {1}",
                        arr_words_copy[i], freq);
                    }
                    inc_j = inc_j + 1;
                    freq = 1;
                }
            }
            Console.WriteLine("\n");

        }

        static void sentence_maker(string[] arr_words, int num_rand_sentences)
        {
            Console.WriteLine("\n");
            Random random = new Random();
            string[] total_sentences = new string[num_rand_sentences];
            int word_count = arr_words.Length;

            for (int i = 0; i < num_rand_sentences; i++)
            {
                string[] single_sentence = new string[5];

                for (int j = 0; j < 5; j++)
                {
                    int random_index = random.Next(0, word_count);
                    single_sentence[j] = arr_words[random_index];
                }

                string sentence = string.Join(" ", single_sentence);
                total_sentences[i] = sentence;
            }
            Console.WriteLine(".....................................................");
            Console.WriteLine("                 Generated Sentences                 ");
            Console.WriteLine(".....................................................");
            int foreach_count = 1;
            foreach (string item in total_sentences)
            {
                Console.Write(" {0}. ", foreach_count);
                Console.WriteLine(item);
                foreach_count++;
            }
            Console.WriteLine("\n");

        }

        static void longest_shortest_find(string[] arr_words)
        {
            Console.WriteLine(".....................................................");
            Console.WriteLine("           Longest and Shortest Word Finder          ");
            Console.WriteLine(".....................................................");
            string longest = arr_words[0];
            string shortest = arr_words[0];
            string[] longest_string  = new string[arr_words.Length];
            string[] shortest_string = new string[arr_words.Length];
            int lindex = 0;
            int sindex = 0;

            for (int i = 1; i < arr_words.Length; i++)
            {
                if (longest.Length < arr_words[i].Length)
                {
                    longest = arr_words[i];
                    lindex = 0;
                    longest_string[lindex] = longest;
                    lindex++;
                }
                else if (longest.Length == arr_words[i].Length)
                {
                    longest_string[lindex] = arr_words[i];
                    lindex++;
                }
            }
            Console.WriteLine(" Longest  Word(s):");

            string[] longest_string_copy = new string[longest_string.Length];
            Array.Copy(longest_string, longest_string_copy, longest_string.Length);
            int inc_j = 1;
            int freq = 1;
            for (int i = 0; i < (longest_string_copy.Length); i++)
            {
                for (int j = inc_j; j < longest_string_copy.Length; j++)
                {
                    if (string.Equals(longest_string_copy[i], longest_string_copy[j], StringComparison.OrdinalIgnoreCase))
                    {
                        freq = freq + 1;
                        longest_string_copy[j] = null;
                    }

                }
                int max_length = 0;
                foreach (string item in longest_string_copy)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    if (item.Length > max_length)
                    {
                        max_length = item.Length;
                    }
                }
                if ((longest_string_copy[i] != null) && (longest_string_copy[i].Length == max_length))
                {
                    Console.WriteLine(" \"{0}\"",
                    longest_string_copy[i]);
                }
                inc_j = inc_j + 1;
                freq = 1;
            }
        

            for (int i = 1; i < arr_words.Length; i++)
            {
                if (shortest.Length > arr_words[i].Length)
                {
                    shortest = arr_words[i];
                    sindex = 0;
                    shortest_string[sindex] = shortest;
                    sindex++;
                }
                else if (shortest.Length == arr_words[i].Length)
                {
                    shortest_string[sindex] = arr_words[i];
                    sindex++;
                }
            }
            Console.WriteLine("__________________");
            Console.WriteLine(" Shortest Word(s): ");

            string[] shortest_string_copy = new string[shortest_string.Length];
            Array.Copy(shortest_string, shortest_string_copy, shortest_string.Length);

            int inc_l = 1;
            int frequency = 1;
            for (int k = 0; k < (shortest_string_copy.Length); k++)
            {
                for (int l = inc_l; l < shortest_string_copy.Length; l++)
                {
                    if (string.Equals(shortest_string_copy[k], shortest_string_copy[l], StringComparison.OrdinalIgnoreCase))
                    {
                        frequency = frequency + 1;
                        shortest_string_copy[l] = null;
                    }

                }
                int min_length = int.MaxValue; 
                foreach (string item in shortest_string_copy)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    if (item.Length < min_length)
                    {
                        min_length = item.Length;
                    }
                }
                if (shortest_string_copy[k] != null && shortest_string_copy[k].Length == min_length)
                {
                    Console.WriteLine(" \"{0}\"",
                    shortest_string_copy[k]);
                }
                inc_l = inc_l + 1;
                frequency = 1;
            }

            Console.WriteLine("\n");
        }

        static void word_search(string[] arr_words, string search_word)
        {
            int freq = 0;

            for (int i = 0; i < arr_words.Length; i++)
            {
                if (string.Equals(arr_words[i], search_word, StringComparison.OrdinalIgnoreCase))
                {
                    freq = freq + 1;
                }
            }

            Console.WriteLine("\n");
            if (search_word.Length == 0)
            {
                Console.WriteLine(" Invalid Input! You entered an Empty String");
            }
            else if (freq == 0)
            {
                Console.WriteLine(" The word you enter does not exists in the string");
            }
            else
            {
                Console.WriteLine(" The word \"{0}\" appears {1} time(s) in the sentence", search_word, freq);
            }
            Console.WriteLine("\n");

        }

        static void palindrome_detector(string[] arr_words)
        {
            Console.WriteLine(".....................................................");
            Console.WriteLine("                 Palindrome Detector                 ");
            Console.WriteLine(".....................................................");
            string[] palindrome_string = new string[arr_words.Length];
            int pal_index = 0;


            for (int i = 0; i < arr_words.Length; i++)
            {
                string rev_string = "";
                for (int j = arr_words[i].Length - 1; j >= 0; j--)
                {
                    rev_string = rev_string + arr_words[i][j].ToString();
                }

                if (string.Equals(arr_words[i], rev_string, StringComparison.OrdinalIgnoreCase))

                {
                    palindrome_string[pal_index] = arr_words[i];
                    pal_index = pal_index + 1;
                }
            }

            if (pal_index == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("There are no palindromic words in the sentence.");
            }
            

            if (pal_index != 0)
            {
                Console.WriteLine("\n");
                string[] palindrome_string_copy = new string[arr_words.Length];
                Array.Copy(palindrome_string, palindrome_string_copy, arr_words.Length);
                int inc_j = 1;
                int freq = 1;
                for (int i = 0; i < (palindrome_string_copy.Length); i++)
                {
                    for (int j = inc_j; j < palindrome_string_copy.Length; j++)
                    {
                        if (string.Equals(palindrome_string_copy[i], palindrome_string_copy[j], StringComparison.OrdinalIgnoreCase))
                        {
                            freq = freq + 1;
                            palindrome_string_copy[j] = null;
                        }

                    }
                    if (palindrome_string_copy[i] != null)
                    {
                        Console.WriteLine(" \"{0}\": {1}",
                        palindrome_string_copy[i], freq);
                    }
                    inc_j = inc_j + 1;
                    freq = 1;
                }
            }
            Console.WriteLine("\n");

        }

        static void vowel_consonant_counter(string [] arr_words)
        {
            Console.WriteLine(".....................................................");
            Console.WriteLine("              Vowels and Consonant Count             ");
            Console.WriteLine(".....................................................");
            Console.WriteLine("\n");

            int inc_j = 1;
            int freq = 1;
            string[] arr_words_copy = new string[arr_words.Length];
            Array.Copy(arr_words, arr_words_copy, arr_words.Length);
            for (int i = 0; i < (arr_words_copy.Length); i++)
            {
                for (int j = inc_j; j < arr_words_copy.Length; j++)
                {
                    if (string.Equals(arr_words_copy[i], arr_words_copy[j], StringComparison.OrdinalIgnoreCase))
                    {
                        freq = freq + 1;
                        arr_words_copy[j] = null;
                    }

                }
                inc_j = inc_j + 1;
                freq = 1;
            }

            int count_vowel;
            int count_consonant;
            for (int i = 0; i < arr_words_copy.Length; i++)
            {
                if (arr_words_copy[i] == null)
                {
                    continue;
                }
                count_vowel = 0;
                count_consonant = 0;

                foreach(char item in arr_words_copy[i].ToLower())
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o'|| item == 'u' )
                    {
                        count_vowel = count_vowel + 1;
                    }
                    else if (char.IsLetter(item))
                    {
                        count_consonant = count_consonant + 1;
                    }
                }
                if (arr_words_copy[i].Length != 0)
                {
                    Console.WriteLine("\"{0}\": {1} vowels and {2} consonants",
                                      arr_words_copy[i], count_vowel, count_consonant);
                }
            }
            Console.WriteLine("\n");
           
        }
    }
}
