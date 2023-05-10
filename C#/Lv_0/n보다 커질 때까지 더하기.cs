using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        foreach(int i in numbers)
        {
            if(answer > n) return answer;
            answer += i;
        }
        return answer;
    }
}