using System;

namespace RemoveElement
{
    class Program
    {
        static int RemoveElement(int [] nums, int val)
        {
            int pointer1 = 0;
            for(int pointer2=0;pointer2<nums.Length; pointer2++)
            {
                if (nums[pointer2] != val)
                {
                    nums[pointer2] = nums[pointer1];
                    pointer1++;
                }
            }
            return pointer1;
        }
        static void Main(string[] args)
        {
            int[] number = { 0, 1, 2, 3, 4, 0, 2, 1 };
            int value = 2;
            int result=RemoveElement(number, value);
         
            Console.WriteLine(result);
            
        }
    }
}
