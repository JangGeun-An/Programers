using System;

public class 가장_가까운_같은_글자 {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        string str = "";
        for(int i=0; i<s.Length; i++)
        {
            if(str.Contains(s[i])) answer[i] = i - str.LastIndexOf(s[i]);
            else answer[i] = -1;
            str += s[i];
        }
        return answer;
    }
}