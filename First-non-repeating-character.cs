/*
Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.
For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.
If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.
*/


//Solution with LinQ
using System;
using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
  }
}


//Solution without great God-Power LinQ
using System;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    Console.WriteLine(s);
    if (s == "") return "";
    char[] mirror = s.ToCharArray();
            s = s.ToLower();
            char[] a = s.ToCharArray();
            int answer = 0;

            for (int n = 0; n < a.Length; n++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i < a.Length && i != n && a[i] == a[n])
                    {
                        break;
                    }
                    else if (i == a.Length - 1)
                    {
                        answer = n;
                        return char.ToString(mirror[answer]);
                    }
                }
            }
            return "";
  }
}
