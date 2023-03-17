using System;
using System.Collections.Generic;

public class 숫자_짝꿍 {
    public string solution(string X, string Y) {
        string answer = "";
        List<char> x1 = new List<char>(X.ToCharArray());
        List<char> y1 = new List<char>(Y.ToCharArray());
        x1.Sort();
        x1.Reverse();
        
        for(int i=0; i<x1.Count; i++)
            if(y1.Contains(x1[i]))
            {
                answer += x1[i];
                y1.Remove(x1[i]);
            }
        
        if(answer.Length == 0) answer += "-1";
        else if(answer[0] == '0') answer = "0";
        return answer;

        //위의 방법은 테스트케이스 11~15 시간초과 뜨므로 아래 방법사용 권장
        // string answer = "";
        // for(int i=9; i>-1; i--)
        // {
        //     int x = X.Length;
        //     int y = Y.Length;
        //     X = X.Replace($"{i}","");
        //     Y = Y.Replace($"{i}","");
        //     int total = Math.Min(x - X.Length, y - Y.Length);
        //     answer += new string(char.Parse(i.ToString()), total);
        // }
        
        // if(answer.Length == 0) return "-1";
        // else if(answer[0] == '0') return "0";

        // return answer;
    }
}