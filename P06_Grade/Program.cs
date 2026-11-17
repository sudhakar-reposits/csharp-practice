int[] allMarks=[95,82,71,55,38,101,-5];

//Console.WriteLine("Enter Marks:");
//string? val=Console.ReadLine();
foreach(int val in allMarks)
{

//if(int.TryParse(val, out int nval))
    Console.WriteLine($"{val,4} => Result: {GetGrade(val)}");
//else
//     Console.WriteLine("Blank not allowed..");
}


static string GetGrade(int marks) => marks switch
{
    <0 or >100 => "Invalid",
    >90 => "A+",
    >75=>"A",
    >60=>"B",
    >40=>"C",
    _=>"Fail"
};