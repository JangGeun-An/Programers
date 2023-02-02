using System;
using System.Collections.Generic;

public class 저주의_숫자_3 {
    public int solution(int n) {
        int Town_num = 1;
        int Sipjin = 1;
        List<string> a = new List<string>();
        while(Sipjin < n+1)
        {
            if(Town_num.ToString().Contains("3") || Town_num % 3 == 0) Town_num++;
            else
            {
                a.Add(Town_num.ToString());
                Town_num++;
                Sipjin++;
            }
        }
        int answer = Convert.ToInt32(a[a.Count-1]);
        return answer;

        // 2번째 방법, 더 간결하고 처리속도도 빠름
        // int answer = 0;
        // int count = 1;
































































        // for(int i=0;i<n;i++)
        // {
        //     answer++;
        //     while(answer%3==0||answer.ToString().Contains("3")) answer++;
        // }
        // return answer;
    }
}