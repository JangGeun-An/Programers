using System;

public class OX퀴즈 {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        for(int i=0; i<quiz.Length; i++)
        {
            int a = 0;
            string[] str = quiz[i].Split(" ");
            
            if(str[1].Contains("+")) a = Convert.ToInt32(str[0]) + Convert.ToInt32(str[2]);
            else a = Convert.ToInt32(str[0]) - Convert.ToInt32(str[2]);
            
            if(a == Convert.ToInt32(str[4])) answer[i] = "O";
            else answer[i] = "X";
        }
        return answer;
    }
}