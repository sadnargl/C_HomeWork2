//С обработкой исключений

Console.Write ("Введите число, обозначающее день недели: ");
if (int.TryParse (Console.ReadLine(), out int i))
{
    if ((i.ToString().Length == 1) && (i<=7) && (i!=0))
    {
        if ((i == 6) || (i == 7))
        {
            Console.WriteLine ("Это выходной"); 
        }
        else
        {
            Console.WriteLine ("Это будний день"); 
        } 
    }
    else
    {
        Console.WriteLine ("Вы ввели число вне диапазона 1-7");
    }
}
else
{
Console.WriteLine ("Вы ввели не числo, либо не целое число, либо слишком большое число");     
}

