List<int> ints = new List<int>(){1,2,3,4,5};
List<int> ints1 = new List<int>(){1,2,3,4,8};
bool contains = ints1.All(e => ints.Contains(e));
if(contains)
{
    System.Console.WriteLine("true");
}
else
{
    System.Console.WriteLine("false");
}