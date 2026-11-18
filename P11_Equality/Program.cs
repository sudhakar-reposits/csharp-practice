var c1=new PersonClass("Ravi",35);
var c2=new PersonClass("Ravi",35);
Console.WriteLine($"For Class c1==c2: {c1==c2}");
Console.WriteLine($"for Class c1.Equals(c2): {c1.Equals(c2)}");

var r1=new PersonRecord("Ravi",35);
var r2=new PersonRecord("Ravi",35);
Console.WriteLine($"For Record r1==r2: {r1==r2}");
Console.WriteLine($"for Record r1.Equals(r2): {r1.Equals(r2)}");
Console.WriteLine($"for Record ReferenceEquals(r1,r2): {ReferenceEquals(r1,r2)}");



class PersonClass
{
    public string? Name { get; set;}
    public int Age { get; set; }

    public PersonClass(string name, int age)=>(Name,Age)=(name,age);
}
public record PersonRecord(string Name, int Age);