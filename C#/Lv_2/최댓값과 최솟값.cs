using System;
using System.Linq;

public class 최댓값과_최솟값 {
    public string solution(string s) {
        int[] arr = Array.ConvertAll(s.Split(" "), i => int.Parse(i));
        return $"{arr.Min()} {arr.Max()}";
    }
}