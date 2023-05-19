using System;

public class Solution {
    public int solution(int[] num_list) {
        string hol = "";
        string jak = "";
        foreach(int i in num_list)
        {
            if(i%2 == 0) jak += i.ToString();
            else hol += i.ToString();
        }
        return int.Parse(hol) + int.Parse(jak);
    }
}