using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes

{
  public class Palindrome
  {
    private string _word;

    public Palindrome (string word)
    {
      _word = word;
    }
    public bool CheckPalindrome()
    {
      string splitString1;
      string splitString2;
      _word = _word.Replace(" ", "");

      if (_word.Length % 2 == 0)
      {
        splitString1 = _word.Substring(0, (_word.Length / 2));
        splitString2 = _word.Substring((_word.Length / 2),_word.Length / 2);
      }
      else
      {
        splitString1 = _word.Substring(0, (_word.Length / 2));
        splitString2 = _word.Substring((_word.Length / 2) + 1, (_word.Length / 2));
      }
      char[] charArray = splitString2.ToCharArray();
      Array.Reverse(charArray);
      splitString2 = new string(charArray);
      if(splitString1==splitString2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
