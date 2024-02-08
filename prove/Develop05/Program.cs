/*

Showing Creativity and Exceeding Requirements:
    - added rank system with 51 ranks. ranks increase per 200 points. final rank can increase infinitely.
    - marked eternal goals with an [E] instead of always leaving undone [ ]
    - when choosing filename, automatically adds .txt, no longer need to specify
    - when choosing a points value for creating new goals, will display an error message for negative values or 0, as well as for invalid integers

*/


using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.Start();
    }
}