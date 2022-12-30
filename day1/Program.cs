Dictionary<int, int> ElfCalories = new Dictionary<int, int>();

IEnumerable<string> input = System.IO.File.ReadLines(@"./input.txt");

int currentElf = 0;
ElfCalories[0] = 0;
for (int index = 0; index < input.Count(); index++)
{
    // System.Console.WriteLine(input.ElementAt(index: index) == "");
    

    if (input.ElementAt(index:index) == "")
    {
        currentElf += 1;
        ElfCalories[currentElf] = 0; 
    }
    else
    {
        ElfCalories[currentElf] += Convert.ToInt32(input.ElementAt(index: index));
    }
}
foreach (KeyValuePair<int, int> kvp in ElfCalories.OrderByDescending(key => key.Value))
{
    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    System.Console.WriteLine(string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value));
}