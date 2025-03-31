using RockPaperScissors.Models;

var game = new Game(3);
game.AddPlayer(new ComputerPlayer("Voldemort"));
game.AddPlayer(new ComputerPlayer("Darth Vader"));

game.AskUserForName();

game.Start();
