using System;

public class 양꼬치 {
    public int solution(int n, int k) {
        int answer = 0;
        if((0<n && n<1000)&&((n/10)<=k && k<1000))
        {
            if(n>=10)
                answer = (n*12000) + (k*2000) - ((n/10)*2000);
            else
                answer = (n*12000) + (k*2000);
        }
        return answer;
    }
}