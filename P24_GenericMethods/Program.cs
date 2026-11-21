int a=5,b=9;
string x="Ram",y="Shyam";
Swap<int>(ref a,ref b);
Swap<string>(ref x, ref y);
Console.WriteLine($"Swap int   : a = {a}, b = {b}");
Console.WriteLine($"Swap string: x = {x}, y = {y}");
Console.WriteLine($"Max int    :{Max<int>(32,42)}");
Console.WriteLine($"Max string :{Max<string>("Mango","Apple")}");
Console.WriteLine($"Max date   :{Max<DateOnly>(new DateOnly(2026,1,1),new DateOnly(2026,5,21))}");

static void Swap<T>(ref T a, ref T b)
{
    (a,b)=(b,a);
};

static T Max<T>(T a,T b) where T:IComparable<T>
{
   return  a.CompareTo(b)>=0?a:b;
};