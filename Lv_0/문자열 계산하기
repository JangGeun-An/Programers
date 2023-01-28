using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class 문자열_계산하기 {
    public int solution(string my_string) {
        List<int> num = new List<int>();
        List<string> Oper = new List<string>();
        string[] str = Regex.Replace(my_string, @"\D", " ").Split(' ');
        for(int i=0; i<str.Length; i++)
            if (Int32.TryParse(str[i], out int j)) num.Add(j);
        for(int i=0; i<my_string.Length; i++)
        {
            if(my_string[i] == '+') Oper.Add("+");
            else if(my_string[i] == '-') Oper.Add("-");
        }
        int answer = num[0];
        num.RemoveAt(0);
        for(int i=0; i<Oper.Count; i++)
        {
            if(Oper[i] == "+") answer += num[i];
            else if(Oper[i] == "-") answer -= num[i];
        }
        return answer;

        // 더 간편한 방법, using System 만으로 가능, 부하도 적음
        // int answer = 0;
        // string[] split = my_string.Split(' ');
        // int Oper = 0;
        // for(int i=0;i<split.Length;i++)
        // {
        //     int n;
        //     if(int.TryParse(split[i], out n))
        //     {
        //         if(Oper == 0) answer+=n;
        //         else answer-=n;
        //     }
        //     else
        //     {
        //         if(split[i] == "+") Oper = 0;
        //         else Oper = 1;
        //     }
        // }
        // return answer;
    }
}