using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

    [TestMethod]
    public void WordConvertToLower_ConvertInputWordToLowerCase_LowerCaseString()
    {
      //Arrange
      string testWord = "I";
      WordCounter testWordCounter = new WordCounter(testWord,"Sentence");
      //Act
      string result = testWordCounter.WordConvertToLower();
      //Assert
      Assert.AreEqual("i", result);
    }

    [TestMethod]
    public void SentenceConvertToLower_ConvertInputSentenceToLowerCase_LowerCaseString()
    {
      //Arrange
      string testSentence = "I Love OREGON";
      WordCounter testWordCounter = new WordCounter("Word",testSentence);
      //Act
      string result = testWordCounter.SentenceConvertToLower();
      //Assert
      Assert.AreEqual("i love oregon", result);
    }

    [TestMethod]
    public void CheckMatch_CheckForSingleLetterMatch_Count()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter("a","a");
      //Act
      int result = testWordCounter.CheckMatch("a","a");
      //Assert
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void CheckMatch_CheckForSingleLetterMultipleMatch_Count()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter("a","a b a c g");
      //Act
      int result = testWordCounter.CheckMatch("a","a b a c g");
      //Assert
      Assert.AreEqual(2,result);
    }

    [TestMethod]
    public void CheckMatch_CheckForWordsMatch_Count()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter("love","I love Oregon");
      //Act
      int result = testWordCounter.CheckMatch("love","I love Oregon");
      //Assert
      Assert.AreEqual(1,result);
    }
  }
}
