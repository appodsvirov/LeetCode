
using System.Text;


Solution s = new Solution();

Console.WriteLine(s.SortVowels("lEetcOde"));
public class Solution
{
    public string SortVowels(string s)
    {
        Dictionary<char, int> vowels = new Dictionary<char, int>() {
            {'A', 0},
            {'E', 0},
            {'I', 0},
            {'O', 0},
            {'U', 0},
            {'a', 0}, 
            {'e', 0}, 
            {'i', 0}, 
            {'o', 0}, 
            {'u', 0} 
        };
        List<int> vowelIndexs = new List<int>();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            result.Append(s[i]);
            switch (s[i])
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    vowels[s[i]] += 1;
                    vowelIndexs.Add(i);
                    break;
            }
        }
        var enumerator = vowelIndexs.GetEnumerator();
        enumerator.MoveNext();
        foreach (var keyValuePair in vowels)
        {
            for(int n = keyValuePair.Value; n > 0; n--, enumerator.MoveNext())
            {
                result[enumerator.Current] = keyValuePair.Key;
            }
        }
        enumerator.Dispose();
        return result.ToString();
    }
}