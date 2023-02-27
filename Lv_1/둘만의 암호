using System;

public class 둘만의_암호 {
    public string solution(string s, string skip, int index) {
        string answer = "";
      
        for(int i=0; i<s.Length; i++)
        {
            char temp = s[i];
            for(int j=0; j<index; )
            {
                temp = (char)((int)temp + 1);
                if(temp > 'z') temp = 'a';
                if(skip.Contains(temp) == true) continue;
                j++;
            }
            answer += temp;
        }
        return answer;
    }
}