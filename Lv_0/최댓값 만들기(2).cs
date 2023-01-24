using System;

public class 최댓값_만들기(2) {
    public int solution(int[] numbers) {
        int k = numbers.Length;
        Array.Sort(numbers);
        int answer = 0;
        if(numbers[0] * numbers[1] > numbers[k-1] * numbers[k-2]) answer = numbers[0] * numbers[1];
        else answer = numbers[k-1] * numbers[k-2];
        return answer;
    }
}