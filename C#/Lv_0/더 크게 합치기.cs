using System;

public class Solution {
    public int solution(int a, int b) {
        int a1 = int.Parse($"{a}{b}");
        int b1 = int.Parse($"{b}{a}");
        return Math.Max(a1,b1);
    }
}