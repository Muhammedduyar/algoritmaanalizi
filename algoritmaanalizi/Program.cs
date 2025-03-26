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
    public static void bubblesort(int[] arr) 
    {
        // O(n^2)
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Değiştirme işlemi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    public static void selectionsort(int[] arr)
    {
        // O(n^2) 
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Değiştirme işlemi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    public static void InsertionSort(int[] arr)
    {
        //O(n^2)
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }

    }
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Sol ve sağ yarıları sırala
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // Sıralı yarıları birleştir
            Merge(arr, left, mid, right);
        }


    }
    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        // Geçici diziler oluştur
        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        // Verileri kopyala
        for (int i = 0; i < leftSize; i++)
            leftArr[i] = arr[left + i];

        for (int j = 0; j < rightSize; j++)
            rightArr[j] = arr[mid + 1 + j];

        // Birleştirme işlemi
        int a = 0, b = 0, k = left;
        while (a < leftSize && b < rightSize)
        {
            if (leftArr[a] <= rightArr[b])
            {
                arr[k] = leftArr[a];
                a++;
            }
            else
            {
                arr[k] = rightArr[b];
                b++;
            }
            k++;
        }

        // Kalan elemanları kopyala
        while (a < leftSize)
        {
            arr[k] = leftArr[a];
            a++;
            k++;
        }

        while (b < rightSize)
        {
            arr[k] = rightArr[b];
            b++;
            k++;
        }

        // Test Verisi

        // **** ****


        //int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        //Console.WriteLine("Orijinal Dizi: " + string.Join(", ", arr));

        //MergeSort(arr, 0, arr.Length - 1);

        //Console.WriteLine("Sıralanmış Dizi: " + string.Join(", ", arr));

    }
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Eğer hedef ortadaysa
            if (arr[mid] == target)
                return mid;

            // Eğer hedef ortadan küçükse, sol yarıya bak
            if (arr[mid] > target)
                right = mid - 1;

            // Eğer hedef ortadan büyükse, sağ yarıya bak
            else
                left = mid + 1;
        }

        return -1; // Eleman bulunamazsa -1 döndür

        //  Test Verisi

        //int[] arr = { 1, 3, 5, 7, 9, 11, 15 };
        //int target = 7;

        //int result = BinarySearch(arr, target);

        //if (result != -1)
        //    Console.WriteLine($"Eleman {target}, {result}. indekste bulundu.");
        //else
        //    Console.WriteLine($"Eleman {target} dizide bulunamadı.");
    }




}