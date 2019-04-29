namespace MadLibs.Models
{
  public class MadLibsVariable
  {
    private string _exclamation;
    private string _adverb;
    private string _noun;
    private string _adjective;

    public string GetExclamation()
    {
      return _exclamation;
    }

    public void SetExclamation(string newExclamation)
    {
      _exclamation = newExclamation;
    }

    public string GetAdverb()
    {
      return _adverb;
    }

    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

  }
}
