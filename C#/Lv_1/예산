using System;

public class 예산 {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int sum = 0;
        Array.Sort(d);
        for(int i=0; i<d.Length; i++)
        {
            if(sum + d[i] <= budget)
            {
                sum += d[i];
                answer++;
            }
            else break;
        }
        return answer;
    }
}