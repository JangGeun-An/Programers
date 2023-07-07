using System;

public class Solution {
    public int solution(string binomial) {
        string[] str = binomial.Split(" ");
        return str[1] == "+" ? int.Parse(str[0]) + int.Parse(str[2]) :
        str[1] == "-" ? int.Parse(str[0]) - int.Parse(str[2]) :
        int.Parse(str[0]) * int.Parse(str[2]);
    }
}