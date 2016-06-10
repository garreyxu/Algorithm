namespace Leetcode
{
    class MoveZeroes
    {
        public void Move(int[] nums)
        {
            int nonZero = 1;
            int zero = 0;

            while (nonZero < nums.Length)
            {

                if (nums[zero] != 0)
                {
                    zero ++;
                    nonZero ++;
                    continue;
                }
                
                if (nums[nonZero] != 0)
                {
                    Exchange(zero, nonZero, nums);
                    zero ++;
                }
                nonZero ++;
            }
        }

        public void Exchange(int a, int b, int[] arr)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
