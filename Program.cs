// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

string[] gameboard = new string[9];
for (int i = 0; i < gameboard.Length; i++)
{
    gameboard[i] = gameboard[i + 1].ToString();
}

thictactoe ttt = new thictactoe();

bool gameOver = false;

Console.Write("TIC");
Thread.Sleep(300);
Console.Write("-TAC");
Thread.Sleep(300);
Console.Write("-TOE!!!");

do
{
    int spot = 0;
    string userInput = "";
    Thread.Sleep(1000);
    Console.WriteLine("PLAYER ONE! YOUR TURN");
    Thread.Sleep(300);
    ttt.PrintBoard(gameboard);


    do
    {
        Console.WriteLine("Where do you place your mark?");
        Console.WriteLine("Enter a number from 1 to 9: ");
        userInput = Console.ReadLine();
        if (!Int32.TryParse(userInput, out spot))
        {
            Console.WriteLine("Please enter a valid integer");
        } else if (gameboard[spot - 1] == "X" || gameboard[spot - 1] == "O")
        {
            Console.WriteLine("That spot is already taken. Try again!");
            spot = 0;
        }

    } while (spot < 1 || spot > 9);

    gameboard[spot - 1] = "X";

    spot = 0;
    userInput = "";
    Thread.Sleep(1000);
    Console.WriteLine("PLAYER TWO! YOUR TURN");
    Thread.Sleep(300);
    ttt.PrintBoard(gameboard);


    do
    {
        Console.WriteLine("Where do you place your mark?");
        Console.WriteLine("Enter a number from 1 to 9: ");
        userInput = Console.ReadLine();
        if (!Int32.TryParse(userInput, out spot))
        {
            Console.WriteLine("Please enter a valid integer");
        }
        else if (gameboard[spot - 1] == "X" || gameboard[spot - 1] == "O")
        {
            Console.WriteLine("That spot is already taken. Try again!");
            spot = 0;
        }

    } while (spot < 1 || spot > 9);

    gameboard[spot - 1] = "0";

    ttt.PrintBoard(gameboard);

    if (ttt.CheckForWinner)
    {
        gameOver = true;
    }
    if (ttt.CheckForTie)
    {
        gameOver = true;
    }


} while (!gameOver);
