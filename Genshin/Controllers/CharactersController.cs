using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Genshin.Models;

namespace Genshin.Controllers
{
  public class CharactersController : Controller
  {

    [HttpGet("/Characters")]
    public ActionResult Index()
    {
      List<Character> allCharacters = Character.GetAll();
      return View(allCharacters);
    }

    [HttpGet("/Characters/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Characters")]
    public ActionResult Create(string CharacterName, string CharacterRarity, string CharacterKingdom, string CharacterWeaponType, string CharacterVisionType, string CharacterDescription, int CharacterBaseHPlvl1, int CharacterBaseATKlvl1, int CharacterBaseDEFlvl1, string CharacterSpecialStatlvl1, int CharacterBaseHPlvl90, int CharacterBaseATKlvl90, int CharacterBaseDEFlvl90, string CharacterSpecialStatlvl90, string CharacterTalent1, string CharacterTalent1Desc, string CharacterTalent2, string CharacterTalent2Desc, string CharacterTalent3, string CharacterTalent3Desc, string CharacterTalent4,
    string CharacterTalent4Desc, string CharacterTalent5, string CharacterTalent5Desc, string CharacterTalent6, string CharacterTalent6Desc)
    {
      Character newCharacter = new Character(CharacterName, CharacterRarity, CharacterKingdom, CharacterWeaponType, CharacterVisionType, CharacterDescription, CharacterBaseHPlvl1, CharacterBaseATKlvl1, CharacterBaseDEFlvl1, CharacterSpecialStatlvl1, CharacterBaseHPlvl90, CharacterBaseATKlvl90, CharacterBaseDEFlvl90, CharacterSpecialStatlvl90, CharacterTalent1, CharacterTalent1Desc, CharacterTalent2, CharacterTalent2Desc, CharacterTalent3, CharacterTalent3Desc, CharacterTalent4,
    CharacterTalent4Desc, CharacterTalent5, CharacterTalent5Desc, CharacterTalent6, CharacterTalent6Desc);
      return RedirectToAction("Index");
    }

    [HttpGet("/Characters/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Character selectedCharacter = Character.Find(id);
      model.Add("Character", selectedCharacter);
      return View(model);
    }
  }
}