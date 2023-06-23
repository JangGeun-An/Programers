using System;

public class Solution {
    public string solution(string n_str) {
        int j = 0;
        for(int i=0; i<n_str.Length; i++)
        {
            if(n_str[i] != '0')
            {
                j = i;
                break;
            }
        }
        string answer = n_str.Substring(j);
        return answer;
    }
}

// 숫자로 변환시켜 0제거, 더 간단함
// public class Solution {
//     public string solution(string n_str) {
//         return Int32.Parse(n_str).ToString();
//     }
// }