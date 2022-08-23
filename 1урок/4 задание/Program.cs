int a = 2;
int b = 3;
int c = 7;
int Max = a;

if (Max > b)
{
   if (Max > c)
    {
        Console.WriteLine("число " + Max + " максимальное ");

    }
    else
    {
        Max = c;
        Console.WriteLine("число " + Max + " максимальное ");
    }

}
else
{
    Max=b;
    if (Max>c)
    {
        Console.WriteLine("число " + Max + " максимальное ");
    }
    else
    {
        Max=c;
        Console.WriteLine("число " + Max + " максимальное ");
    }

}


