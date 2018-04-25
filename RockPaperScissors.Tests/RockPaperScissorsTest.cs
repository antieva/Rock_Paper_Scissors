using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaperScissorsApp.Controllers;
using RockPaperScissorsApp;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class RockPaperScissorsControllerTest
    {
      [TestMethod]
     public void Index_ReturnsCorrectView_True()
     {
         //Arrange
         RockPaperScissorsController controller = new RockPaperScissorsController();

         //Act
         ActionResult indexView = controller.Index();

         //Assert
         Assert.IsInstanceOfType(indexView, typeof(ViewResult));
     }

     [TestMethod]
        public void Index_HasCorrectModelType_String()
        {
            //Arrange
            ViewResult indexView = new RockPaperScissorsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(null));
        }
    }
}
