namespace MadLibs.Models
{
  public class MadLibsVariable
  {
    private string _verb;
    private string _adverb;
    private string _noun;
    private string _adjective;
    private string _name;
    private string _number;
    private string _vehicle;
    private string _animal;
    private string _place;

    public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
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
    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetNumber()
    {
      return _number;
    }

    public void SetNumber(string newNumber)
    {
      _number = newNumber;
    }

    public string GetVehicle()
    {
      return _vehicle;
    }

    public void SetVehicle(string newVehicle)
    {
      _vehicle = newVehicle;
    }

    public string GetAnimal()
    {
      return _animal;
    }

    public void SetAnimal(string newAnimal)
    {
      _animal = newAnimal;
    }

    public string GetPlace()
    {
      return _place;
    }

    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

  }
}
