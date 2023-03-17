using System;

public class 팩토리얼 {
    public int solution(int n) {
        int answer = 1;
        int i = 1;
        while(true)
        {
            if(answer > n)
            {
                answer = i-2;
                break;
            }
            answer = answer * i;
            i++;
        }
        return answer;
    }
}