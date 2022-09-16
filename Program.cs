internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = {1,2,5,8,9,11};
        int arr_size = arr.Length;

        Pair minmax = getMinMax(arr, arr_size);
        Console.Write("Minimum element is {0}",
                                   minmax.min);
        Console.Write("\nMaximum element is {0}",
                                     minmax.max);

       

    }

    private static Pair getMinMax(int[] arr, int arr_size)
    {
        Pair minmax = new Pair();
        int n = arr.Length;

         if (n == 1)
        {
            minmax.max = arr[0];
            minmax.min = arr[0];
            return minmax;
        }
        if (arr[0] > arr[1])
        {
            minmax.max = arr[0];
            minmax.min = arr[1];
        }else{
            minmax.max = arr[1];
            minmax.min = arr[0];
        }
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] > minmax.max)
            {
                minmax.max = arr[i];
            }else if(arr[i] < minmax.min)
            {
                minmax.min = arr[i];
            }
        }
        return minmax;

    }

    class Pair
    {
        public int max;
        public int min;
    }
}