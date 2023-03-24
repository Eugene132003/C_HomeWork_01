class Task_02
{
    public static void Main()
    {
        int a2 = 2, b2 = 3, c2 = 7;
        int max2 = a2;

        if (a2 > max2) max2 = a2;
        if (b2 > max2) max2 = b2;
        if (c2 > max2) max2 = c2;

        Console.Write("max = " + max2);
    }
}