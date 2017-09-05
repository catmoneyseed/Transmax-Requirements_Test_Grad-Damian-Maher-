# Transmax-Requirements_Test_Grad-Damian-Maher-
Programming test for Transmax, a console app written in C#

To run the app, navigate to the .exe file as follows:

Requirements_Test_Grad\bin\Debug\Requirements_Test_Grad.exe


USING THE APPLICATION

When the application is run, the console will display the following:

  grade-scores 
  
At this point, either type the name of the input .txt file (if the file is in the
same directory as the .exe file), or paste the complete directory of the file if
it is in another location.

e.g.

  grade-scores test.txt 
  or
  grade-scores C:\Users\[user name]\Documents\test.txt
  
Hit enter, and the app will output a sorted version of your input file as well as 
save a .txt file of the solution to the same directory where the original input
file is located. The console will remain open and display the solution until any key
is pressed, upon which the application will close.

EXTRA

the following is a link to an appveyor project for this assignment:

https://ci.appveyor.com/project/catmoneyseed/transmax-requirements-test-grad-damian-maher 

I managed to have it build the project on checkin, however, my unit tests are being discovered
but not executed by the appveyor platform. 


Thanks for the opportunity to have a go at this assignment. 


