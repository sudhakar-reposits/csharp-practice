using System.Diagnostics;

string[] log=["ravi","asha","ravi","sunil","asha","ravi","meena"];

var unique=new HashSet<string>(log);
Console.WriteLine($"Log entries: {log.Length}, unique visitors: {unique.Count()}");
Console.WriteLine($"Visitors: {string.Join(',',unique)}");

bool isNew=unique.Add("kiran");
bool again=unique.Add("ravi");
Console.WriteLine($"Kiran Add? {isNew} | ravii dobara add? {again}");

var numbers=Enumerable.Range(1,100_000).ToList();
var numberSet=new HashSet<int>(numbers);
//var numberSet=numbers.ToHashSet();

var sw=Stopwatch.StartNew();
for (int i=0;i<2_000;i++) numbers.Contains(99_999);
long listms=sw.ElapsedMilliseconds;

sw.Restart();
for (int i=0;i<2_000;i++) numberSet.Contains(99_999);
long setms=sw.ElapsedMilliseconds;

Console.WriteLine($"2000 searched -> List {listms} ms, HashSet {setms} ms");


