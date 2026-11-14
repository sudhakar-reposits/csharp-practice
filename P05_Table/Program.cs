using P05_Table;

Console.WriteLine("Enter the Number:");
int n=int.TryParse(Console.ReadLine(),out int value)?value:2;
TableFormatter.Print(n);

