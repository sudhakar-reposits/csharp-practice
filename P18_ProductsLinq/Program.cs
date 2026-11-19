List<Product> products = [
    new("Laptop","Electronics",55_000m,5),
    new("Mouse","Electronics",600m,50),
    new("Chair","Furniture",4_500m,0),
    new("Desk","Furniture",12_000m,3),
    new("Pen","Stationery",20m,500),
    new("Monitor","Electronics",9_000m,8)
];

//SELECT Name, Price FROM Products where Category='Electronics' Order by Price desc
var e_mts=products.
        Where(p=>p.Category=="Electronics")
        .OrderByDescending(p=>p.Price)
        .Select(p=>$"{p.Name} ({p.Price})");
Console.WriteLine($"Electronics: {string.Join(',',e_mts)}");


//SQL: Select Name from Products where Stock=0
var outOfstock=products
                .Where(p=>p.Stock==0).Select(p=>p.Name); 
Console.WriteLine($"Stock Khatm: {string.Join(',',outOfstock)}");

//SQL: Select Name from Products where Price<5000
var less5k=from p in products
            where p.Price<5_000m
            orderby p.Name
            select p.Name;
Console.WriteLine($"5000 se saste: {string.Join(',',less5k)}");

Console.WriteLine($"Sabse Mehanga: {products.MaxBy(p=>p.Price)?.Name}");




record Product(string Name, string Category, decimal Price, int Stock);