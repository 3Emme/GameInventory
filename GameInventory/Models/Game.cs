using System.Collections.Generic;
using System;
namespace GameInventory.Models
{
  public class Game
  {
    public int GameId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ReleaseDate { get; set; }
    public string Genre { get; set; }
    public string Tags { get; set; }
  }
}