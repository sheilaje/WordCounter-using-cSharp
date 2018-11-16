using System;
using System.Collections;

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

    // public string CheckMatch()
    // {
    //   if(this._sentence.Contains(this._word) == true)
    //   {
    //     return "1";
    //   } else
    //   {
    //   return "0";
    // }
    // }
    public int CheckMatch()
    {
      string[] splitArray = this._sentence.Split(' ');
      int count = 0;
      foreach ( string word in splitArray)
      {
        if(this._sentence.Contains(this._word))
        {
          count = count + 1;
        }
        // else
        // {
        //   count = count + 0;
        // }
      }
      return count;
    }
  }
}
