namespace Repetition___Loopar_och_arrayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 5, 12, 423, 66, 3, 11 };

            Console.WriteLine($"The lowest number in the array is {LowestNumber(intArray)}");

            Console.WriteLine($"The highest number in the array is {HighestNumber(intArray)}");

            Console.WriteLine($"The average value of the array is {AverageNumber(intArray)}");

            SortIntArray(intArray);

            foreach (int i in intArray)
            {
                Console.Write($"{i}, ");
            }
        }


        public static int LowestNumber(int[] arr)
        {
        int lowestNumber = arr[0];
            for (int i = 1; i <= arr.Length-1; i++)
            {
            if (lowestNumber > arr[i])
                {
                    lowestNumber = arr[i];
                }
            }
            return lowestNumber;
        }

        public static int HighestNumber(int[] arr)
        {
            int highestNumber = arr[0];
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (highestNumber < arr[i])
                {
                    highestNumber = arr[i];
                }
            }
            return highestNumber;
        }

        public static int AverageNumber(int[] arr)
        {
            int arraySum = arr[0];
            for (int i = 1; i <= arr.Length-1; i++)
            {
                arraySum += arr[i]; 
            }
           return (arraySum / arr.Length);
        }

        public static int[] SortIntArray(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            sortedArray[0] = arr[0];
            for (int i = 0; i <= arr.Length-1; i++)
            {
            for(int j=1; j <= arr.Length-1; j++)
                {
                    if (arr[j-1] > arr[j])
                    {
                        int swap = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j] = swap;                       
                    }                   
                } 
            }
            sortedArray = arr;
            return sortedArray;
        }
    }
}

   