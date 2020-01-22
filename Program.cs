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

            //foreach (char letter in latin)
            //{
            //    for (int count = 0; count < latin.Length; count++)

            //        latinText.Add(letter, count);

            //char[] charsToTrim = { ' ', ',', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //Console.WriteLine(latin.Trim(charsToTrim));
            
            foreach (char letter in latin.ToLower().ToArray())
                if (!latinText.ContainsKey(letter))
                    latinText.Add(letter, 1);
                else
                    latinText[letter] = latinText[letter] + 1;
            foreach (char latinItem in latinText.Keys)
            {
                Console.WriteLine($"{latinItem} repeats {latinText[latinItem]} time(s).");
            }

            Console.ReadLine();
        }

    }









}
