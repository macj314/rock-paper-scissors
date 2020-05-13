using System.Collections.Generic;
namespace RPC.Models
{
  public class Game
  {
    private static List<Player> _playerList = new List<Player>{};
    public Game(Player player1, Player player2)
    {
      _playerList.Add(player1);
      _playerList.Add(player2);
    }

    public static List<Player> GetAll()
    {
      return _playerList;
    }
  }
}