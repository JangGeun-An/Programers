using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int k = 0;
        int[] sol = new int[]{0,0,0};
        int[] answer = new int[]{1,2,3};
        int[] a1 = new int[] {1,2,3,4,5};
        int[] a2 = new int[] {2,1,2,3,2,4,2,5};
        int[] a3 = new int[] {3,3,1,1,2,2,4,4,5,5};
        for(int i=0; i<answers.Length; i++)
        {
            if(answers[i] == a1[i%a1.Length]) sol[0]++;
            if(k == 4) k=0;
            else k++;
            if(i == answers.Length-1) k=0;
        }
        
        for(int i=0; i<answers.Length; i++)
        {
            if(answers[i] == a2[k]) sol[1]++;
            if(k == 7) k=0;
            else k++;
            if(i == answers.Length-1) k=0;
        }
        
        for(int i=0; i<answers.Length; i++)
        {
            if(answers[i] == a3[k]) sol[2]++;
            if(k == 9) k=0;
            else k++;
        }
        
        Array.Sort(sol, answer);
        List<int> ans = new List<int>();
        if(sol[2] != sol[1]) ans.Add(answer[2]);
        else if(sol[2] == sol[1] && sol[1] != sol[0])
        {
            ans.Add(answer[2]);
            ans.Add(answer[1]);
        }
        else if(sol[2] == sol[1] && sol[1] == sol[0])
        {
            ans.Add(answer[2]);
            ans.Add(answer[1]);
            ans.Add(answer[0]);
        }
        ans.Sort();
        
        return ans.ToArray();

        // 2번째 방법, 간편하고 런타임도 적음
        // int[] sol = new int[3];
        // int[] answer = new int[]{1,2,3};
        // int[] a1 = new int[] {1,2,3,4,5};
        // int[] a2 = new int[] {2,1,2,3,2,4,2,5};
        // int[] a3 = new int[] {3,3,1,1,2,2,4,4,5,5};
        
        // for(int i=0; i<answers.Length; i++)
        // {
        //     if(answers[i] == a1[i%a1.Length]) sol[0]++;
        //     if(answers[i] == a2[i%a2.Length]) sol[1]++;
        //     if(answers[i] == a3[i%a3.Length]) sol[2]++;
        // }

        // List<int> ans = new List<int>();
        // if(sol[0] == sol.Max()) ans.Add(1);
        // if(sol[1] == sol.Max()) ans.Add(2);
        // if(sol[2] == sol.Max()) ans.Add(3);
        
        // return ans.ToArray();
    }
}