using System;

public class 덧칠하기 {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int paint = 0;
        foreach(int i in section)
            if(paint < i)
            {
                paint = i+m-1;
                answer++;
            }
        return answer;
    }
}