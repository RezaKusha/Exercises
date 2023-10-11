using System;
using System.Linq;

public class Program
{
    
    public static void Main()
    {
        
        Console.WriteLine("Hello. Welcome to The Treasure Hunt");
        
        
        int[,] grid;
        int rows = 5;
        int cols = 5;
        grid = new int[rows, cols];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                grid[i, j] = random.Next(1, 25);
            }
        }

        int playerRow = 0;
        int playerCol = 0;
        int movesLeft = 5;

        
        

        string cube = "|_";

        while (movesLeft > 0)
        {
            

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == playerRow && j == playerCol)
                    {
                        Console.Write("|X");
                    }
                    else
                    {
                        Console.Write(cube);
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("Moves left: " + movesLeft);
            Console.WriteLine("Enter your command (up, down, left, right):");
            string command = Console.ReadLine();
            
            if (command == "cheat")
            {
                int treasureRow = 0;
                int treasureCol = 0;
                int maxTreasure = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (grid[i, j] > maxTreasure)
                        {
                            maxTreasure = grid[i, j];
                            treasureRow = i;
                            treasureCol = j;
                        }
                    }
                }

                Console.WriteLine($"The Treasure Address is ({treasureRow}, {treasureCol}).");
                continue;
            }
            

            
            switch (command)
            {
                case "up":
                    if (playerRow > 0)
                    {
                        playerRow--;
                        movesLeft--;
                    }
                    break;
                case "down":
                    if (playerRow < rows - 1)
                    {
                        playerRow++;
                        movesLeft--;
                    }
                    break;
                case "left":
                    if (playerCol > 0)
                    {
                        playerCol--;
                        movesLeft--;
                    }
                    break;
                case "right":
                    if (playerCol < cols - 1)
                    {
                        playerCol++;
                        movesLeft--;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command. Please enter up, down, left, or right.");
                    break;
            }
            
            if (grid[playerRow, playerCol] == grid.Cast<int>().Max())
            {
                Console.WriteLine("You Found The Treasure. You Win!");
                return; 
            }

            
            if (grid[playerRow, playerCol] == grid.Cast<int>().Min())
            {
                Console.WriteLine("You Stepped On a Trap. You Lose!");
                return;
            }
        }

        Console.WriteLine("Out of Moves. Game Over!");
    }
}
