List<int> ints = new List<int>(){1,2,3,4,5};
ints.RemoveAll(e => e < 2);
foreach (var item in ints)
{
    System.Console.WriteLine(item);
}