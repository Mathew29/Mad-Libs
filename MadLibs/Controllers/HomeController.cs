using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/sheet")]
    public ActionResult Sheet(string exclamation, string adverb, string noun, string adjective)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.SetExclamation(exclamation);
      myMadLibsVariable.SetAdverb(adverb);
      myMadLibsVariable.SetNoun(noun);
      myMadLibsVariable.SetAdjective(adjective);
      return View(myMadLibsVariable);
    }
  }
}
