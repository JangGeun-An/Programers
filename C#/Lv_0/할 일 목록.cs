using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        List<string> answer = new List<string>();
        for(int i=0; i<finished.Length; i++)
            if(!finished[i]) answer.Add(todo_list[i]);
        return answer.ToArray();
    }
}

// Linq를 활용한 간단한 방법
// public class Solution {
//     public string[] solution(string[] todo_list, bool[] finished) {
//         return todo_list.Where((v,i) => !finished[i]).ToArray();
//     }
// }