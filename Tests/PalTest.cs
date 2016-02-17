using Xunit;
using System;
// using System.Linq;
using System.Collections.Generic;
namespace  Palindromes
{
  public class PalindromTest
  {
    [Fact]
    public void TestRockPaperScissorReturnWinner()
    {
      Palindrome newPalindrome = new Palindrome("racecar");
      Assert.Equal(true, newPalindrome.CheckPalindrome());
    }

  }
}
