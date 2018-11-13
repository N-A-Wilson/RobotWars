# RobotWars
This is my solution to the RobotWars code project.


# Instructions 

Open the solution with visual studio to build and run the program and tests (NUnit test framework available via nuget).

Running the program will display the preset input as given in the specification and the final positions of the robots as output. Press any key to exit the application. This test input/output can also be seen via FullInputTest() in AcceptanceTests.cs

# Limitiations

Due to the reduced time available for this project there are a number of limitiations. 

-User input:

  There is no facility for user input at this time, the program only runs with the preset inputs. 
  
-Input validation:

  The program currently assumes all command input is valid. When implementing user input mentioned above validation of this data would be
  necessary to ensure correct functionality.
  
-Movement out of the Arena and Robot Collision:

  While there is a method for checking if a position is valid for a given arena it is not currently used. Additionally there are no 
  checks to see if a space is already occupied before a robot moves to it. Going forward this functionality would be needed to ensure 
  the robots remained in the battle arena and to handle potential combat.

