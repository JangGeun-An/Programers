using System;
using System.Text.RegularExpressions;

public class 문자열_정렬하기1 {
    public int[] solution(string my_string) {
        string num = Regex.Replace(my_string, @"\D", "");
        int[] answer = new int[num.Length];
        for(int i=0; i<num.Length; i++)
            answer[i] = (int)num[i] - 48;
        Array.Sort(answer);
        return answer;
    }
}