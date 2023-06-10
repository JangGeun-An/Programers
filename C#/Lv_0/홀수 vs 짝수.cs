using System;

public class Solution {
    public int solution(int[] num_list) {
        int Odd = 0;
        int Even = 0;
        for(int i=0; i<num_list.Length; i++)
        {
            if(i%2 == 0) Even += num_list[i];
            else Odd += num_list[i];
        }
        return Math.Max(Odd, Even);
    }
}