using System;

public class 시저_암호 {
    public string solution(string s, int n) {
        string answer = "";
        foreach(char a in s)
        {
            if(a!=' ')
            {
                int i = 0;
                
                if((int)a<91)
                {
                    i = (int)a + n;
                    if(i>90) i -= 26;
                }
                else
                {
                    i = (int)a + n;
                    if(i>122) i -= 26;
                }
                answer += Convert.ToChar(i);    
            }
            else answer += ' ';
        }
        return answer;
    }
}