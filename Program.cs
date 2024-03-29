﻿// See https://aka.ms/new-console-template for more information

// Authors: Zach, Patrick, Mark, Mark

// We built a tic tac toe game that two people can play

using Mission4___TicTacToe___Group_3_6;
using static System.Runtime.InteropServices.JavaScript.JSType;

// HEre is our string that creates the board and assignes all of the spots to a number between 
// 1 - 9
string[] gameboard = new string[9];
for (int i = 0; i < gameboard.Length; i++)
{
    gameboard[i] = (i + 1).ToString();
}

// Here is whwere we start the game 

ThicTacToe ttt = new ThicTacToe();

bool gameOver = false;

// This does a count down for them to play
Console.Write("TIC");
Thread.Sleep(300);
Console.Write("-TAC");
Thread.Sleep(300);
Console.Write("-TOE!!!");
/// This is a do loop that tells the player whos turn it is and promts them to keep playing the game
do
{
    int spot = 0;
    string userInput = "";
    Thread.Sleep(1000);
    Console.WriteLine("PLAYER ONE! YOUR TURN");
    Thread.Sleep(300);
    ttt.PrintBoard(gameboard);

    // This do loop makes the spots with x's and o's depending on what they say
    do
    {
        Console.WriteLine("Where do you place your mark?");
        Console.WriteLine("Enter a number from 1 to 9: ");
        userInput = Console.ReadLine();
        if (!Int32.TryParse(userInput, out spot) || int.Parse(userInput) < 1 || int.Parse(userInput) > 9)
        {
            Console.WriteLine("Please enter a valid integer");
        } else if (gameboard[spot - 1] == "X" || gameboard[spot - 1] == "O")
        {
            Console.WriteLine("That spot is already taken. Try again!");
            spot = 0;
        }

    } while (spot < 1 || spot > 9);

    gameboard[spot - 1] = "X";

    // This chekcs for winners and ties 
    if (ttt.CheckForWinner(gameboard, 1))
    {
        gameOver = true;
    }
    if (ttt.CheckForTie(gameboard))
    {
        gameOver = true;
    }
    // If it is not a game over then it keeps going and runs the game until someone wins

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
        if (ttt.CheckForTie(gameboard))
        {
            gameOver = true;
        }

    }
} while (!gameOver);
