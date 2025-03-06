// geçtiğimiz hafta worstcase ve bestcase den bahsettik. y=c 
using System.Numerics;
using System.Text;


internal class Program
{
    public static void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    /* A utility function to print array of size n */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }

    // Driver method
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        printArray(arr);

        Console.WriteLine("***\n***\n***\n");
        sort(arr);
        printArray(arr);
    }
    /* 
    big o -> ? üst sınırı söyler worstCase
    omega alt sınırı söyler -> bestcase
    teta ortalamayı söyler...
    küçük o olduguda eşit olmaz mutlaka daha az olur
    (logn)^k = o(n)
    metrikler (big o, omega ...), foksiyon grupları(n^2,logn,nlogn...)
    karmaşık binary searchte 1: en iyisi, logn: en kötüsü  karmasıklık degerleri
    

     */
    public static void bubblesort() 
    {
        // O(n^2)
    }
    public static void selectionsort()
    {
        // O(n^2) 
    }
    /*
     * max subbaray problem
     * 
    

}