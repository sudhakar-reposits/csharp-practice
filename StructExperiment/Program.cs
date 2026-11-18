using System.Runtime.Intrinsics.Arm;

PointStruct a=new(1,2);
PointStruct b=a;        //poori copy ban gyi
b.X=100;
Console.WriteLine($"struct: a.X= {a.X}, b.X= {b.X}");

PointClass c1=new(1,2);
PointClass c2=c1;     //copy nhi, same object reference
c2.X=100;
Console.WriteLine($"class: c1.X= {c1.X}, c2.X= {c2.X}");

MoveStruct(a);
Console.WriteLine($"Movestruct(a) ke baad a.X={a.X}");
MoveClass(c1);
Console.WriteLine($"MoveClass(c1) ke baad c1.X={c1.X}");

static void MoveStruct(PointStruct p)=>p.X+=50;
static void MoveClass(PointClass p)=>p.X+=50;
struct PointStruct
{
    public int X;
    public int Y;

    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class PointClass
{
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
}
