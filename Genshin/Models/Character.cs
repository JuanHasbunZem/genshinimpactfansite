using System.Collections.Generic;

namespace Genshin.Models
{
  public class Character
  {
    private static List<Character> _Characters = new List<Character> {};
    public string Name { get; set; }
    public string Rarity { get; set; }
    public string Kingdom { get; set; }
    public string WeaponType { get; set; }
    public string VisionType { get; set; }
    public string Description { get; set; }
    public int BaseHPlvl1 { get; set; }
    public int BaseATKlvl1 { get; set; }
    public int BaseDEFlvl1 { get; set; }
    public string SpecialStatlvl1 { get; set; }
    public int BaseHPlvl90 { get; set; }
    public int BaseATKlvl90 { get; set; }
    public int BaseDEFlvl90 { get; set; }
    public string SpecialStatlvl90 { get; set; }
    public string Talent1 { get; set; }
    public string Talent1Desc { get; set; }
    public string Talent2 { get; set; }
    public string Talent2Desc { get; set; }
    public string Talent3 { get; set; }
    public string Talent3Desc { get; set; }
    public string Talent4 { get; set; }
    public string Talent4Desc { get; set; }
    public string Talent5 { get; set; }
    public string Talent5Desc { get; set; }
    public string Talent6 { get; set; }
    public string Talent6Desc { get; set; }


    public int Id { get; }

    public Character(string CharacterName, string CharacterRarity, string CharacterKingdom, string CharacterWeaponType, string CharacterVisionType, string CharacterDescription, int CharacterBaseHPlvl1, int CharacterBaseATKlvl1, int CharacterBaseDEFlvl1, string CharacterSpecialStatlvl1, int CharacterBaseHPlvl90, int CharacterBaseATKlvl90, int CharacterBaseDEFlvl90, string CharacterSpecialStatlvl90, string CharacterTalent1, string CharacterTalent1Desc, string CharacterTalent2, string CharacterTalent2Desc, string CharacterTalent3, string CharacterTalent3Desc, string CharacterTalent4,
    string CharacterTalent4Desc, string CharacterTalent5, string CharacterTalent5Desc, string CharacterTalent6, string CharacterTalent6Desc)
    {
      Name = CharacterName;
      Rarity = CharacterRarity;
      Kingdom = CharacterKingdom;
      WeaponType = CharacterWeaponType;
      VisionType = CharacterVisionType;
      Description = CharacterDescription;
      BaseHPlvl1 = CharacterBaseHPlvl1;
      BaseATKlvl1 = CharacterBaseATKlvl1;
      BaseDEFlvl1 = CharacterBaseDEFlvl1;
      SpecialStatlvl1 = CharacterSpecialStatlvl1;
      BaseHPlvl90 = CharacterBaseHPlvl90;
      BaseATKlvl90 = CharacterBaseATKlvl90;
      BaseDEFlvl90 = CharacterBaseDEFlvl90;
      SpecialStatlvl90 = CharacterSpecialStatlvl90;
      Talent1 = CharacterTalent1;
      Talent1Desc = CharacterTalent1Desc;
      Talent2 = CharacterTalent2;
      Talent2Desc = CharacterTalent2Desc;
      Talent3 = CharacterTalent3;
      Talent3Desc = CharacterTalent3Desc;
      Talent4 = CharacterTalent4;
      Talent4Desc = CharacterTalent4Desc;
      Talent5 = CharacterTalent5;
      Talent5Desc = CharacterTalent5Desc;
      Talent6 = CharacterTalent6;
      Talent6Desc = CharacterTalent6Desc;
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