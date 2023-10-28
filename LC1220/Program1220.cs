// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    public int CountVowelPermutation(int n)
    {
        const int mod = 1000000007;

        long a = 1, e = 1, i = 1, o = 1, u = 1;
        long a_next = 1, e_next = 1, i_next = 1, o_next = 1, u_next = 1;

        for (int j = 1; j < n; j++)
        {
            a_next = e;
            e_next = (a + i) % mod;
            i_next = (a + e + o + u) % mod;
            o_next = (i + u) % mod;
            u_next = a;

            a = a_next;
            e = e_next;
            i = i_next;
            o = o_next;
            u = u_next;
        }

        return (int)((a + e + i + o + u) % mod);
    }
}