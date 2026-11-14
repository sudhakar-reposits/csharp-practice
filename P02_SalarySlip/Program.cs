var basic=50000;
Decimal hra=40,da=10,pf=12;
var hraVal=basic*hra/100;
var daVal=basic*da/100;
var pfVal=basic*pf/100;
var Gross=basic+hraVal+daVal;
var netVal=Gross-pfVal;
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

