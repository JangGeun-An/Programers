using System;
using System.Text.RegularExpressions;

public class 숨어있는_숫자의_덧셈2 {
    public int solution(string my_string) {
        int answer = 0;
        string[] str = Regex.Replace(my_string, @"\D", " ").Split(' ');
        for(int i=0; i<str.Length; i++)
            if (Int32.TryParse(str[i], out int j)) answer+= j;
        return answer;
    }
}