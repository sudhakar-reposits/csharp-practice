var order=new Order{
  Id=101,
  Customer="Sharma Traders",
  Items=["Keyboard","Mouse","Monitor"],
  Total=18_500m  
};

Console.WriteLine($"Order #{order.Id} | {order.Customer} | {order.Items.Count} items | Rs {order.Total}");
Console.WriteLine($"Items: {string.Join(',',order.Items)}");


class Order
{
    public required int Id { get; init; }
    public required string Customer { get; init; }
    public required List<string> Items { get; init; }
    public decimal Total { get; init;}

}