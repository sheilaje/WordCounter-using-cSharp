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

    public int CheckMatch(string word, string sentence)
    {
      string[] splitArray = sentence.Split(' ');
      int count = 0;
      foreach ( string x in splitArray)
      {
        if(x.Contains(word))
        {
          count = count + 1;
        }
        else
        {
          count = count + 0;
        }
      }
      return count;
    }
  }
}
