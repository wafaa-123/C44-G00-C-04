using System;

class Program
{
    static void Main()
    {
        #region 1 - Check if 3 points lie on a straight line
        
        Console.WriteLine("Enter x1 and y1:");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter x2 and y2:");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter x3 and y3:");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            Console.WriteLine("Points are on the same line\n");
        else
            Console.WriteLine("Points are NOT on the same line\n");
        #endregion

        #region 2 - Worker Efficiency
        
        Console.Write("Enter time taken by worker (in hours): ");
        double time = double.Parse(Console.ReadLine());

        if (time >= 2 && time < 3)
            Console.WriteLine("Highly efficient\n");
        else if (time >= 3 && time < 4)
            Console.WriteLine("Increase your speed\n");
        else if (time >= 4 && time <= 5)
            Console.WriteLine("Training required to improve speed\n");
        else if (time > 5)
            Console.WriteLine("You are to leave the company\n");
        else
            Console.WriteLine("Invalid input\n");
        #endregion

        #region 3 - Sum of array elements
  
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum = " + sum + "\n");
        #endregion

        #region 4 - Merge two sorted arrays
        
        int[] a = { 1, 4, 7 };
        int[] b = { 2, 5, 6 };
        int[] merged = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
            merged[i] = a[i];

        for (int i = 0; i < b.Length; i++)
            merged[a.Length + i] = b[i];

        Array.Sort(merged);
        Console.WriteLine("Merged array:");
        foreach (int num in merged)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
        #endregion

        #region 5 - Longest distance between equal values
   
        int[] arr = { 1, 2, 3, 1, 4, 5, 1 };
        int maxDist = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    int dist = j - i - 1;
                    if (dist > maxDist)
                        maxDist = dist;
                }
            }
        }

        Console.WriteLine("Longest distance: " + maxDist + "\n");
        #endregion

        #region 6 - Reverse word order
        
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
        #endregion
    }
}
