using System.Collections.Generic;
using System;

namespace RockPaperScissorsApp
{
  public class RockPaperScissors
  {
      public static string Game(int num1, int num2)
      {
          string winner = "";
          if (num1 == 3 && num2 == 1) {
              return winner = "Payer 2";
          }
          if (num1 == 1 && num2 == 3) {
              return winner = "Player 1";
          }
          if (num1 > num2) {
              return winner = "Player 1";
          }
          if (num1 < num2) {
              return winner = "Player 2";
          }
          if (num1 == num2) {
              return winner = "Draw";
          }
          return winner;
      }
  }
}
