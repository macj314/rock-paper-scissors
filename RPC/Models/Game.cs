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

    public static string PlayGame()
    {
      string result = "";
      string p1Move = _playerList[0].Move, p2Move = _playerList[1].Move;
      if (p1Move == p2Move)
      {
        result = "tie";
      }
      switch(p1Move)
      {
        case "paper":
          switch(p2Move)
          {
            case "rock":
              result = $"{p1Move} beats {p2Move}";
              break;
            case "scissors":
              result = $"{p2Move} beats {p1Move}";
              break;
            default:
              break;
          }
          break;
        case "scissors":
          switch(p2Move)
          {
            case "rock":
              result = $"{p2Move} beats {p1Move}";
              break;
            case "paper":
              result = $"{p1Move} beats {p2Move}";
              break;
            default:
              break;
          }
            break;
        case "rock":
          switch(p2Move)
          {
            case "paper":
              result = $"{p2Move} beats {p1Move}";
              break;
            case "scissors":
              result = $"{p1Move} beats {p2Move}";
              break;
            default:
              break;
          }
          break;
        default:
          break;
      }
      return result;
    }

    
    public static void ClearAll()
    {
      _playerList.Clear();
    }
  }
}