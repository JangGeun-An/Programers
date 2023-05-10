using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[n];
        for(int i=0; i<n; i++) answer[i] = num_list[i];
        return answer;
    }
}

// Linq Take메서드를 이용해서 더 간단히
// using System;
// using System.Linq;

// public class Solution {
//     public int[] solution(int[] num_list, int n) {
//         return num_list.Take(n).ToArray();
//     }
// }