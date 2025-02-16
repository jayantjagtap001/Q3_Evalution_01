
class problem2
{
    static int [] findtheInter(int []arr1,int []arr2)
    {
        int[] res=new int[Math.Min(arr1.Length,arr2.Length)];
        int k=0;

        for (int i = 0;i<arr1.Length;i++)
        {
            for(int j=0;j<arr2.Length;j++)
            {
                if (arr1[i]==arr2[j])
                {
                    bool isDupli=false;
                    for (int m=0;m<k;m++)
                    {
                        if (res[m]==arr1[i])
                        {
                            isDupli = true;
                            break;
                        }
                    }
                    if (!isDupli)
                    {
                        res[k++] = arr1[i];
                    }
                    break;
                }
            }
        }

        Array.Resize(ref res, k); 
        return res;
    }
    static int [] findUnion(int []arr1,int [] arr2)
    {
        int[] temp=new int[arr1.Length + arr2.Length];
        int k=0;

        for(int i=0;i<arr1.Length;i++)
        {
            temp[k++]=arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            bool isDupli = false;
            for (int j = 0; j < k; j++)
            {
                if (temp[j] == arr2[i])
                {
                    isDupli = true;
                    break;
                }
            }
            if (!isDupli)
            {
                temp[k++] = arr2[i];
            }
        }

        int[] res=new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = temp[i];
        }

        return res;
    }

    public static void Main(string[] args)
    {
        int [] arr1={1,2,4,5,6,7,8};
        int [] arr2={2,7};

        int[] findtheInterAns=findtheInter(arr1,arr2);
        int [] findUnionAns=findUnion(arr1,arr2);


        Console.WriteLine("intersection  is " +string.Join(",",findtheInterAns));
        Console.WriteLine("Union is:- "+string.Join(",",findUnionAns));

    }
}