var p=new Person("Ravi",35,"Pune");
Console.WriteLine(p);
//p.Age=40;
Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");

var (name,age,city)=p;
Console.WriteLine($"{name} | {age} | {city}");

public record Person(string Name, int Age, string city);

