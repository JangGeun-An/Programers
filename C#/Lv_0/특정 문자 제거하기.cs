using System;
using System.Collections.Generic;

public class 특정_문자_제거하기 {
    public string solution(string my_string, string letter) {
        string answer = my_string.Replace(letter, "");
        return answer;
    }
}