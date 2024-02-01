// See https://aka.ms/new-console-template for more information

using Mission4___TicTacToe___Group_3_6;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] gameboard = new string[9];
for (int i = 0; i < gameboard.Length; i++)
{
    gameboard[i] = (i + 1).ToString();
}

ThicTacToe ttt = new ThicTacToe();

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

    if (ttt.CheckForWinner(gameboard, 1))
    {
        gameOver = true;
    }
    if (ttt.CheckForTie(gameboard, 1))
    {
        gameOver = true;
    }

    if (!gameOver)
    {
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



        gameboard[spot - 1] = "O";

        if (ttt.CheckForWinner(gameboard, 2))
        {
            gameOver = true;
        }
        if (ttt.CheckForTie(gameboard, 2))
        {
            gameOver = true;
        }

    }
} while (!gameOver);
