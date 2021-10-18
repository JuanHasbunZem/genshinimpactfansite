using System.Collections.Generic;

namespace Genshin.Models
{
  public class Enemy
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int HitPoint { get; set; }
    public int Id { get; }
    private static List<Enemy> _Enemys = new List<Enemy> { };

    public Enemy(string name, string description, int hitpoint)
    {
      Name = name;
      Description = description;
      HitPoint = hitpoint;
      _Enemys.Add(this);
      Id = _Enemys.Count;
    }

    public static List<Enemy> GetAll()
    {
      return _Enemys;
    }

    public static void ClearAll()
    {
      _Enemys.Clear();
    }

    public static Enemy Find(int searchId)
    {
      return _Enemys[searchId-1];
    }
  }
}
