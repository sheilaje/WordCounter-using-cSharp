using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;

namespace WordCounter.Models
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void WordCounterConstructor_CreatesInstanceOfWordCounter_Type()
    {
      WordCounter testWordCounter = new WordCounter("word","sentence");
      Assert.AreEqual(typeof(WordCounter), testWordCounter.GetType());
    }

    [TestMethod]
    public void Properties_CheckPropertyWord_string()
    {
      //Arrange
      string testWord = "Word";
      WordCounter testWordCounter =new WordCounter("Word","Sentence");
      //Act
      string result = testWordCounter.GetWord();
      //Assert
      Assert.AreEqual(testWord,result);
    }

    [TestMethod]
    public void Properties_CheckPropertySentence_string()
    {
      //Arrange
      string testSentence = "Sentence";
      WordCounter testWordCounter =new WordCounter("Word","Sentence");
      //Act
      string result = testWordCounter.GetSentence();
      //Assert
      Assert.AreEqual(testSentence,result);
    }
  }
}
