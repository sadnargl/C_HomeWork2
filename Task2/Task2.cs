Console.Write ("Введите число: ");
if (int.TryParse (Console.ReadLine(), out int i))
{
    if (i<0) i= Math.Abs(i);
    if (i.ToString().Length <= 2)
    {
        Console.WriteLine ("Третьей цифры нет");  
    }
    else
    {
        Console.WriteLine ($"Третья цифра числа: {i.ToString()[2]}"); 
    }
}
else
{
Console.WriteLine ("Вы ввели не числo, либо не целое число, либо слишком большое число");        
}