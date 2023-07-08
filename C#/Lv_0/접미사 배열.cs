using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string my_string) {
        List<string> answer = new List<string>();
        for(int i=1; i<=my_string.Length; i++)
            answer.Add(my_string.Substring(my_string.Length-i));
        answer.Sort();
        return answer.ToArray();
    }
}