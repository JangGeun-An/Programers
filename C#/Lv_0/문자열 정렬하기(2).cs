using System;
using System.Linq;

public class 문자열_정렬하기2 {
    public string solution(string my_string) {
        string answer = string.Concat(my_string.ToLower().OrderBy(ch => ch));
        return answer;
    }
}