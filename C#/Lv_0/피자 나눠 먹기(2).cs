using System;

public class 피자_나눠_먹기2 {
    public int solution(int n) {
        int lcm = 0;
        for(int i=n*6; i>=1; i--)
            if(i%n==0 && i%6==0) lcm = i;
        int answer = lcm / 6;
        return answer;
    }
}