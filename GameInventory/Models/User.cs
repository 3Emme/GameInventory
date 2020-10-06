using System.Collections.Generic;

namespace GameInventory.Models
{
  public class User
  {
    private static List<User> _instances = new List<User> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Game> Games { get; set; }

    public User(string userName)
    {
      Name = userName;
      _instances.Add(this);
      Id = _instances.Count;
      Games = new List<Game> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<User> GetAll()
    {
      return _instances;
    }

    public static User Find(int searchId)
    {
      return _instances[searchId - 1];
    }


    public void AddGame(Game game)
    {
      Games.Add(game);
    }
  }
}