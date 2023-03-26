using TableInConsole;

// Приветствие
Console.WriteLine("*** TABLE ***");
int size = 0;
bool breaker = false;
string? text = null;
char border = '+';

// Ввод размера таблицы
do{
    Console.WriteLine("Enter the dimension of the table: ");
    breaker = int.TryParse(Console.ReadLine(), out size);
    if(!breaker)
    {
        Console.WriteLine("Incorrect input!");
    }
    else if(size <= 6 && size >= 1)
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Entered incorrect size. Size of a table must from 1 to 6.");
    }
}while(size < 1 || size > 6);


// Ввод текста
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

//Ожидание
Console.WriteLine();
Thread.Sleep(1000);

//Создание экземпляра таблицы
Table tbl = new Table(size, text, border);

//Вывод таблицы
tbl.PrintBorder();
PrintSomeEmptyLines(size, tbl);
tbl.PrintText();
PrintSomeEmptyLines(size, tbl);
tbl.PrintBorder();
tbl.PrintChess();
tbl.PrintBorder();
tbl.PrintSquare();
tbl.PrintBorder();
Console.ReadLine();

// Вывод нескольких пустых строк
static void PrintSomeEmptyLines(int num, Table tbl)
{
    for(int i = 0; i < num - 1; i++)
    {
        tbl.PrintEmptyLine();
    }
}