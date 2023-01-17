using System;

public class 분수의_덧셈 {
    int[] answer = new int[2];
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int n1 = (numer1 * denom2) + (numer2 * denom1);
        int d1 = denom1 * denom2;
        int n2 = n1;
        int d2 = d1;
        int i;
        while(true)
        {
            i = n1 % d1;
            n1 = d1;
            d1 = i;
            if(i == 0)
            {
                answer[0] = n2 / n1;
                answer[1] = d2 / n1;
                break;
            }
        }
        return answer;
    }
}