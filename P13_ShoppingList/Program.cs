List<string> items=["Doodh","Bread","Anda"];
items.Add("Cahi patti");
items.Insert(0,"Aata");
items.Remove("Bread");

Console.WriteLine($"Items ({items.Count}): {string.Join(',',items)}");int totCount=items.Count();

var fisrtItem=items[0];
var lastItem=items[^1];
Console.WriteLine($"Pehla: {fisrtItem}, aakhri: {lastItem}");

var andaIndex=items.IndexOf("Anda");
Console.WriteLine($"Anda hai? {items.Contains("Anda")} | Index: {andaIndex}");
items.Sort();
Console.WriteLine($"Sorted: {string.Join(',',items)}");

string ? firstC=items.Find(x=>x.StartsWith('C'));
Console.WriteLine($"C se pehla item: {firstC}");


