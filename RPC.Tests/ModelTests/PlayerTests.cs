using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPC.Models;

namespace RPC.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void Player_CreatesPlayerInstance_Player()
    {
      Player testPlayer = new Player("rock", true);
      Assert.AreEqual(typeof(Player), testPlayer.GetType());

    }
  
  
  }

}