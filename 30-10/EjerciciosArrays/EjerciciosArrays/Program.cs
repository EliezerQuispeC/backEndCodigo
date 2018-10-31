using System;

namespace EjerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10] { 1, 1, 1, 3, 4, 5, 6, 3, 4, 2 };
            RemoveDuplicates(nums);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
