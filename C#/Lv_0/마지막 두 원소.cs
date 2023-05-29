using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] a = new int[num_list.Length+1];
        for(int i=0; i<num_list.Length; i++) a[i] = num_list[i];
        if(a[a.Length-2] > a[a.Length-3]) a[a.Length-1] = a[a.Length-2]-a[a.Length-3];
        else a[a.Length-1] = a[a.Length-2]*2;
        return a;
    }
}