using System;
using System.Collections.Generic;

public class 명예의_전당1 {
    public int[] solution(int k, int[] score) {
        List<int> sol = new List<int>();
        List<int> answer = new List<int>();
        for(int i=0; i<score.Length; i++)
        {
            if(i<k)
            {
                sol.Add(score[i]);
                sol.Sort();
                sol.Reverse();
                answer.Add(sol[sol.Count-1]);
                
            }
            
            else
            {
                sol.Add(score[i]);
                sol.Sort();
                sol.Reverse();
                answer.Add(sol[k-1]);
            }
        }
        return answer.ToArray();

        // 2번째 간단한 방법!
        // int[] answer = new int[score.Length];
        // List<int> sol = new List<int>();
        // int count = 0;
        // foreach(int i in score)
        // {
        //     sol.Add(i);
        //     sol.Sort();
        //     if(sol.Count>k)
        //         sol.RemoveAt(0);
        //     answer[count++] = sol[0];
        // }
        // return answer;
    }
}