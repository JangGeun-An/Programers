using System;

public class 배열_자르기 {
    public int[] solution(int[] numbers, int num1, int num2) {
        int k = num2-num1+1;
        int[] answer = new int[k];
        int j = 0;
        for(int i=num1; i<=num2; i++)
        {
            answer[j] = numbers[i];
            j++;
        }
        return answer;
    }
}