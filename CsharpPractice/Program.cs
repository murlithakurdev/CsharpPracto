using CsharpPractice;

class Program
{
    public static void Main()
    {
        CircleArea obj = new CircleArea();
        obj.Calculate(9);
        //CircleArea
        //AddNumber(5, 9);
        // SubNumber(2, 9);
        //printPiramidLeft(5);
        //printPiramidRight(5);
    }

    public static void AddNumber(int a, int b)
    {
        int c = a + b;
        Console.WriteLine(c);
    }

    public static void SubNumber(int a, int b)
    {
        int c = a - b;
        Console.WriteLine(c);
    }

    static void printPiramidRight(int n) 
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    static void printPiramidLeft(int n)
    {
        for (int i = n; i < n; i++)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}