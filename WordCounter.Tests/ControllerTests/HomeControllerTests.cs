using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();
      //Act
      ViewResult indexView = controller.Index() as ViewResult;
      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
