
var e1=new Employee("Asha","HR",50000m);
var e2=e1 with {Salary=e1.Salary+(e1.Salary*0.10m)};
var e3=e1 with {Dept="IT"};
Console.WriteLine($"Pehle   : {e1}");
Console.WriteLine($"Hike    : {e2}");
Console.WriteLine($"Transfer: {e3}");
Console.WriteLine($"e1 ki salary abhi bhi: {e1.Salary}");
Console.WriteLine($"e1 aur e2 same object? {e1==e2}");


public record Employee(string Name,string Dept,decimal Salary);