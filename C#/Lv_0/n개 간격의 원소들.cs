using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length%n == 0 ? num_list.Length/n : num_list.Length/n+1];
        for(int i=0, j=0; i<num_list.Length; i+=n, j++) answer[j] = num_list[i];
        return answer;
    }
}