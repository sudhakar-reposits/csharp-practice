List<Employees> emps = [
    new("Ravi","IT","Pune",85_000m,2019),
    new("Asha","HR","Delhi",60_000m,2021),
    new("Sunil","IT","Delhi",95_000m,2017),
    new("Meena","Sales","Mumbai",70_000m,2022),
    new("Kiran","IT","Pune",72_000m,2023),
    new("Dinesh","Sales","Pune",55_000m,2020),
    new("Pooja","HR","Mumbai",48_000m,2024),
    new("Arjun","Finance","Delhi",90_000m,2024),
    new("Neha","Finance","Pune",66_000m,2021),
    new("Vikas","IT","Mumbai",58_000m,2025),
    new("Seema","Sales","Delhi",62_000m,2019),
    new("Rahul","Finance","Mumbai",79_000m,2022)
];
var ppDept=emps
            .GroupBy(e=>e.Dept)
            .Select(g=> $"{g.Key} {g.Count()}");


Console.WriteLine($"Q1 {string.Join(',',ppDept)}");
Console.WriteLine($"Q2 {emps.Average(e=>e.Salary):N0}");
Console.WriteLine($"Q3 {emps.MaxBy(e=>e.Salary)!.Name}");

var do20kbaad=emps
            .Where(e=>e.JoinYear>2020)
            .OrderBy(e=>e.JoinYear).Select(r=>r.Name);
Console.WriteLine($"Q4 {string.Join(',',do20kbaad)}");

var uniqueCitiesaz=emps.Select(e=>e.City).Distinct().Order();
Console.WriteLine($"Q5 {string.Join(',',uniqueCitiesaz)}");

Console.WriteLine($"Q6 {string.Join(',',emps.Where(e=>e.City=="Pune" && e.Dept=="IT").Select(r=>r.Name))}");

var allDeptTotSalDesc=emps
                    .GroupBy(e=>e.Dept)
                    .Select(g=>new {Dept=g.Key, Total=g.Sum(s=>s.Salary)})
                    .OrderByDescending(r=>r.Total).Select(x=>$"{x.Dept} {x.Total:N0}");

Console.WriteLine($"Q7 {string.Join(',',allDeptTotSalDesc)}");

Console.WriteLine($"Q8 {string.Join(',',emps.Where(e=>e.Salary>=60_000m && e.Salary<=80_000m).OrderBy(s=>s.Salary).Select(r=>r.Name))}");

Console.WriteLine($"Q9 {string.Join(',',emps.MaxBy(e=>e.JoinYear)!.Name)}");

var everyDeptTopEarn=emps
                .GroupBy(e=>e.Dept)
                .Select(g=>$"{g.Key} {g.MaxBy(e=>e.Salary)!.Name}");
                
Console.WriteLine($"Q10 {string.Join(',',everyDeptTopEarn)}");

record Employees(string Name, string Dept, string City, decimal Salary,int JoinYear);