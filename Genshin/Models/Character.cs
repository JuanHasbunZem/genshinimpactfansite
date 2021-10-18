using System.Collections.Generic;

namespace Genshin.Models
{
  public class Character
  {
    private static List<Character> _Characters = new List<Character> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }

    public Character(string CharacterName, string CharacterDescription)
    {
      Name = CharacterName;
      Description = CharacterDescription;
      _Characters.Add(this);
      Id = _Characters.Count;
    }

    public static void ClearAll()
    {
      _Characters.Clear();
    }

    public static List<Character> GetAll()
    {
      return _Characters;
    }

    public static Character Find(int searchId)
    {
      return _Characters[searchId-1];
    }

  }
}