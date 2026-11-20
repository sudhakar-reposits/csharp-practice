List<Sale> sales = [
    new Sale("Pune","Ravi",12_000m),
    new Sale("Delhi","Asha",8_500m),
    new Sale("Pune","Sunil",4_000m),
    new Sale("Mumbai","Meena",15_000m),
    new Sale("Delhi","Kiran",9_500m),
    new Sale("Pune","Asha",6_000m),
    new Sale("Mumbai","Ravi",3_500m),
];

var cityWiseSale=sales
                .GroupBy(s=>s.City)
                .Select(g=>new{ City= g.Key,TotalSales=g.Count(),Amount=g.Sum(s=>s.Amount)})
                .OrderByDescending(r=>r.Amount);

foreach(var sale in cityWiseSale)
    Console.WriteLine($"{sale.City,-7} {sale.TotalSales} sales  Rs  {sale.Amount:N0}");

Console.WriteLine($"Grand Total: Rs {sales.Sum(s=>s.Amount):N0} | Average: Rs {sales.Average(s=>s.Amount):N0}");





record Sale(string City, string SalesPerson, decimal Amount);