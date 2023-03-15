Console.WriteLine("*** TABLE ***");
int size = 0;
bool breaker = false;
string? text = null;
char border = '+';
do{
    Console.WriteLine("Enter the dimension of the table: ");
    breaker = int.TryParse(Console.ReadLine(), out size);
    if(!breaker)
    {
        Console.WriteLine("Incorrect input!");
    }
    else if(size < 6 && size > 1)
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Entered incorrect size. Size of a table must from 1 to 6.");
    }
}while(size < 1 || size > 6);

while(breaker)
{
    Console.WriteLine("Enter the any text: ");
    text = Console.ReadLine();
    if(text == null || text == " " || text == "")
    {
        Console.WriteLine("Entered incorrect line.");
        breaker = true;
    }
    else
    {
        Console.WriteLine("Success");
        breaker = false;
    }
}