namespace ChallengeLab10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0], nums2 = [2, 5, 6];
            int m = 3, n = 3;
            Console.WriteLine($"Combined Array: [ {string.Join(", ", GetCombinedArrays(nums1, nums2, m, n).Select(x => x))} ]");
            Console.ReadLine();
        }

        public static int[] GetCombinedArrays(int[] arr1, int[] arr2, int m, int n)
        {
            arr1 = arr1.Where(x => x != 0).ToArray();
            arr2 = arr2.Where(x => x != 0).ToArray();
            int[] combinedArray = arr1.Concat(arr2).ToArray();
            Array.Sort(combinedArray);

            return combinedArray;
        }
    }
}
