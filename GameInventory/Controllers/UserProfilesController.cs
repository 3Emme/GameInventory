using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GameInventory.Models;

namespace GameInventory.Controllers
{
  public class UserProfilesController : Controller
  {
    [HttpGet("/userProfiles")]
    public ActionResult Index()
    {
      List<UserProfile> allUserProfiles = UserProfile.GetAll();
      return View(allUserProfiles);
    }

    [HttpGet("/userProfiles/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/userProfiles")]
    public ActionResult Create(string userProfileName)
    {
      UserProfile newUserProfile = new UserProfile(userProfileName);
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