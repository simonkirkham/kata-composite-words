# kata-composite-words

For this kata, we’re going to write a program to solve a simple problem, and we’re going to write it with three different sub-objectives. Our program is going do process the dictionary from here - http://codekata.com/data/wordlist.txt, looking for all six letter words which are composed of two concatenated smaller words. For example:

 ```
  al + bums => albums
  bar + ely => barely
  be + foul => befoul
  con + vex => convex
  here + by => hereby
  jig + saw => jigsaw
  tail + or => tailor
  we + aver => weaver
  ```
  
Write the program three times.
 - The first time, make program as readable as you can make it.
 - The second time, optimize the program to run fast fast as you can make it.
 - The third time, write as extendable a program as you can.
 
 

Now look back at the three programs and think about how each of the three subobjectives interacts with the others. For example, does making the program as fast as possible make it more or less readable? Does it make easier to extend? Does making the program readable make it slower or faster, flexible or rigid? And does making it extendable make it more or less readable, slower or faster? Are any of these correlations stronger than others? What does this mean in terms of optimizations you may perform on the code you write?


## Stretch Goals 
If all the above is completed then try writing the program again
 - Using a purely OO approach
 - Using a purely functional approach
