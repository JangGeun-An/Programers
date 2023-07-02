using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        int j=0;
        for(int i=n; i<num_list.Length; i++, j++) answer[j] = num_list[i];
        for(int i=0; i<n; i++, j++) answer[j] = num_list[i];
        return answer;
    }
}