using System;
using System.Collections.Generic;

public class 연속된_수의_합 {
    public int[] solution(int num, int total) {
        List<int> answer = new List<int>();
        int a = (2 * total / num + 1 - num) / 2;
        
        for(int i = 0; i < num; i++)
            answer.Add(a + i);
        
        return answer.ToArray();
    }
}