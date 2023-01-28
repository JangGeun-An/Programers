using System;

public class 컨트롤_제트 {
    public int solution(string s) {
        int answer = 0;
        string[] str = s.Split(" ");
        for(int i=0; i<str.Length; i++)
        {
            if(str[i] == "Z") answer -= Convert.ToInt32(str[i-1]);
            else answer += Convert.ToInt32(str[i]);
        }
        return answer;
    }
}