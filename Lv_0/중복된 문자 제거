using System;
using System.Linq;

public class 중복된_문자_제거 {
    public string solution(string my_string) {
        string answer = "";
        char[] s = my_string.Distinct().ToArray();
        for(int i=0; i<s.Length; i++) answer+= s[i];

        //string answer = string.Concat(my_string.Distinct()); // 2번 방법
        return answer;
    }
}