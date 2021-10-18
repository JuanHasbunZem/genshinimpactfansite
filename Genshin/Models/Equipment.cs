using System.Collections.Generic;

namespace Genshin.Models
{
  public class Equipment
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public int Damage { get; set; }
    public int Id { get; }
    private static List<Equipment> _Equipments = new List<Equipment> { };

    public Equipment(string name, string description, int level, int damage)
    {
      Name = name;
      Description = description;
      Level = level;
      Damage = damage;
      _Equipments.Add(this);
      Id = _Equipments.Count;
    }

    public static List<Equipment> GetAll()
    {
      return _Equipments;
    }

    public static void ClearAll()
    {
      _Equipments.Clear();
    }

    public static Equipment Find(int searchId)
    {
      return _Equipments[searchId-1];
    }
  }
}
