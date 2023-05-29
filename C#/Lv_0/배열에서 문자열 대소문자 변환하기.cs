using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[strArr.Length];
        for(int i=0; i<strArr.Length; i++) 
            answer[i] = i%2 == 1 ? strArr[i].ToUpper() : strArr[i].ToLower();
        return answer;
    }
}