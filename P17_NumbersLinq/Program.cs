List<int> nos=[12,45,7,88,23,64,51,90,3,76];
Console.WriteLine($"Even: {string.Join(',',nos.Where(n=>n%2==0))}");
Console.WriteLine($"50 se base (sorted): {string.Join(',',nos.Where(n=>n>50).OrderBy(n=>n))}");;
Console.WriteLine($"Top 5: {string.Join(',',nos.OrderByDescending(n=>n).Take(5))}");
Console.WriteLine($"Pehle 3 ke square: {string.Join(',',nos.Take(3).Select(n=>n*n))}");
Console.WriteLine($"50 se bade kitne: {nos.Count(n=>n>50)}");
Console.WriteLine($"Koi 100+ hai? {nos.Any(n=>n>100)}");
Console.WriteLine($"Pehla Odd: {nos.First(n=>n%2 is not 0)}");
//Console.WriteLine($"Pehla Odd: {nos.FirstOrDefault(n=>n>100)}");
