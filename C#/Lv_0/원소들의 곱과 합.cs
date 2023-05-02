using System;

public class Solution {
    public int solution(int[] num_list) {
        int sum = 0;
        int mul = 1;
        foreach(int i in num_list)
        {
            sum += i;
            mul *= i;
        }
        return sum*sum>mul ? 1 : 0;
    }
}