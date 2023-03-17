using System;

public class 직각삼각형_출력하기
{
    public static void Main()
    {
        String[] s;
        Console.Clear();
        int n = Int32.Parse(Console.ReadLine().Split(' ')[0]);
        
        for(int i=0; i<n; i++)
        {
            for(int j=0; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}