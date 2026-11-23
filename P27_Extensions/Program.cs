using System.Text;
using P27_Extensions;

string name ="  ravi kumar sharma  ";
Console.WriteLine($"[ {name.ToTitleCase()} ]");
Console.WriteLine($"Words: {name.WordCount()}");
Console.WriteLine($"Truncate: {"Senior Full Stack Deveoper".Truncate(12)}");


int[] num=[5,12,8,21,3,16];
Console.WriteLine($"MyWhere > 10 : {string.Join(", ",num.MyWhere(n=>n>10))}");
Console.WriteLine($"Linq > 10 : {string.Join(", ",num.Where(n=>n>10))}");


static class MyLinq
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source,Func<T,bool> predicate)
    {
        foreach(T item in source)
            if(predicate(item))
                yield return item;
    }
}