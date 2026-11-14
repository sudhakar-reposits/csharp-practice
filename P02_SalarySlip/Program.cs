decimal basic=50000m;
const decimal hra=0.40m,da=0.10m,pf=0.12m;
decimal hraVal=basic*hra;
decimal daVal=basic*da;
decimal pfVal=basic*pf;
decimal Gross=basic+hraVal+daVal;
decimal netVal=Gross-pfVal;
Console.WriteLine("""
===========================
        SALARY SLIP
===========================
""");
Line("Basic",basic);
Line("HRA",hraVal);
Line("DA",daVal);
Line("Gross",Gross);
Line("PF",pfVal);
Console.WriteLine(new string('-',27));
Line("Net",netVal);
// Local function: label left-align 12 jagah me, amount right-align 15 jagah me, comma + 2 decimal
void Line(string label,decimal amount)=>
Console.WriteLine($"{label,-12}{amount,15:N2}");

