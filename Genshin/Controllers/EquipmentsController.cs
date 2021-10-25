// Possible Stretch Goal
// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using Genshin.Models;

// namespace Genshin.Controllers
// {
//   public class EquipmentsController : Controller
//   {

//     [HttpGet("/Equipments")]
//     public ActionResult Index()
//     {
//       List<Equipment> allEquipments = Equipment.GetAll();
//       return View(allEquipments);
//     }

//     [HttpGet("/Equipments/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/Equipments")]
//     public ActionResult Create(string EquipmentName, string EquipmentDescription, int EquipmentLevel, int EquipmentDamage)
//     {
//       Equipment newEquipment = new Equipment(EquipmentName, EquipmentDescription, EquipmentLevel, EquipmentDamage);
//       return RedirectToAction("Index");
//     }

//     [HttpGet("/Equipments/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Equipment selectedEquipment = Equipment.Find(id);
//       model.Add("Equipment", selectedEquipment);
//       return View(model);
//     }
//   }
// }