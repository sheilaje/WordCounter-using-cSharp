using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();
      //Act
      ActionResult newView = controller.New();
      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();
      //Act
      string word = "love";
      string sentence = "I loVe OreGON and I Love cAliFORnia";
      ActionResult showView = controller.Show(word, sentence);
      //Assert
      Assert.IsInstanceOfType(showView, typeof(ViewResult));
    }
  }
}
