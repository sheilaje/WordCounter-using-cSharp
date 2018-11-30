using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCounter
  {
    private string _word;
    private string _sentence;

    public WordCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return this._word;
    }

    public string GetSentence()
    {
      return this._sentence;
    }

    public string WordConvertToLower()
    {
      return this._word.ToLower();
    }

    public string SentenceConvertToLower()
    {
      return this._sentence.ToLower();
    }

    public int CheckMatch()
    {
      string targetWord = WordConvertToLower();
      string sentence = SentenceConvertToLower();
      string[] sentenceSplitIntoWords = sentence.Split(' ');
      int count = 0;
      foreach (string currentWord in sentenceSplitIntoWords)
      {
        if(targetWord==currentWord)
        {
          count++;
        }
      }
      return count;
    }
  }
}
