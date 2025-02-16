class program4
{
    static int findthefirstMissingNumber(int []arr)
    {
        int n=arr.Length;
        
        for(int i=0;i<n;i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
            {
                arr[i] = n + 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int val=Math.Abs(arr[i]);
            if (val<=n)
            {
                arr[val - 1] = -Math.Abs(arr[val - 1]);
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                return i + 1;
            }
        }
        return n + 1;

    }

    public static void Main(string[] args)
    {
        int []arr= {8,3,-1,1,2};
        int myans=findthefirstMissingNumber(arr);

        Console.WriteLine("This first Missing number is "+myans);
    }
}