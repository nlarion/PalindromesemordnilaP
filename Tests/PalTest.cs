using Xunit;
using System;
// using System.Linq;
using System.Collections.Generic;
namespace  Palindromes
{
  public class PalindromTest
  {
    [Fact]
    public void TestCheckPalindrome()
    {
      Palindrome newPalindrome = new Palindrome("hannah");
      Assert.Equal(true, newPalindrome.CheckPalindrome());
    }
    [Fact]
    public void TestCheckPalindromeForOddWords()
    {
      Palindrome newPalindrome = new Palindrome("racecar");
      Assert.Equal(true, newPalindrome.CheckPalindrome());
    }
  }
}
