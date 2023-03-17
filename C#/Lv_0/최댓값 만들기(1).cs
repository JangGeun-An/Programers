using System;
using System.Linq;

public class 최댓값_만들기1 {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        int answer = numbers[0] * numbers[1];
        return answer;
    }
}