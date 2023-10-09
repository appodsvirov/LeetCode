// See https://aka.ms/new-console-template for more information
Solution s = new Solution();
Console.WriteLine(string.Join(", " ,s.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8)));

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        return new int[] { 
            BinarySearch(nums, target, 0, nums.Length - 1, true),
            BinarySearch(nums, target, 0, nums.Length - 1, false) 
        };
    }
    private static int BinarySearch(int[] nums, int target, int first, int last, bool findFirstIndex)
    {
        if (first > last) return -1; // индексы переселкись => target не найден

        int middle = (first + last) / 2; // индекс левой середины массива
        int middleValue = nums[middle]; // значение в левой середины массива

        if (middleValue == target) 
        {
            if(findFirstIndex)
            {
                if (middle-1 < 0 || nums[middle - 1] != target)
                {
                    return middle;
                }
                else
                {
                    return BinarySearch(nums, target, first, middle - 1, findFirstIndex); //=> ищем слева
                }
            }
            else
            {
                if (middle + 1 > nums.Length - 1 || nums[middle + 1] != target)
                {
                    return middle;
                }
                else
                {
                    return BinarySearch(nums, target, middle + 1, last, findFirstIndex); //=> ищем справа
                }
            }
        }

        else if (middleValue > target)
        {
            return BinarySearch(nums, target, first, middle - 1, findFirstIndex); //=> ищем слева
        }
        else
        {
            return BinarySearch(nums, target, middle + 1, last, findFirstIndex); //=> ищем справа
        }
    }


}  
