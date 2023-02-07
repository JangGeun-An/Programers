using System;
using System.Collections.Generic;

public class 나누어_떨어지는_숫자_배열 {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        foreach(int i in arr)
            if(i%divisor == 0) answer.Add(i);
        if(answer.Count == 0) answer.Add(-1);
        answer.Sort();
        return answer.ToArray();
    }
}