public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] a = s.ToCharArray();
        int t = k + k;
        int n = a.Length;
        for (int i = 0; i < n; i += t)
        {
            int p = i, q = (i + k < n ? i + k : n) - 1;
            while (p < q)
                (a[p], a[q]) = (a[q--], a[p++]);
        }
        return new string(a);
    }
}
