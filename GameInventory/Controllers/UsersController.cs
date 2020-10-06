using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GameInventory.Models;

namespace GameInventory.Controllers
{
  public class UsersController : Controller
  {
    // [HttpGet("/users")]
    // public ActionResult Index()
    // {
    //   List<User> allUsers = User.GetAll();
    //   return View(allUsers);
    // }

    [HttpGet("/users/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/users")]
    public ActionResult Create(string userName)
    {
      User newUser = new User(userName);
      return RedirectToAction("Index");
    }

    // [HttpGet("/artists/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Artist selectedArtist = Artist.Find(id);
    //   List<Record> artistRecords = selectedArtist.Records;
    //   model.Add("artist", selectedArtist);
    //   model.Add("records", artistRecords);
    //   return View(model);
    // }
    // [HttpPost("/artists/{artistId}/records")]
    // public ActionResult Create(int artistId, string recordTitle)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Artist foundArtist = Artist.Find(artistId);
    //   Record newRecord = new Record(recordTitle);
    //   foundArtist.AddRecord(newRecord);
    //   List<Record> artistRecords = foundArtist.Records;
    //   model.Add("records", artistRecords);
    //   model.Add("artist", foundArtist);
    //   return View("Show", model);
    // }
  }
}