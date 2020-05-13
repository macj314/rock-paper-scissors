namespace RPC.Models
{
  public class Player
  {
    public string Move {get;set;}
    public bool Type {get;set;}
    public Player(string move, bool type)
    {
      Move = move;
      Type = type;
    }
  }
}