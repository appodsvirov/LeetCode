// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// This is MountainArray's API interface.
// You should not implement it, or speculate about its implementation
public class MountainArray
{
    private int[] arr = new int[20000];
     public int Get(int index) { return arr[index]; }
     public int Length() { return 10; }
 }


class Solution
{
    public int FindInMountainArray(int target, MountainArray mountainArr)
    {
        int peakIndex = BinarySearchPeek(mountainArr);
        int first = BinarySearch(mountainArr, target, 0, peakIndex, true);
        if (first != -1) return first;

        int last = BinarySearch(mountainArr, target, peakIndex + 1, mountainArr.Length() - 1, false);
        return last;
    }

    private int BinarySearchPeek(MountainArray mountainArr)
    {
        int first = 0;
        int last = mountainArr.Length() - 1;

        while (first < last)
        {
            int middleIndex = first + (last - first) / 2;
            if (mountainArr.Get(middleIndex) < mountainArr.Get(middleIndex + 1))
                first = middleIndex + 1;
            else
                last = middleIndex;
        }

        return first;
    }

    private int BinarySearch(MountainArray mountainArr, int target, int first, int last, bool searchMin)
    {
        while (first <= last)
        {
            int middleIndex = first + (last - first) / 2;
            int minddleValue = mountainArr.Get(middleIndex);

            if (minddleValue == target) return middleIndex;

            if (searchMin)
            {
                if (minddleValue < target)
                    first = middleIndex + 1;
                else
                    last = middleIndex - 1;
            }
            else
            {
                if (minddleValue > target)
                    first = middleIndex + 1;
                else
                    last = middleIndex - 1;
            }
        }

        return -1;
    }
}