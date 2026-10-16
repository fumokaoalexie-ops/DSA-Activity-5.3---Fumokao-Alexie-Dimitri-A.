using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Stack<int> playerA = new Stack<int>();
        Stack<int> playerB = new Stack<int>();

        int[] A = { 2, 7, 8, 1, 6, 4, 3, 2, 8, 9 };
        int[] B = { 8, 1, 9, 3, 6, 5, 9, 4, 3 };

        foreach (int n in A)
            playerA.Push(n);

        foreach (int n in B)
            playerB.Push(n);

        int scoreA = 0;
        int scoreB = 0;
        int match = 1;

        Console.WriteLine("WELCOME To My SIMPLE GAME program.");
        Console.WriteLine();
        Console.WriteLine("Player A: " + string.Join(" ", A));
        Console.WriteLine("Player B: " + string.Join(" ", B));
        Console.WriteLine();

        while (playerA.Count > 0 && playerB.Count > 0)
        {
            int a = playerA.Pop();
            int b = playerB.Pop();

            Console.WriteLine("Match " + match + ":");
            Console.WriteLine(a + " vs " + b);

            if (a > b)
            {
                Console.WriteLine("Player A Win");
                scoreA++;
            }
            else if (b > a)
            {
                Console.WriteLine("Player B Win");
                scoreB++;
            }
            else
            {
                Console.WriteLine("Rematch");
                playerA.Push(a);
                playerB.Push(b);
            }

            Console.WriteLine();
            match++;
        }

        Console.WriteLine("Final Result:");
        Console.WriteLine("Player A Score: " + scoreA);
        Console.WriteLine("Player B Score: " + scoreB);
        Console.WriteLine();

        if (scoreA > scoreB)
            Console.WriteLine("Player A Win");
        else if (scoreB > scoreA)
            Console.WriteLine("Player B Win");
        else
            Console.WriteLine("Draw");

        Console.WriteLine();
        Console.WriteLine("Thank you for using the program");
    }
}
