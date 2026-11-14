namespace P05_Table;

public static class TableFormatter
{
    public static void Print(int n, int upTo=10)
    {
        Console.WriteLine($"--- {n} ka Table ---");
        for(int i=1;i<=upTo;i++)
        {
            Console.WriteLine($"{n,3} x {i,2} = {n*i, 4}"); 
         //  Console.WriteLine($"{n,-3} x {i,2} = {n*i, 4}"); 
        //    Console.WriteLine($"{n} x {i} = {n*i}"); 
        }
    }
}