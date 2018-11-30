# _Word Counter_

#### _Application checks the number of times a particular word occurs in a sentence, 11-16-2018_

#### By _**Sheila Stephen**_

## Description

_Write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.) Also, do not use regular expressions in your logic._

## Specs
1. Convert the userinput and the sentence to lowercase.

              Sample Input - A
              Sample match provided by the user - a
              Expected output - a

2. Get single letter as user input to check.Check if the user has entered the same letter and count if so.

              Sample Input - a
              Sample match provided by the user - a
              Number of occurance - 1

3. Get single letter as user input to check. count the number of times the single letter occurs in the sentence.

              Sample Input to check - a
              Sample sentence provided by the user - a a e a a
              Number of occurance - 4

4.  Split the user given sentence into an array of words .

              Sample sentence provided by the user - How are you
              Expected output - [ How, are, you ]

5. Compare each word in the split array with user provided word to check the number of times it occurs. If same, increment a counter.

6. Create 2 controllers
  * _HomeController_
  * _WordCounterController_

7. Home Controller has the route with the URL for the ROOT page and action method(Index()) that has to the view of that particular method.
      * _Route _ [HttpGet("/")]_
      when we first run the application this route will be the landing page.

8. WordCounterController has 2 action methods
      * _To offer a form to the user to enter the word and the sentence_
              * _It's corresponding Route to its view page with the form [HttpGet("/wordCounter/New")]_
      * _It checks the input ,does the process and displays the output in the page_
              * _[HttpPost("/wordcounter/checkmatch")]_

## Setup/Installation Requirements

* _.NET CORE_
* _Mono_

## Known Bugs

_No known bugs_

## Support and contact details

_Sheila Stephen_

## Technologies Used

* _C#_
* _.NET_
* _MS Test_

### License

*MIT*

Copyright (c) 2018 **_Sheila Stephen_**
