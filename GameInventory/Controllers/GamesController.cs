using Microsoft.AspNetCore.Mvc;
using GameInventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameInventory.Controllers
{
  public class GamesController : Controller
  {
    private readonly GameInventoryContext _db;

    public GamesController(GameInventoryContext db)
    {
      _db = db;
    }
    [HttpGet("/userProfiles/{userProfileId}/games/add")]
    public ActionResult Add(int userProfileId)
    {
      UserProfile userProfile = UserProfile.Find(userProfileId);
      return View(userProfile);
    }
    public ActionResult Index()
    {
      List<Game> model = _db.Games.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Game game)
    {
      _db.Games.Add(game);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Game thisGame = _db.Games.FirstOrDefault(games => games.GameId == id);
      return View(thisGame);
    }
  }
}