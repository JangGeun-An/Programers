using System;

public class 이상한_문자_만들기 {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split();
        for(int i=0; i<str.Length; i++)
        {
            for(int j=0; j<str[i].Length; j++)
                answer += j%2 != 0 ? str[i][j].ToString().ToLower() : str[i][j].ToString().ToUpper();
            if(i < str.Length-1) answer += " ";
        }
        return answer;
    }
}