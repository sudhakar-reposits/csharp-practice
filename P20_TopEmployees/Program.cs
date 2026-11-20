List<Employee> emps = [
    new("Ravi","IT",85_000m),
    new("Asha","HR",60_000m),
    new("Sunil","IT",95_000m),
    new("Meena","Sales",70_000m),
    new("Kiran","IT",85_000m),
    new("Dinesh","Sales",55_000m),
];

var top3=emps
        .OrderByDescending(e=>e.Salary).ThenBy(s=>s.Name).Take(3);

Console.WriteLine("Top 3 Salary:");
int rank=1;
foreach (var emp in top3)
    Console.WriteLine($"{rank++}. {emp.Name,-7} {emp.Dept,-7} {emp.Salary:N0}");
   // rank++;

int pageNo=2,pageSize=2;
var noPage=emps.OrderBy(e=>e.Name)
            .Skip((pageNo-1)*pageSize)
            .Take(pageSize).Select(e=>e.Name);
            //.Take(pageSize).Select(e=> new {Name=e.Name, Sal=e.Salary});

Console.WriteLine($"Page {pageNo}: {string.Join(',',noPage)}");

decimal itasal=emps
        .Where(e=>e.Dept=="IT").Average(e=>e.Salary);
Console.WriteLine($"IT ki average salary: {itasal:N0}");
record Employee(string Name,string Dept,decimal Salary);