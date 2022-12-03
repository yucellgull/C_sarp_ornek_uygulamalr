using System;
public class a
{
    static void Main()
    {
        object x;
        x = 10;
        Console.WriteLine(x.GetType());
        x = "B";
        Console.WriteLine(x.GetType());
        x = 8.75F;
        Console.WriteLine(x.GetType());
        x = false;
        Console.WriteLine(x.GetType());
        x = 5.489M;
        Console.WriteLine(x.GetType());
    }
}
public class b
{

}