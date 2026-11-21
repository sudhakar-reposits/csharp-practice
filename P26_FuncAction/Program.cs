Func<double,double,double> add=(a,b)=>a+b;
Func<double,double,double> mul=(a,b)=>a*b;
Action<string> log= msg => Console.WriteLine($"[LOG] {msg}");
Predicate<double> isEven= no =>no%2==0;

log($" {5} + {3} = {add(5,3)}");
log($" {5} * {3} = {mul(5,3)}");
log($" 8 even hai = {isEven(8)}");

var ops=new Dictionary<string, Func<double, double, double>>
{
  ["+"]=add,
  ["-"]=(a,b)=>a-b,
  ["*"]=mul,
  ["/"]=(a,b)=>b==0?double.NaN:a/b,
  ["%"]=(a,b)=>a%b,
  ["^"]=(a,b)=>Math.Pow(a,b)
};

foreach (var (symbol,op) in ops)
    Console.WriteLine($"10 {symbol} 4 = {op(10,4)}");

Console.WriteLine(ops.TryGetValue("%",out var fun)?fun(5,2):double.NaN);

//function ko parameter me bhejna
Console.WriteLine($"Apply(6,7,mul) = {Apply(6,7,mul)}");

static double Apply(double a, double b, Func<double,double,double> operation)=>operation(a,b);
