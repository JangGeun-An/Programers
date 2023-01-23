using System;

public class 암호_해독 {
    public string solution(string cipher, int code) {
        string answer = "";
        for(int i=0; i<cipher.Length; i++)
            if((i+1)%code == 0)
                answer += cipher[i];
        return answer;
    }
}