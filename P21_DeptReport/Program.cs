List<Employee> emps = [
    new("Ravi","IT",85_000m),
    new("Asha","HR",60_000m),
    new("Sunil","IT",95_000m),
    new("Meena","Sales",70_000m),
    new("Kiran","IT",85_000m),
    new("Dinesh","Sales",55_000m),
];

List<DeptSummary> dSummary=emps
                        .GroupBy(e=>e.Dept)
                        .Select(g=>new DeptSummary(g.Key,g.Count(),g.Max(s=>s.Salary),g.Average(s=>s.Salary)))
                        .OrderBy(d=>d.Dept)
                        .ToList();

foreach(var rec in dSummary)
    Console.WriteLine($"{rec.Dept,-7} log: {rec.People}  max: {rec.MaxSalary:N0}  avg:  {rec.AvgSalary:N0}");

Console.WriteLine($"{dSummary[0]}");

Dictionary<string,decimal> salDet=emps.ToDictionary(s=>s.Name,s=>s.Salary);
Console.WriteLine($"Meena ki Salary: {salDet["Meena"]:N0}");

record Employee(string Name,string Dept,decimal Salary);
record DeptSummary(string Dept, int People, decimal MaxSalary, decimal AvgSalary);
