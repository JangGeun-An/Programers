using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        if(arr1.Length == arr2.Length)
        {
            int a1 = arr1.Sum();
            int a2 = arr2.Sum();
            return a1>a2 ? 1 : a1==a2 ? 0 : -1;
        }
        return arr1.Length > arr2.Length ? 1 : -1;
    }
}