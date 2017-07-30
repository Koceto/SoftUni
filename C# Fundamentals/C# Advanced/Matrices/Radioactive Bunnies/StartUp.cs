using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Bunnies
{
    public static class StartUp
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new char[dimentions[0]][];
            var hasPlayerDiedOrEscaped = false;
            var hasPlayerWon = new[] { false };

            for (int i = 0; i < dimentions[0]; i++)
            {
                matrix[i] = new char[dimentions[1]];
                matrix[i] = Console.ReadLine().Trim().ToCharArray();
            }
            var playerPos = FindPlayer(matrix);
            var newPlayerPos = new int[2];
            var commands = Console.ReadLine().Trim().ToCharArray();

            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'U':
                        newPlayerPos = new[] { playerPos[0] - 1, playerPos[1] };
                        hasPlayerDiedOrEscaped = PlayerMoves(matrix, playerPos, newPlayerPos, hasPlayerWon);
                        break;

                    case 'D':
                        newPlayerPos = new[] { playerPos[0] + 1, playerPos[1] };
                        hasPlayerDiedOrEscaped = PlayerMoves(matrix, playerPos, newPlayerPos, hasPlayerWon);
                        break;

                    case 'L':
                        newPlayerPos = new[] { playerPos[0], playerPos[1] - 1 };
                        hasPlayerDiedOrEscaped = PlayerMoves(matrix, playerPos, newPlayerPos, hasPlayerWon);
                        break;

                    case 'R':
                        newPlayerPos = new[] { playerPos[0], playerPos[1] + 1 };
                        hasPlayerDiedOrEscaped = PlayerMoves(matrix, playerPos, newPlayerPos, hasPlayerWon);
                        break;
                }

                if (hasPlayerDiedOrEscaped)
                {
                    break;
                }
            }

            PrintResult(hasPlayerWon, matrix, playerPos);
        }

        private static void PrintResult(bool[] hasPlayerWon, char[][] matrix, int[] playerPos)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
            Console.WriteLine("{0}: {1} {2}",
                hasPlayerWon[0] ? "won" : "dead",
                playerPos[0],
                playerPos[1]);
        }

        private static bool PlayerMoves(char[][] matrix, int[] playerPos, int[] newPlayerPos, bool[] hasPlayerWon)
        {
            var gameOver = false;
            var playerDied = false;

            if (newPlayerPos[0] < 0 ||
                newPlayerPos[0] >= matrix.Length ||
                newPlayerPos[1] < 0 ||
                newPlayerPos[1] >= matrix[0].Length)
            {
                matrix[playerPos[0]][playerPos[1]] = '.';
                hasPlayerWon[0] = true;
                gameOver = true;
            }

            if (!gameOver && matrix[newPlayerPos[0]][newPlayerPos[1]] == '.') // Player can move, game continues
            {
                matrix[playerPos[0]][playerPos[1]] = '.';
                matrix[newPlayerPos[0]][newPlayerPos[1]] = 'P';

                playerPos[0] = newPlayerPos[0];
                playerPos[1] = newPlayerPos[1];
            }
            else if (!gameOver && matrix[newPlayerPos[0]][newPlayerPos[1]] == 'B')
            {
                matrix[playerPos[0]][playerPos[1]] = '.';

                playerPos[0] = newPlayerPos[0];
                playerPos[1] = newPlayerPos[1];
            }

            playerDied = BunniesMultiply(matrix, playerPos);

            return gameOver || playerDied;
        }

        private static bool BunniesMultiply(char[][] matrix, int[] playerPos)
        {
            var bunnyPositions = new Queue<int[]>();
            var hasPlayerDied = false;

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (matrix[rows][cols] == 'B')
                    {
                        bunnyPositions.Enqueue(new[] { rows, cols });
                    }
                }
            }

            while (bunnyPositions.Count > 0)
            {
                var currBunnyPos = bunnyPositions.Dequeue();

                if (currBunnyPos[0] + 1 == playerPos[0] && currBunnyPos[1] == playerPos[1] ||
                    currBunnyPos[0] - 1 == playerPos[0] && currBunnyPos[1] == playerPos[1] ||
                    currBunnyPos[0] == playerPos[0] && currBunnyPos[1] + 1 == playerPos[1] ||
                    currBunnyPos[0] == playerPos[0] && currBunnyPos[1] - 1 == playerPos[1])
                {
                    hasPlayerDied = true;
                }

                if (currBunnyPos[0] - 1 >= 0)
                {
                    matrix[currBunnyPos[0] - 1][currBunnyPos[1]] = 'B'; // Bunny UP
                }

                if (currBunnyPos[0] + 1 < matrix.Length)
                {
                    matrix[currBunnyPos[0] + 1][currBunnyPos[1]] = 'B'; // Bunny DOWN
                }

                if (currBunnyPos[1] - 1 >= 0)
                {
                    matrix[currBunnyPos[0]][currBunnyPos[1] - 1] = 'B'; // Bunny LEFT
                }

                if (currBunnyPos[1] + 1 < matrix[0].Length)
                {
                    matrix[currBunnyPos[0]][currBunnyPos[1] + 1] = 'B'; // Bunny RIGHT -- NOT WORKING
                }
            }

            return hasPlayerDied;
        }

        private static int[] FindPlayer(char[][] matrix)
        {
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (matrix[rows][cols] == 'P')
                    {
                        return new[] { rows, cols };
                    }
                }
            }
            return new[] { 0, 0 };
        }
    }
}