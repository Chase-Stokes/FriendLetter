using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() {return "Hello friend!";}

    [Route("/goodbye")]
    public string GoodBye() { return "Goodbye friend.";}

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Place = "Portland";
      myLetterVariable.Item1 = "bubblegum";
      myLetterVariable.Item2 = "bouncy ball";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string place, string item1, string item2
    )
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Place = place;
      myLetterVariable.Item1 = item1;
      myLetterVariable.Item2 = item2;
      return View(myLetterVariable);
    }
  }
}