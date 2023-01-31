using System;
using System.Collections.Generic;

public class 등수_매기기 {
    public int[] solution(int[,] score) {
        double[] answer = new double[score.Length/2];
        List<int> rank = new List<int>();
        for(int i=0; i<answer.Length; i++)
        {
            rank.Add(1);
            answer[i] = ((double)score[i,0] + (double)score[i,1])/2;
        }
        for(int i=0; i<answer.Length; i++)
            for(int j=0; j<answer.Length; j++)
                if(answer[i]<answer[j]) rank[i]++;
        
        return rank.ToArray();
    }
}