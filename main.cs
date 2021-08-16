using System;

class MainClass {
  public static void Main (string[] args) {
    
    string A = "1";
    string B = "2";
    string C = "3";
    string D = "4";
    string E = "5";
    string F = "6";
    string G = "7";
    string H = "8";
    string I = "9";
    string player1,player2,selection;
    string turn = "Player1";
    Console.WriteLine(">> TIC TAC TOE <<");
    Console.WriteLine("");
    Console.WriteLine("Please enter the name of the firdt player.");
    player1 = Console.ReadLine();
    Console.WriteLine("Please enter the name of the second player.");
    player2 = Console.ReadLine();
    Console.Clear();

    if(turn == "Player1") //Playerx
    {
      Console.Clear();
      Console.WriteLine("Player: " + player1 + "'s turn!");
      Console.WriteLine("");
      //Draw board
      Console.WriteLine(A+ " | " +B+ " | " +c);
      Console.WriteLine("");
      Console.WriteLine(D+ " | " +E+ " | " +F);
      Console.WriteLine("");
      Console.WriteLine(G+ " | " +H+ " | " +I);
      Console.WriteLine("");
      Console.WriteLine("*********************");
      Console.WriteLine("Please make a selection.")
      selection = Console.ReadLine();
      if(selection == "1"){
        if(A == "1"){
          A = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
    }

  }
}