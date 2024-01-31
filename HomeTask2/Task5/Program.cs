List<string> strings = new List<string>(){"Yusuf","Yusufwo","Mirzoev"};
var yy = strings.GetRange(1,2);
foreach (var item in yy)
{
    System.Console.WriteLine(item);
}