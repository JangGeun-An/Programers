using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        return num_list.OrderBy(x=>x).Skip(5).ToArray();
    }
}