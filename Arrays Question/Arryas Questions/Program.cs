// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



//Q.1) Implement a method to find the subarray with the maximum sum (Kadane’s Algorithm) in a given integer array.

class Program1
{
    static int Runcode(int []arr)
    {
        int maxCurr =arr[0];
        int maxUp =arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            maxCurr = Math.Max(arr[i], maxCurr + arr[i]);
            maxUp = Math.Max(maxUp, maxCurr);
        }
        return maxUp;
    }

    public static void Main(string[] args)
    {
        int [] arr={1,3,4,7,8,9,5,3,-2,5,9};
        int ans=Runcode(arr);
        Console.WriteLine("Maximum Sumarray is :- " +ans);
    }
}