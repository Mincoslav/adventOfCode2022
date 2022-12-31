IEnumerable<string> input = System.IO.File.ReadLines(@"./input.txt");

int PrioritySum = 0;
// foreach (string rucksack in input)
// {
//     //split rucksack
//     var rightSide = rucksack.Substring(rucksack.Length / 2);
//     var leftSide = rucksack.Remove(rucksack.Length / 2);


//     // System.Console.WriteLine(rucksack);
//     System.Console.WriteLine(string.Format("left = {0}, right = {1}", leftSide, rightSide));
//     // System.Console.WriteLine(string.Format("rucksackLength = {0}, subLength = {1}", leftSide.Length, rightSide.Length));

//     //find duplicates
//     foreach (var letter in leftSide)
//     {
//         // System.Console.WriteLine();
//         if (rightSide.Contains(letter))
//         {
//             int index = (int)letter % 32;
//             // int index = (int)letter;
//             if (Char.IsUpper(letter))
//             {
//                 index = index + 26;
//             }
//             System.Console.WriteLine(string.Format("char = {0}, value = {1}", letter, index));
//             //sum priority
//             PrioritySum += index;
//             break;
//         }
//     }
// }
// System.Console.WriteLine(PrioritySum);


// Part 2
for (int i = 0; i < input.Count() - 1; i++)
{
    try
    {
        foreach (var character in input.ElementAt(i))
        {
            if (input.ElementAt(i + 1).Contains(character) && input.ElementAt(i + 2).Contains(character))
            {
                int index = (int)character % 32;
                if (Char.IsUpper(character))
                {
                    index = index + 26;
                }
                PrioritySum += index;
            }
            // System.Console.WriteLine(character);
        }
    }
    catch (System.ArgumentOutOfRangeException)
    {
        // foreach (var character in input.ElementAt(i))
        // {
        //     if (input.ElementAt(i + 1).Contains(character) && input.ElementAt(i + 2).Contains(character))
        //         System.Console.WriteLine(character);
        // }
        // throw;
    }
}
System.Console.WriteLine(PrioritySum);