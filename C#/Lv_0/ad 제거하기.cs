using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> answer = new List<string>();
        foreach(string str in strArr)
            if(!str.Contains("ad")) answer.Add(str);
        return answer.ToArray();
    }
}

// Linq를 이용한 더 간단한 방법!
// public class Solution {
//     public string[] solution(string[] strArr) {
//         return strArr.Where(x => !x.Contains("ad")).ToArray();
//     }
// }