using System;
using System.Linq;
using System.Collections.Generic;

public class 소인수분해 {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        for(int i=2; i<n+1; i++)
            while (n % i == 0)
            {
                answer.Add(i);
                n /= i;
            }
        return answer.Distinct().ToArray();
    }
}