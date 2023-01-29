using System;

public class 진료_순서_정하기 {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        for(int i=0; i<emergency.Length; i++)
        {
            int k=0;
            for(int j=0; j<emergency.Length; j++)
            {
                if(emergency[i]<emergency[j]) k++;
                answer[i] =+ k;
            }
            answer[i] = answer[i] + 1;
        }

        //for(int i=0; i<emergency.Length; i++) 2번째 방법
        //    answer[i] = answer.Length - i;
        //Array.Sort(emergency, answer);
        return answer;
    }
}