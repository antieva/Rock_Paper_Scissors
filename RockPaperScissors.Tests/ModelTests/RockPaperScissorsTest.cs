using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissorsApp;
using System;

namespace RockPaperScissorsApp.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {
    [TestMethod]
    public void Game_RockPaper_Player2()
    {
        string testOutput = "Payer 2";
        Assert.AreEqual(testOutput, RockPaperScissors.Game(3,1));
    }

    [TestMethod]
    public void Game_PaperRock_Player1()
    {
        string testOutput = "Player 1";
        Assert.AreEqual(testOutput, RockPaperScissors.Game(1,3));
    }

    [TestMethod]
    public void Game_RockScissors_Player1()
    {
        string testOutput = "Player 1";
        Assert.AreEqual(testOutput, RockPaperScissors.Game(3,2));
    }

    [TestMethod]
    public void Game_PaperScissors_Player2()
    {
        string testOutput = "Player 2";
        Assert.AreEqual(testOutput, RockPaperScissors.Game(1,2));
    }

    [TestMethod]
    public void Game_PaperPaper_Draw()
    {
        string testOutput = "Draw";
        Assert.AreEqual(testOutput, RockPaperScissors.Game(1,1));
    }
  }
}
