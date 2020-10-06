using System.Collections.Generic;

namespace GameInventory.Models
{
  public class UserProfile
  {
    private static List<UserProfile> _instances = new List<UserProfile> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Game> Games { get; set; }

    public UserProfile(string userProfileName)
    {
      Name = userProfileName;
      _instances.Add(this);
      Id = _instances.Count;
      Games = new List<Game> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<UserProfile> GetAll()
    {
      return _instances;
    }

    public static UserProfile Find(int searchId)
    {
      return _instances[searchId - 1];
    }


    public void AddGame(Game game)
    {
      Games.Add(game);
    }
  }
}