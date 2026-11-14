Console.WriteLine("Namaste, Sudhakar Tripathi!");
DateOnly Today=DateOnly.FromDateTime(DateTime.Now);
DateOnly goalDate=new DateOnly(2027,11,14);
int DaysLeft=goalDate.DayNumber-Today.DayNumber;
Console.WriteLine($"Aaj: {Today: dd-MMM-yyyy (dddd)}");
Console.WriteLine($"Senior .NET goal tak {DaysLeft} din baaki hain.");
