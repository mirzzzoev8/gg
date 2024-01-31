List<int> ints = new List<int>(){1,2,3,4,5};

var random = new Random();
for (int i = 0; i < random.Next(1,5); i++)
{
    ints.Add(random.Next(1,5));
}
foreach (var i in ints)
{
    System.Console.WriteLine(i);
}