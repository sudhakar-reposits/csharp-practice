List<int> marks=[45,82,67,91];

var passed=marks.Where(m=>m>=60);
var passedNow=marks.Where(m=>m>=60).ToList();

marks.Add(75);

Console.WriteLine($"Passed (deferred): {string.Join(',',passed)}");
Console.WriteLine($"Passed (ToList)  : {string.Join(',',passedNow)}");

var traced=marks.Where(m=>{Console.WriteLine($"  check {m}"); return m>80;});
Console.WriteLine("Query ban gayi, abhi tak koi check nhi chhapa");
Console.WriteLine($"Count = {traced.Count()}");