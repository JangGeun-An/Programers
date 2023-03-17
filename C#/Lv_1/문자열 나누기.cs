using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int cnt = 0;
        int eq = 0;
        int noeq = 0;
        while(true)
        {
            if(s.Length < 2)
            {
                if(s.Length%2 == 1) answer++;
                break;
            }
            if(eq>s.Length-eq)
            {
                answer++;
                break;
            }
            
            if(s[cnt] == s[0]) eq++;
            else if(s[cnt] != s[0]) noeq++;
            cnt++;
            if(eq == noeq)
            {
                s = s.Substring(cnt);
                eq = 0;
                noeq = 0;
                cnt = 0;
                answer++;
            }
        }
        return answer;
    }
}