using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int k) {
        return string.Concat(Enumerable.Repeat(my_string, k));
    }
}