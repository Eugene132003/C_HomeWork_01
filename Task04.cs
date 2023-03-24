class Task_04
{
    public static void Main()
    {
        //int a = 5;
        int a = 8;
        for (int i = 1; i < a + 1; i++)
        {
            if (i % 2 == 0)
            {
                if (i+1<a)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}