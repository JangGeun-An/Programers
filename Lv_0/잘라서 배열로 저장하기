using System;
using System.Collections.Generic;

public class 잘라서_배열로_저장하기 {
    public string[] solution(string my_str, int n) {
        List<string> str = new List<string>();
        while(my_str.Length > n)
        {
            str.Add(my_str.Substring(0, n));
            my_str = my_str.Remove(0, n);
        }

        str.Add(my_str);
        string[] answer = str.ToArray();
        return answer;
    }
}