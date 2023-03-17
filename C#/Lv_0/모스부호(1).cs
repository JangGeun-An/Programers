using System;

public class 모스부호1 {
    public string solution(string letter) {
        string answer = "";
        string[] s = new string[]{".-","-...","-.-.","-..",".","..-.","--.",
                                  "....","..",".---","-.-",".-..","--","-.",
                                  "---",".--.","--.-",".-.","...","-","..-",
                                  "...-",".--","-..-","-.--","--.."};
        string[] sp = letter.Split(' ');
        for(int i=0; i<sp.Length; i++)
            for(int j=0; j<s.Length; j++)
                if(sp[i] == s[j]) answer += (char)(j + 97);
        return answer;
    }
}