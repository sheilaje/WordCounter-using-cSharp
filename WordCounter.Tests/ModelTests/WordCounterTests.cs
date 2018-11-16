using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;
//using System.Collections.Generic;

namespace WordCounter.Models
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void WordCounterConstructor_CreatesInstanceOfWordCounter_WordCounter()
    {
      WordCounter testWordCounter = new WordCounter("test");
      Assert.AreEqual(typeof(WordCounter), testWordCounter.GetType());
    }
  }
}

// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using ToDoList.Models;
//
// namespace ToDoList.Tests
// {
//   [TestClass]
//   public class ItemTest
//   {
//
//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       WC testWordCounter = new WC();
//       Assert.AreEqual(typeof(WC), testWordCounter.GetType());
//     }
//
//   }
// }
