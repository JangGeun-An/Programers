using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int len = my_string.Length;
        for(int i=0; i<len; i++)
        {
            if(my_string == is_suffix) return 1;
            my_string = my_string.Substring(1);
        }
        return 0;
    }
}