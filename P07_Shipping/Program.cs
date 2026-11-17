var zonWeight=new [] {("Local",0.5m,false),("Local",3m,true),("National",7.5m,false),
("National",1m,true)};

foreach (var (zone,kg, express) in zonWeight)
{
    decimal chargeAmt=Charge(zone,kg,express);
    Console.WriteLine($"{zone,-9} {kg,5} kg  express={express,-6}=> Rs {chargeAmt}");
}



static decimal Charge(string zone, decimal kg, bool express)
{
    decimal charges=(zone, kg) switch
    {
      (_,<=0)=>throw new ArgumentOutOfRangeException(nameof(kg),"Weight 0 se zyada hona chahiye"),
      ("Local",<=1)=>40,
      ("Local",<=5)=>80,
      ("Local",>5)=>150,
      ("National",<=1)=>90,
      ("National",<=5)=>180,
      ("National",>5)=>350,
      _=>throw new ArgumentException($"Unknown Zone {zone}",nameof(zone))
    };

    return express?charges*1.5m:charges;
}