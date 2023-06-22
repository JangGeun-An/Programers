using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string myString) {
        return Regex.Replace(myString, @"[^l-z]", "l");
    }
}

// Linq Select 기능을 이용한 간단한 방법
// public class Solution {
//     public string solution(string myString){
//         return new string(myString.Select(s => s - 'l' > 0 ? s : 'l').ToArray());
//     }
// }