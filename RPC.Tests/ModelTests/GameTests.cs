using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPC.Models;

namespace RPC.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void Game_CreatesGameInstanceWithTwoPlayers_List()
    {
      Player playerOne = new Player("rock", true);
      Player playerTwo = new Player("paper", false);
      Game theGame = new Game(playerOne, playerTwo);
      
      List<Player> compareList = new List<Player>{playerOne, playerTwo};
      List<Player> theList = Game.GetAll();

      CollectionAssert.AreEqual(theList, compareList);
    }
  }
}