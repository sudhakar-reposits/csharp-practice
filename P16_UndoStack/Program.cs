Stack<string> history=new Stack<string>();
history.Push("Hello");
history.Push("Bold");
history.Push("Color:Red");
Console.WriteLine($"aakhri Kaam (Peek): {history.Peek()}");

while(history.Count>0)
    Console.WriteLine($"Undo -> {history.Pop()}");

Queue<string> pq=new Queue<string>();
pq.Enqueue("Invoice.pdf");
pq.Enqueue("Salary.xlsx");
pq.Enqueue("Photo.jpg");

while(pq.Count>0)
    Console.WriteLine($"Print -> {pq.Dequeue()}");

