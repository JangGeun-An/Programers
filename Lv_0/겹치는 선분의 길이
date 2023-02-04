using System;
using System.Collections.Generic;

public class 겹치는_선분의_길이 {
    public int solution(int[,] lines) {
        List<int> line = new List<int>();
        List<int> count = new List<int>();
        int answer = -100;
        int k = 0;
        while(answer != 101)
        {
            line.Add(answer);
            count.Add(0);
            answer++;
            k++;
        }
        answer = 0;
        
        for(int i=lines[0,0]; i<lines[0,1]; i++)
            if(line.Contains(i)) count[line.IndexOf(i)]++;
        for(int i=lines[1,0]; i<lines[1,1]; i++)
            if(line.Contains(i)) count[line.IndexOf(i)]++;
        for(int i=lines[2,0]; i<lines[2,1]; i++)
            if(line.Contains(i)) count[line.IndexOf(i)]++;
        
        for(int i=0; i<200; i++)
            if(count[i] > 1) answer++;
        return answer;
    }
}