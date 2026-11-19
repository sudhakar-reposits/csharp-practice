Dictionary<string,string> phoneBook=new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
  ["Papa"]="9877287653",
  ["Mummy"]="9132457654",
  ["Ramesh Bhaiya"]="8756821430"  
};
phoneBook["Suresh"]="9142637489";
//phoneBook.Add("Papa","1212121212");
bool res=phoneBook.TryAdd("Papa","1212121212");
Console.WriteLine($"Papa dobara add hua ? {res}");

foreach (string name in new[] { "mummy", "Dinesh" })
{
    if(phoneBook.TryGetValue(name,out string? number))
        Console.WriteLine($"{name}:{number}");
    else
        Console.WriteLine($"{name} : phone book me nahi hai");
}

foreach (var (name,number) in phoneBook)
    Console.WriteLine($"  {name,-14} {number}");

Console.WriteLine($"Total: {phoneBook.Count}");
