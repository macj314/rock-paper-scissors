namespace RPC.Models
{
  public class Game
  {
    public List<Player> playerList = new List<Player>{};
    public Game(Player player1, Player player2)
    {
      playerList.Add(player1);
      playerList.Add(player2);
    }
  }
}