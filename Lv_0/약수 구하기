using System;

public class 약수_구하기 {
    public int[] solution(int n) {
        int[] answer = new int[n];
        int k = 0;
        for(int i=1; i<=n; i++)
        {
            if(n%i == 0)
            {
                answer[k] = i;
                k++;
            }
        }
        Array.Resize(ref answer, k);
        return answer;
    }
}