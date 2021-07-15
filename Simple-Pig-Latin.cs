/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
Examples
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static string PigIt(string input)
  {
     Regex regex = new Regex(@"(?:([A-Za-z])([A-Za-z]+))?([^\s])?");
      return string.Join(" ", input.Split(" ").Select( x => regex.Match(x) ).Select(x => x.Groups[2].Value + x.Groups[1].Value + x.Groups[3].Value + (x.Groups[1].Success ? "ay" : "")));
  }
}
