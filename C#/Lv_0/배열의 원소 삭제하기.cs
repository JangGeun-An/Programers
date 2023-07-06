using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> answer = new List<int>();
        foreach(int i in arr)
        {
            int x = 0;
            foreach(int j in delete_list) if(i == j) x = 1; continue;
            if(x == 0)answer.Add(i);
        }
        return answer.ToArray();
    }
}

// RemoveAll을 활용한 간단한 방법
// public class Solution {
//     public int[] solution(int[] arr, int[] delete_list) {
//         List<int> answer = new List<int>(arr);
//         foreach(int i in delete_list)
//         {
//             answer.RemoveAll(x => x == i);
//         }
//         return answer.ToArray();
//     }
// }

// // Linq의 Except(차집합 함수)를 활용한 방법
// public class Solution {
//     public int[] solution(int[] arr, int[] delete_list) {
//         return arr.Except(delete_list).ToArray();
//     }
// }