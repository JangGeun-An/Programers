using System;

public class 배열의_평균값 {
    public double solution(int[] numbers) {
        double answer = 0;
        if(numbers.Length >= 1 && numbers.Length <= 100)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] >= 0 && numbers[i] <= 1000)
                {
                    answer = answer + numbers[i];
                }
            }
        }
        return (answer/numbers.Length);
    }
}