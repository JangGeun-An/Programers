using System;

public class 중복된_숫자_개수 {
    public int solution(int[] array, int n) {
        int answer = 0;
        if(1<=array.Length && array.Length<=100)
        {
            if(0<=n && n<=1000)
            {
                for(int i=0; i<array.Length; i++)
                {
                    if(0<=array[i] && array[i]<=1000)
                    {
                        if(n == array[i])
                            answer++;
                    }
                }
            }
        }
        return answer;
    }
}