using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        int mod = max;
        while(mod != 0)
            {
                mod = max % min;
                max = min;
                min = mod;
            }
        mod = b/max;
        
        List<int> answer = new List<int>();
        for(int i=2; i<mod+1; i++)
            while (mod % i == 0)
            {
                answer.Add(i);
                mod /= i;
            }
        
        for(int i=0; i<answer.Count; i++)
            if(answer[i] != 2 && answer[i] != 5) return 2;
        return 1;
    }
}