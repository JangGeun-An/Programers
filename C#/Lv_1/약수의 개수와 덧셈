using System;

public class 약수의_개수와_덧셈 {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i=left; i<=right; i++)
        {
            int k = 0;
            for(int j=1; j<=i; j++) if(i%j == 0) k++;
            answer += k%2 == 0 ? i : -i;
        }
        return answer;
    }
}