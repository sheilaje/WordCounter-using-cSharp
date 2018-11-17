using System;

namespace WordCounter.Models
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("-------------------------------------------------------");
      Console.WriteLine("Please enter the sentence");
      string userInputSentence = Console.ReadLine();
      Console.WriteLine("Please enter the word to check the number of occurance");
      string userInputWord = Console.ReadLine();
      WordCounter testWordCounter = new WordCounter(userInputWord,userInputSentence);

      string wordInLowerCase = testWordCounter.WordConvertToLower();
      string sentenceInLowerCase = testWordCounter.SentenceConvertToLower();

      Console.WriteLine("Word in Lowercase : {0}", wordInLowerCase);
      Console.WriteLine("Sentence in Lowercase : {0}", sentenceInLowerCase);

      int noOfOccurance = testWordCounter.CheckMatch(wordInLowerCase,sentenceInLowerCase);

      Console.WriteLine("\n");
      Console.WriteLine("The word {0} occurs {1} time(s) in the sentence {2}", userInputWord, noOfOccurance, userInputSentence);
      Console.WriteLine("-------------------------------------------------------");
    }
  }
}
