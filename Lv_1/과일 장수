using System;

public class 과일_장수 {
    public int solution(int max, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        Array.Reverse(score);
        for(int i=1; i<=score.Length/m; i++)
            answer += score[i*m-1]*m;
        return answer;
    }
}