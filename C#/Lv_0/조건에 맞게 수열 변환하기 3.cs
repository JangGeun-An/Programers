using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> answer = new List<int>();
        if(k%2 == 0) foreach(int i in arr) answer.Add(i+k);
        else foreach(int i in arr) answer.Add(i*k);
        return answer.ToArray();
    }
}