using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        foreach(int i in arr) for(int j=0; j<i; j++) answer.Add(i);
        return answer.ToArray();
    }
}

// Linq를 활용한 더 좋은 방법
// public class Solution {
//     public int[] solution(int[] arr) 
//     {
//         List<int> answer = new List<int>();
//         foreach(int n in arr)
//             answer.AddRange(Enumerable.Repeat(n, n));
//         return answer.ToArray();
//     }
// }