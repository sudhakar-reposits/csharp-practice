int age=ReadInt("Apni age likho(1-120):",1,120);

string group=age<18?"Bachcha":age<60?"Youva/Adult":"Senior";
Console.WriteLine($"Age {age} => {group}");

static int ReadInt(string prompt, int min, int max)
{
    while(true)
    {
        Console.WriteLine(prompt);
        string? input=Console.ReadLine();

        if(input is null)
        {
            Console.WriteLine($"Input nahi mila, {min} le rahe hain");
            return min;
        }

        if(int.TryParse(input.Trim(),out int value) && value>=min && value<=max)
        return value;

         Console.WriteLine($"'{input}' sahi age nahi hai. Dobara try karo.");
    }
}