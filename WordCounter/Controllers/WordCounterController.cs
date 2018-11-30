using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/word-counter/new")]
    public ActionResult New()
    {
      return View();
    }

  [HttpPost("/check-match")]
    public ActionResult Show(string word, string sentence)
    {
      WordCounter newWordCounter = new WordCounter(word, sentence);
      return View(newWordCounter);
    }
  }
}
