using System;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string answer = "";
        foreach(string i in str_list) if(!i.Contains(ex)) answer += i;
        return answer;
    }
}