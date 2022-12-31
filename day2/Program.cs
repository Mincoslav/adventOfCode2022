// Dictionary<string, int> MyMoveValues = new Dictionary<string, int>()
// {
//     ["A"] = 1,
//     ["B"] = 2,
//     ["C"] = 3
// };

// Dictionary<string, int> OponnentMoveValues = new Dictionary<string, int>()
// {
//     ["X"] = 1,
//     ["Y"] = 2,
//     ["Z"] = 3
// };

// Dictionary<string, int> Results = new Dictionary<string, int>()
// {
//     ["loss"] = 0,
//     ["draw"] = 3,
//     ["win"] = 6
// };

IEnumerable<string> input = System.IO.File.ReadLines(@"./input.txt");

// int totalScore = 0;
// foreach (var match in input)
// {
//     string myMove = Convert.ToString((match.Last()));
//     string opponentMove = Convert.ToString((match.First()));
//     int roundTotal = 0;

//     // A for Rock, B for Paper, and C for Scissors
//     // X for Rock, Y for Paper, and Z for Scissors

//     // 1 for Rock, 2 for Paper, and 3 for Scissors

//     // 0 if you lost, 3 if the round was a draw, and 6 if you won


//     if (myMove=="X") { //Rock
//         roundTotal += 1;
//         if (opponentMove == "A")
//         {
//             roundTotal += 3;
//         }
//         else if (opponentMove == "B")
//         {
//             roundTotal += 0;
//         }
//         else if (opponentMove == "C")
//         {
//             roundTotal += 6;
//         }
//     }
//     else if (myMove == "Y") //Paper
//     {
//         roundTotal += 2;
//         if (opponentMove == "A")
//         {
//             roundTotal += 6;
//         }
//         else if (opponentMove == "B")
//         {
//             roundTotal += 3;
//         }
//         else if (opponentMove == "C")
//         {
//             roundTotal += 0;
//         }
//     }
//     else if (myMove == "Z") //Scissors
//     {
//         roundTotal += 3;
//         if (opponentMove == "A")
//         {
//             roundTotal += 0;
//         }
//         else if (opponentMove == "B")
//         {
//             roundTotal += 6;
//         }
//         else if (opponentMove == "C")
//         {
//             roundTotal += 3;
//         }
//     }
//     totalScore += roundTotal;
//     System.Console.WriteLine(string.Format("My = {0}, Their = {1}, Score = {2}", myMove, opponentMove, totalScore));

// }

// System.Console.WriteLine(totalScore);


// Part 2:
int totalScore = 0;
foreach (var match in input)
{
    string result = Convert.ToString((match.Last()));
    string opponentMove = Convert.ToString((match.First()));
    int roundTotal = 0;

    // A for Rock, B for Paper, and C for Scissors
    // X for Loss, Y for Draw, and Z for Win

    // 1 for Rock, 2 for Paper, and 3 for Scissors

    // 0 if you lost, 3 if the round was a draw, and 6 if you won


    if (result == "X")
    { //Loss
        roundTotal += 0;
        if (opponentMove == "A")
        {
            roundTotal += 3;
        }
        else if (opponentMove == "B")
        {
            roundTotal += 1;
        }
        else if (opponentMove == "C")
        {
            roundTotal += 2;
        }
    }
    else if (result == "Y") //Draw
    {
        roundTotal += 3;
        if (opponentMove == "A")
        {
            roundTotal += 1;
        }
        else if (opponentMove == "B")
        {
            roundTotal += 2;
        }
        else if (opponentMove == "C")
        {
            roundTotal += 3;
        }
    }
    else if (result == "Z") //Win
    {
        roundTotal += 6;
        if (opponentMove == "A")
        {
            roundTotal += 2;
        }
        else if (opponentMove == "B")
        {
            roundTotal += 3;
        }
        else if (opponentMove == "C")
        {
            roundTotal += 1;
        }
    }
    totalScore += roundTotal;
    System.Console.WriteLine(string.Format("them = {0}, result = {1}, Score = {2}", opponentMove, result, totalScore));

}