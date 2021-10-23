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
    public ActionResult Create(string CharacterName, string CharacterDescription)
    {
      Character newCharacter = new Character(CharacterName, CharacterDescription);
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