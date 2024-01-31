List<int> ints = new List<int>(){1,2,3,4,5};
var i = ints.FindLastIndex(e => e == ints.Count);

System.Console.WriteLine(i);