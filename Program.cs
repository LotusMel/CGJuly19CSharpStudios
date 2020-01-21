using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> latinText = new Dictionary<char, int>();
            string latin = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue.\n" +
                " Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus,\n" +
                " non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa.\n " +
                "Donec nec velit non ligula efficitur luctus.";

            //char[] alpha = latin.ToCharArray();
            
            //char myKey = alpha[count];

            foreach (char letter in latin)
            {
                for (int count = 0; count < latin.Length; count++)
                
                latinText.Add(letter, count);
                

            }
                foreach (KeyValuePair<char, int> alphabet in latinText)
                {
                    
                    Console.WriteLine(alphabet.ToString(), alphabet.Value);
                }
                Console.ReadLine();

            
            //string sample = "Foe Doe";

            //    var letterCounter = sample.Where(char.IsLetterOrDigit)
            //                      .GroupBy(char.ToLower)
            //                      .Select(counter => new { Letter = counter.Key, Counter = counter.Count() });

            //foreach (var counter in letterCounter)
            //{
            //    Console.WriteLine(String.Format("{0} = {1}", counter.Letter, counter.Counter));
            //}
            //Console.ReadLine();
        }

    }









}
