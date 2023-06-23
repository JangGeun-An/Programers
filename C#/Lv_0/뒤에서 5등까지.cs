using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];
        Array.Sort(num_list);
        for(int i=0; i<5; i++) answer[i] = num_list[i];
        return answer;
    }
}

// Linq를 이용한 간단한 방법
// public class Solution {
//     public int[] solution(int[] num_list) {
//         return num_list.OrderBy(x=>x).Take(5).ToArray();
//     }
// }