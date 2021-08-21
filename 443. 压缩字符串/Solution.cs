using System;
public class Solution {
    public int Compress(char[] chars) {
        int r = 1;
        char t = chars[0];
        int n = 1;
        for (int i = 1; i < chars.Length; i ++)
        {
            if (chars[i] == t)
                n++;
            else
            {
                if (n > 1)
                    foreach (char c in n.ToString())
                        chars[r++] = c;
                t = chars[i];
                n = 1;
                chars[r++] = t;
            }
        }
        if (n > 1)
            foreach (char c in n.ToString())
                chars[r++] = c;
        return r;
    }
}
