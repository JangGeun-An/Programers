using System;

public class 콜라_문제 {
    public int solution(int empty, int full, int n) {
        int answer = 0;
        while(n/empty > 0)
        {
            answer += (n/empty) * full;
            n = (n%empty) + ((n/empty) * full);
        }
        return answer;
    }
}