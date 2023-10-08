Solution s = new Solution();
Console.WriteLine(s.MaxDotProduct(
    new int[] { 2, 1, -2, 5 },
    new int[] { 3, 0, -6 }
    ));
public class Solution
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int[,] externalWork = new int[nums1.Length, nums2.Length];

        for (int first1 = 0; first1 < nums1.Length; first1++)
        {
            for (int first2 = 0; first2 < nums2.Length; first2++)
            {
                externalWork[first1, first2] = int.MinValue;
            }
        }
        return Dot(nums1, nums2, 0, 0, externalWork);
    }
    private static int Dot(int[] nums1, int[] nums2, int first1, int first2, int[,] externalWork)
    {
        if (first1 == nums1.Length || first2 == nums2.Length)  return int.MinValue;

        if (externalWork[first1, first2] != int.MinValue) return externalWork[first1, first2];

        externalWork[first1, first2] = 
            Math.Max(
                nums1[first1] * nums2[first2] + Math.Max(
                                                Dot(nums1, nums2, first1 + 1, first2 + 1, externalWork)
                                                ,
                                                0
                                                )
                ,
                Math.Max(
                    Dot(nums1, nums2, first1 + 1, first2, externalWork)
                    ,
                    Dot(nums1, nums2, first1, first2 + 1, externalWork)
            )
        );

        return externalWork[first1, first2];
    }
}