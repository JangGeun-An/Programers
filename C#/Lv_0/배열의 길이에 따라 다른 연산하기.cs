using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        for(int i=(arr.Length+1)%2; i<arr.Length; i+=2) arr[i] += n;
        return arr;
    }
}