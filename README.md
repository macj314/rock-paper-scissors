# _Epicodus C# Rock Paper Scissors_

#### Date: May 13th, 2020
#### By _**Jason Macie** & **DJ Zevenbergen**_

## Description

This application should emulate the Rock-Paper-Scissors game using the command console. Users should be able to put in one of the 3 text options, and the application will display who won, or a draw.

## Setup/Installation Requirements

This program requires .NET to be installed. It uses the MSTest tool to test possible string inputs.

* Clone this repository
* Change any tests in:
* Navigate to the repo in command console. Then navigate to Leetspeak.Tests directory.
* Run dotnet test

## Specs

* Create a Player class, that takes in two parameters: a string for the player's move, and a boolean that indicates that it's a player or computer.
  * Input:  playerOne(rock, true)
            playerTwo(rock, false)
  * Output: Player One - Human, Rock
            Player Two - Computer, Rock
<!-- * Instantiate an instance of the Game class. -->
* Create a game class that takes in two parameters: Two instances of the player class
  * Input: Player One - Human, Rock
           Player Two - Computer, Rock
  * Output: Game - Tied

* Compares the players' choices and if they are the same, returns a tie
  * Input: Player One - Rock, Player Two - Rock
  * Output: Tie
            Play Again? Y/N

* Compares the players' choices and if they are the different, determine the winner
  * Input: Player One - Rock, Player Two - Paper
  * Output: Paper beats rock
            Play Again? Y/N

## Known Bugs

No known bugs as of 5/13/2020

## Technologies Used

* .NET

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**
