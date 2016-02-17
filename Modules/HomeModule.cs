using Nancy;
using System.Collections.Generic;
using System;
using System.Web;
using System.Linq;

namespace Palindromes
{


  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View ["index.cshtml"];
      Post["/"] = _ => {
        Palindrome newPal = new Palindrome(Request.Form["text"]);
        return View["index.cshtml", newPal.CheckPalindrome()];
      };
    }
  }
}
