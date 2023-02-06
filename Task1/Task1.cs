// В этот раз решил обработать все возможные исключения. Чтобы, прога не вылетала

Console.Write ("Введите трехзначное число: ");
if (int.TryParse (Console.ReadLine(), out int i))
{
    if (i<0) i= Math.Abs(i);
    if (i.ToString().Length != 3)
    {
        Console.WriteLine ("Вы ввели не трехзначное числo");  
    }
    else
    {
        Console.WriteLine ($"Вторая цифра числа: {i.ToString()[1]}"); 
    }
}
else
{
Console.WriteLine ("Вы ввели не числo, либо не целое число, либо слишком большое число");        
}
