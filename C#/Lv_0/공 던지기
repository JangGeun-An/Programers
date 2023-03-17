using System;

public class 공_던지기 {
    public int solution(int[] numbers, int k) {
        int answer = 1;
        while(k != 1)
        {
            if(answer == numbers.Length) answer = 2;
            else if(answer == numbers.Length-1) answer = 1;
            else answer += 2;
            k--;
        }
        return answer;
    }
}