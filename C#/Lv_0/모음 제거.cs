using System;

public class 모음_제거 {
    public string solution(string my_string) {
        string answer = my_string.Replace("a","");
        answer = answer.Replace("e","");
        answer = answer.Replace("i","");
        answer = answer.Replace("o","");
        answer = answer.Replace("u","");
        return answer;
    }
}