using System;

public class Solution {
    public int solution(int[] num_list) {
        for(int i=0; i<num_list.Length; i++) if(num_list[i] < 0) return i;
        return -1;
    }
}

// Array.FindIndex() 메서드를 활용한 더 간단한 방법
// using System;

// public class Solution {
//     public int solution(int[] num_list) {
//         return Array.FindIndex(num_list, x => x<0);
//     }
// }