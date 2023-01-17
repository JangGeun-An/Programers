using System;

public class 배열_두배_만들기 {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        int m = numbers.Length;
        if(m >= 1 && m <= 1000)
        {
           for(int i = 0; i < m; i++)
            {
                if(numbers[i] >= -10000 && numbers[i] <= 10000)
                {
                    answer[i] = 2 * numbers[i];
                }
            }
        }   
        return answer;
    }
}