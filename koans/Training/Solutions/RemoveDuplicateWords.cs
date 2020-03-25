using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    /*
     Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

    Example:

    Input:

    'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

    Output:

    'alpha beta gamma delta'
     */
    public class RemoveDuplicateWords
    {
        public static string RemoveDuplicates(string str)
        {
            string[] tokens = str.Split(' ');
            string[] temp = new string[tokens.Length];
            int numOfDistinct = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                var item = tokens[i];
                var seen = false;
                
                for (int j = 0; j < temp.Length; j++)
                {
                    if (item.Equals(temp[j]))
                    {
                        seen = true;
                    }
                }

                if (!seen)
                {
                    temp[numOfDistinct++] = item;    
                }

            }

            string[] distinctWords = new string[numOfDistinct];
            for (int i = 0; i < distinctWords.Length; i++)
            {
                distinctWords[i] = temp[i];
            }


            return string.Join(" ", distinctWords);
        }
    }
}
