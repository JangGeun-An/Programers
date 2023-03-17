using System;

public class n의_배수_고르기 {
    public int[] solution(int n, int[] numlist) {
        int k = 0;
        int[] answer = new int[numlist.Length];
        for(int i=0; i<numlist.Length; i++)
            if(numlist[i] % n == 0)
            {
                answer[k] = numlist[i];
                k++;
            }
        Array.Resize(ref answer, k);
        return answer;
    }
}