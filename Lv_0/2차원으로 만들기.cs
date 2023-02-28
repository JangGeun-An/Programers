using System;

public class 2차원으로_만들기  {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length / n,n];
        int l = 0;
        for(int i=0; i<num_list.Length / n; i++)
            for(int j=0; j<n; j++)
                answer[i,j] = num_list[l++];
        return answer;
    }
}