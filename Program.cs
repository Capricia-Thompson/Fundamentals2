int[] arrayOne = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (int num in arrayOne)
{
    Console.WriteLine(num);
}

string[] arrayTwo = new string[] { "Tim", "Martin", "Nikki", "Sara" };

foreach (string name in arrayTwo)
{
    Console.WriteLine(name);
}

bool[] arrayThree = new bool[10];

for (int i = 0; i < arrayThree.Length; i++)
{
    if (i % 2 == 0)
    {
        arrayThree[i] = true;
    }
    else
    {
        arrayThree[i] = false;
    }
}

foreach (bool item in arrayThree)
{
    Console.WriteLine(item);
};

List<string> iceCream = new List<string>();

iceCream.Add("Vanilla");
iceCream.Add("Birthday Cake");
iceCream.Add("Cookie Dough");
iceCream.Add("Vanilla");
iceCream.Add("Cherry");

Console.WriteLine(iceCream.Count);

Console.WriteLine(iceCream[2]);

iceCream.RemoveAt(2);

Console.WriteLine(iceCream.Count);

Dictionary<string, string> newDict = new Dictionary<string, string>();

Random rand = new Random();

foreach (string name in arrayTwo)
{
    newDict.Add(name, iceCream[rand.Next(iceCream.Count)]);
}

foreach (KeyValuePair<string, string> pair in newDict)
{
    Console.WriteLine($"{pair.Key} - {pair.Value}");
}