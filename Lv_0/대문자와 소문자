using System;
using System.Linq;

public class 대문자와_소문자 {
    public string solution(string my_string) {
        var CV = my_string.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        string answer = new String(CV.ToArray());
        return answer;
    }
}