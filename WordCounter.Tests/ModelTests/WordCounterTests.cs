using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCounter.Models
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void WordCounterConstructor_CreatesInstanceOfWordCounter_Type()
    {
      Word testWordCounter = new Word("word","sentence");
      Assert.AreEqual(typeof(Word), testWordCounter.GetType());
    }

    [TestMethod]
    public void Properties_CheckPropertyWord_string()
    {
      //Arrange
      string testWord = "Word";
      Word testWordCounter =new Word("Word","Sentence");
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
      Word testWordCounter =new Word("Word","Sentence");
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
      Word testWordCounter = new Word(testWord,"Sentence");
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
      Word testWordCounter = new Word("Word",testSentence);
      //Act
      string result = testWordCounter.SentenceConvertToLower();
      //Assert
      Assert.AreEqual("i love oregon", result);
    }

    [TestMethod]
    public void CheckMatch_CheckForSingleLetterMatch_Count()
    {
      //Arrange
      Word testWordCounter = new Word("a","a");
      //Act
      int result = testWordCounter.CheckMatch();
      //Assert
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void CheckMatch_CheckForSingleLetterMultipleMatch_Count()
    {
      //Arrange
      Word testWordCounter = new Word("a","a b a c g");
      //Act
      int result = testWordCounter.CheckMatch();
      //Assert
      Assert.AreEqual(2,result);
    }

    [TestMethod]
    public void CheckMatch_CheckForWordsMatch_Count()
    {
      //Arrange
      Word testWordCounter = new Word("love","I love Oregon");
      //Act
      int result = testWordCounter.CheckMatch();
      //Assert
      Assert.AreEqual(1,result);
    }
  }
}
