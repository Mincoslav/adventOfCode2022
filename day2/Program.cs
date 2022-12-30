Dictionary<string, int> MyMoveValues = new Dictionary<string, int>()
{
    ["A"] = 1,
    ["B"] = 2,
    ["C"] = 3
};

Dictionary<string, int> OponnentMoveValues = new Dictionary<string, int>()
{
    ["X"] = 1,
    ["Y"] = 2,
    ["Z"] = 3
};

Dictionary<string, int> Results = new Dictionary<string, int>()
{
    ["loss"] = 0,
    ["draw"] = 3,
    ["win"] = 6
};

IEnumerable<string> input = System.IO.File.ReadLines(@"./input.txt");

foreach (var match in input)
{
    char myMove = match.First();
    char opponentMove = match.Last();

    System.Console.WriteLine(string.Format("My = {0}, Their = {1}", myMove, opponentMove));
    int roundTotal = 0;

    switch (MyMoveValues.Keys.ToList().ToString())
    {
        case "A":

            break;


        case "B":
            break;
        case "C":
            break;
    
    }
}

// MoveValues.ToList().ForEach(kvp => Console.WriteLine(string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value)));

// A for Rock, B for Paper, and C for Scissors
// X for Rock, Y for Paper, and Z for Scissors

// 1 for Rock, 2 for Paper, and 3 for Scissors

// 0 if you lost, 3 if the round was a draw, and 6 if you won