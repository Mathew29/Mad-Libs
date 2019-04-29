using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/disney")]
    public ActionResult Disney() { return View(); }

    [Route("/zoo")]
    public ActionResult Zoo() { return View(); }

    [Route("/")]
    public ActionResult Story() { return View(); }

    [Route("/sheet")]
    public ActionResult Sheet(string adjective1, string noun1, string verb1, string adverb1, string adjective2, string noun2, string noun3, string adjective3, string verb2, string adverb2, string verb3, string adjective4)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.SetAdjective(adjective1);
      myMadLibsVariable.SetAdverb(adverb1);
      myMadLibsVariable.SetNoun(noun1);
      myMadLibsVariable.SetVerb(verb1);
      myMadLibsVariable.SetAdjective(adjective2);
      myMadLibsVariable.SetAdjective(adjective3);
      myMadLibsVariable.SetAdjective(adjective4);
      myMadLibsVariable.SetVerb(verb2);
      myMadLibsVariable.SetVerb(verb3);
      myMadLibsVariable.SetAdverb(adverb2);
      myMadLibsVariable.SetNoun(noun2);
      myMadLibsVariable.SetNoun(noun3);
      return View(myMadLibsVariable);
    }
    [Route("/world")]
    public ActionResult World(string name, string number, string vehicle, string adjective1, string adjective2, string verb1, string animal, string adjective3, string verb2, string adjective4, string verb3, string verb4, string place, string verb5)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.SetAdjective(adjective1);
      myMadLibsVariable.SetVerb(verb1);
      myMadLibsVariable.SetName(name);
      myMadLibsVariable.SetVerb(verb2);
      myMadLibsVariable.SetAdjective(adjective2);
      myMadLibsVariable.SetAdjective(adjective3);
      myMadLibsVariable.SetAdjective(adjective4);
      myMadLibsVariable.SetVerb(verb3);
      myMadLibsVariable.SetVerb(verb4);
      myMadLibsVariable.SetVerb(verb5);
      myMadLibsVariable.SetNumber(number);
      myMadLibsVariable.SetVehicle(vehicle);
      myMadLibsVariable.SetAnimal(animal);
      myMadLibsVariable.SetPlace(place);
      return View(myMadLibsVariable);
    }
  }
}
