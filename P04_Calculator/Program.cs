double a =ReadDouble("Pehla Number: ");
double b =ReadDouble("Doosra Number: ");

double ReadDouble(string v)
{
    while (true)
    {
        Console.WriteLine(v);
        string? input=Console.ReadLine();

        if(input is null)  // input band: warna loop kabhi khatam nahi hoga
        {
             Console.WriteLine("Input nahi mila, 0 le rahe hain.");
            return 0;
        }

        if(double.TryParse(input,out double value))
            return value;

        Console.WriteLine("Sirf Number Likho");
    }
}

Console.WriteLine("Operator (+ - * /):");
string op=Console.ReadLine()?.Trim()??"";

switch (op)
{
    case "+":
    Console.WriteLine($"{a}+{b}={a+b}");
    break;
    case "-":
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case "/":
    if (b==0)
        Console.WriteLine("Zero se divide nhi kr skte");
    else
        Console.WriteLine($"{a}/{b}={a/b:0.####}");
    break;

    default:
        Console.WriteLine($"'{op}' galat operator hai.");
        break;
    
}


