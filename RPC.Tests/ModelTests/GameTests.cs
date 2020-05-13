using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPC.Models;

namespace RPC.Tests
{
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }
    
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

    [TestMethod]

    public void PlayGame_ReturnsATie_String()
    {
      Player playerOne = new Player("rock", true);
      Player playerTwo = new Player("rock", false);
      Game theGame = new Game(playerOne, playerTwo);
      
      string tempWinner = Game.PlayGame();

      Assert.AreEqual(tempWinner, "tie");
    }

    [TestMethod]
    public void PlayGame_ReturnsPaperBeatsRock_String()
    {
      Player playerOne = new Player("scissors", true);
      Player playerTwo = new Player("paper", false);
      Game theGame = new Game(playerOne, playerTwo);

      string tempWinner = Game.PlayGame();

      Assert.AreEqual(tempWinner, "scissors beats paper");
    }
  }
}