using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> answer = new List<int> ();
        for(int i=n-1; i<num_list.Length; i++) answer.Add(num_list[i]);
        return answer.ToArray();
    }
}

// Linq Skip 메서드를 이용한 간단한 방법
// using System;
// using System.Linq;

// public class Solution {
//     public int[] solution(int[] num_list, int n) {
//         return num_list.Skip(n - 1).ToArray();
//     }
// }