using System;

public class 숫자_찾기 {
    public int solution(int num, int k) {
        string s1 = num.ToString();
        string s2 = k.ToString();
        int answer = 0;
        for(int i=0; i<s1.Length; i++)
        {
            if(s1[i] == s2[0])
            {
                answer = i+1;
                break;
            }
        }
        if(answer == 0) answer = -1;
        return answer;
    }
}