public class Solution
{
    //0x55555555 =
    // 0101 0101 0101 0101 0101 0101 0101 0101
    public bool IsPowerOfFour(int n) =>
    (n & 0x55555555) != 0 && 
    (n & (n - 1)) == 0
    ;
}