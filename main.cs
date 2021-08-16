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
    string win = "false";
    string playAgain = "false";
    
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
      Console.WriteLine(A+ " | " +B+ " | " +C);
      Console.WriteLine("");
      Console.WriteLine(D+ " | " +E+ " | " +F);
      Console.WriteLine("");
      Console.WriteLine(G+ " | " +H+ " | " +I);
      Console.WriteLine("");
      Console.WriteLine("*********************");
      Console.WriteLine("Please make a selection.");
      selection = Console.ReadLine();
      if(selection == "1"){
        if(A == "1"){
          A = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "2"){
        if(B == "2"){
          B = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "3"){
        if(C == "3"){
          C = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "4"){
        if(D == "4"){
          D = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "5"){
        if(E == "5"){
          E = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "6"){
        if(F == "6"){
          F = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "7"){
        if(G == "7"){
          G = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "8"){
        if(H == "8"){
          H = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      if(selection == "9"){
        if(I == "9"){
          I = "X";
        }else{
          Console.WriteLine("Warning: This box has alredy been used.");
        }
      }
      //Winnerdetection.

      if(A == B && B == C){
        won = "true";
        Console.WriteLine("Congratulations!"+ player + "won!");
        Console.WriteLine("");
        Console.WriteLine("Do you want to play again? Y/N");
        selection = Console.ReadLine();
        if(selection == "Y"){
          playAgain = "true";
        }else{
          playAgain = "false";
        }
      }
      if(D == E && E == F){}
      if(G == H && H == I){}
      if(A == D && D == G){}
      if(B == E && E == H){}
      if(C == F && F == I){}
      if(G == E && E == C){}
      if(A == E && E == I){}

    }

  }
}