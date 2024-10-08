using System;
using System.Collections.Generic;

class GFG {
    public static List<Tuple<int, int>> data = new List<Tuple<int, int>>();

    static int N; // Number of rows
    static int M; // Number of columns
    static int startX;
    static int startY;

    /* A utility function to check if x,y are valid indexes for N*M chessboard */
    static bool isSafe(int x, int y, int[, ] sol)
    {
        return (x >= 0 && x < N && y >= 0 && y < M && sol[x, y] == -1);
    }

    /* This function solves the Knight Tour problem using Backtracking. */
    static bool solveKT()
    {
        int[, ] sol = new int[N, M];

        /* Initialization of solution matrix */
        for (int x = 0; x < N; x++)
            for (int y = 0; y < M; y++)
                sol[x, y] = -1;

        /* default sequence
                int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
                int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };
        */
        
        //xMove[] and yMove[] define next move of Knight.
        int[] xMove = { 2, -2, 1, -1, -2, -1, 1, 2 };
        int[] yMove = { -1, -1, 2, 2, 1, -2, -2, 1 };
        
        // Start the knight at the given starting position
        sol[startX, startY] = 0;
        data.Add(new Tuple<int, int>(startX, startY));

        /* Start from startX and startY and explore all tours using solveKTUtil() */
        if (!solveKTUtil(startX, startY, 1, sol, xMove, yMove)) {
            Console.WriteLine("Solution does not exist");
            return false;
        }

        return true;
    }

    /* A recursive utility function to solve Knight Tour problem */
    static bool solveKTUtil(int x, int y, int movei,
                            int[, ] sol, int[] xMove,
                            int[] yMove)
    {
        int k, next_x, next_y;

        if (movei == N * M) // Updated termination condition for N * M board
            return true;

        /* Try all next moves from the current coordinate x, y */
        for (k = 0; k < 8; k++) {
            next_x = x + xMove[k];
            next_y = y + yMove[k];
            if (isSafe(next_x, next_y, sol)) {
                sol[next_x, next_y] = movei;
                data.Add(new Tuple<int, int>(next_x, next_y)); // Store knight's move
                if (solveKTUtil(next_x, next_y, movei + 1, sol, xMove, yMove))
                    return true;
                else {
                    // backtracking
                    sol[next_x, next_y] = -1;
                    data.RemoveAt(data.Count - 1); // Remove the last move if it doesn't work
                }
            }
        }

        return false;
    }

    public static void Main()
    {
        string[] values1 = Console.ReadLine().Split(' ');
        N = int.Parse(values1[0]);
        M = int.Parse(values1[1]);
        
        string[] values2 = Console.ReadLine().Split(' ');
        startX = int.Parse(values2[0]);
        startY = int.Parse(values2[1]);

        if (solveKT()) {
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine($"({data[i].Item1}, {data[i].Item2})");
            }
        }
    }
}